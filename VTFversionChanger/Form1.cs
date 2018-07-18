using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VTFversionChanger
{
    public partial class Form1 : Form
    {
        #region InitForm1
        public Form1()
        {
            InitializeComponent();

            this.Icon = Properties.Resources.vtf;
        }
        #endregion
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

            int ia = 0;

            for(int i = 0; i < files.Length; i++)
            {
                string file = files[i];
                ProcessFile(file);
                ia++;
                progressBar.Value = (int)(100f / Convert.ToSingle(files.Length) * Convert.ToSingle(ia));
                Application.DoEvents();
            }

            progressBar.Value = 100;
            SystemSounds.Exclamation.Play();
        }
        #region ProcessFile(string file)
        private void ProcessFile(string file)
        {
            byte[] bytes = File.ReadAllBytes(file);
            List<byte> bbytes = new List<byte>();
            for (int i = 0; i < bytes.Length; i++)
            {
                if (i == 8 && bytes[i] == 0x05) 
                    bbytes.Add(0x04);
                else
                    bbytes.Add(bytes[i]);
            }
            File.WriteAllBytes(file, bbytes.ToArray());
        }
        #endregion
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

        private void button_about_Click(object sender, EventArgs e)
        {
            About frm = new About();

            frm.Show();
        }

        #region Form1_FormClosing
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Exit();
        }
        #endregion
        #region Exit()
        private void Exit()
        {
            try
            {
                if(!string.IsNullOrEmpty(textBox_folder.Text))
                if (File.Exists("settings.cfg"))
                {
                    File.Delete("settings.cfg");
                }
                File.WriteAllText("settings.cfg", textBox_folder.Text);
            }
            catch { }
            if (garbage.IsAlive)
                garbage.Suspend();
            if (updater.IsAlive)
                updater.Suspend();
            Environment.Exit(Environment.ExitCode);
        }
        #endregion
        #region WndProc (move window)
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
        #region Form1_Load
        private Thread garbage, updater;
        private void Form1_Load(object sender, EventArgs e)
        {
            garbage = new Thread(Garbage);
            garbage.Start();

            updater = new Thread(Updater);
            updater.Start();

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
        #region threads
        private void Updater()
        {
            while (true)
            {
                Thread.Sleep(100);
                Invoke((MethodInvoker)delegate ()
                {
                    Refresh();
                });
            }
        }

        private void Garbage()
        {
            while (true)
            {
                Thread.Sleep(10000);
                GC.Collect();
            }
        }
        #endregion
        #region form paint
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
                e.Graphics.DrawRectangle(new Pen(Color.FromArgb(39, 111, 169)), 0f, 0f, Width - 1, Height - 1);
            else
                e.Graphics.DrawRectangle(new Pen(Color.FromArgb(158, 158, 158)), 0f, 0f, Width - 1, Height - 1);
        }
        #endregion
        #region Control buttons (exit and minimize)
        private void button_exit_Click(object sender, EventArgs e)
        {
            Exit();
        }

        private void button_minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        #endregion
        #region Form1_SizeChanged
        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
                WindowState = FormWindowState.Normal;
        }
        #endregion
    }
}
