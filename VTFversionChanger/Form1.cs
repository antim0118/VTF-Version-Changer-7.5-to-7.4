using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VTFversionChanger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_change_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                textBox_folder.Text = fbd.SelectedPath;
                button_start.Enabled = true;
            }
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            string path = textBox_folder.Text;
            string[] files = Directory.GetFiles(path, "*.vtf", SearchOption.AllDirectories);

            int ia = 0;

            foreach (string file in files)
            {
                ProcessFile(file);
                ia++;
                progressBar.Value = (int)(100f / Convert.ToSingle(files.Length) * Convert.ToSingle(ia));
                Application.DoEvents();
            }

            progressBar.Value = 100;
            MessageBox.Show("Well done!");
            progressBar.Value = 0;
        }

        private void ProcessFile(string file)
        {
            byte[] bytes = File.ReadAllBytes(file);
            List<byte> bbytes = new List<byte>();
            for (int i = 0; i < bytes.Length; i++)
            {
                if (i == 8)
                    bbytes.Add(0x04);
                else
                    bbytes.Add(bytes[i]);
            }
            File.WriteAllBytes(file, bbytes.ToArray());
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
            }
        }

        private void button_about_Click(object sender, EventArgs e)
        {
            About frm = new About();

            frm.Show();
        }
    }
}
