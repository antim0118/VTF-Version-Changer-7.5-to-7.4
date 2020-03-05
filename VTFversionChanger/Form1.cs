using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Media;
using System.Windows.Forms;

namespace VTFversionChanger
{
    public partial class Form1 : Form
    {
        Pen form_active, form_not_active;

        #region InitForm
        public Form1()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.vtf;
            form_active = new Pen(Color.FromArgb(39, 111, 169));
            form_not_active = new Pen(Color.FromArgb(158, 158, 158));
        }
        #endregion

        #region Form: Buttons
        private void button_change_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                fbd.RootFolder = Environment.SpecialFolder.MyComputer;
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    textBox_folder.Text = fbd.SelectedPath;
                    button_start.Enabled = true;
                }
            }
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            string path = textBox_folder.Text;
            string[] files = Directory.GetFiles(path, "*.vtf", SearchOption.AllDirectories);

            Stopwatch sw = new Stopwatch();
            sw.Start();
            for (int i = 0; i < files.Length; i++)
            {
                string file = files[i];
                ProcessFile(file);
                progressBar.Value = (int)(100f / (float)(files.Length) * (float)(i));
                Application.DoEvents();
            }
            sw.Stop();
            Log($"Finished in {sw.ElapsedMilliseconds}ms");

            progressBar.Value = 100;
            SystemSounds.Exclamation.Play();
        }

        private void button_start_single_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Valve Texture File|*.vtf";
            ofd.Title = "Select a single Texture File";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                ProcessFile(ofd.FileName);
                progressBar.Value = 100;
                SystemSounds.Exclamation.Play();
            }
        }

        private void button_about_Click(object sender, EventArgs e) => new About().Show();
        #endregion
        #region Form: Load
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists("settings.cfg"))
                {
                    textBox_folder.Text = File.ReadAllText("settings.cfg");
                }
            }
            catch { }
            if (!string.IsNullOrEmpty(textBox_folder.Text))
            {
                button_start.Enabled = true;
            }
        }
        #endregion
        #region Form: Closing
        private void Form1_FormClosing(object sender, FormClosingEventArgs e) => Exit();
        #endregion
        #region Form: Paint
        public bool FormIsActive
        {
            get
            {
                return ActiveForm == this;
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (FormIsActive)
                e.Graphics.DrawRectangle(form_active, 0f, 0f, Width - 1, Height - 1);
            else
                e.Graphics.DrawRectangle(form_not_active, 0f, 0f, Width - 1, Height - 1);
        }
        #endregion
        #region Form: SizeChanged
        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
                WindowState = FormWindowState.Normal;
        }
        #endregion
        #region Form: Control buttons (exit and minimize)
        private void button_exit_Click(object sender, EventArgs e) => Exit();
        private void button_minimize_Click(object sender, EventArgs e) => WindowState = FormWindowState.Minimized;
        #endregion

        #region WndProc (for moving window)
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x84)
            {
                m.Result = (IntPtr)2;  // move
                return;
            }
            base.WndProc(ref m);
        }
        #endregion

        #region Exit
        private void Exit()
        {
            try
            {
                if (!string.IsNullOrEmpty(textBox_folder.Text))
                {
                    if (File.Exists("settings.cfg")) File.Delete("settings.cfg");
                    File.WriteAllText("settings.cfg", textBox_folder.Text);
                }
            }
            catch { }
            Environment.Exit(Environment.ExitCode);
        }
        #endregion

        #region Timer: UI updater
        private void timer_uiupdater_Tick(object sender, EventArgs e) => Refresh();
        #endregion

        #region ProcessFile
        private void ProcessFile(string file)
        {
            //old method: 1st try - 4010ms, 2nd try - ~13000ms
            //new method: 1st try - 70ms,   2nd try - 60ms
            using (FileStream FS = File.OpenRead(file))
            using (BinaryReader BR = new BinaryReader(FS))
            {
                int id = BR.ReadInt32();
                if (id != 0x465456)
                {
                    Log($"Wrong ID. File: {file}");
                    return;
                }
                int majorVersion = BR.ReadInt32(); //==7 anyway
                int minorVersion = BR.ReadInt32();
                if (minorVersion != 5) return; //skip vtfs that are not 7.5
            }
            using (FileStream FS = File.OpenWrite(file))
            using (BinaryWriter BW = new BinaryWriter(FS))
            {
                BW.Seek(8, SeekOrigin.Begin); //skip id and major version
                BW.Write((int)4); //write minor version to 4
            }
        }
        #endregion

        private void Log(string text) => richTextBox_log.Text += $"[{DateTime.Now.ToString("HH:mm:ss")}]" + text + "\n";
    }
}
