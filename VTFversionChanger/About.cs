using System;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace VTFversionChanger
{
    public partial class About : Form
    {
        readonly float waitTime = 6f;

        #region Form: Init
        public About()
        {
            InitializeComponent();
        }
        #endregion
        #region Form: Load
        private void About_Load(object sender, EventArgs e)
        {
            label_soft.Text = $"{AssemblyTitle} {AssemblyVersion}";
            PosY = anim_pos = Height * -1;
        }
        #endregion
        #region Form: Close Buttons
        private void close()
        {
            Invoke((MethodInvoker)delegate ()
            {
                this.Close();
                this.Dispose();
            });
        }

        private void button_close_Click(object sender, EventArgs e) => close();
        #endregion
        #region Form: Paint
        private void About_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.FromArgb(39, 111, 169)), 0f, 0f, Width - 1, Height - 1);
            for (int i = 0; i < 3; i++)
                e.Graphics.DrawLine(new Pen(Color.FromArgb(39, 111, 169)), 1f, Height - 2 - i, Width - (Width / waitTime * wait - 1f), Height - 2 - i);
        }
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

        #region Accessing Assembly info
        public string AssemblyTitle
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
                if (attributes.Length > 0)
                {
                    AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
                    if (titleAttribute.Title != "")
                        return titleAttribute.Title;
                }
                return System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
            }
        }

        public string AssemblyVersion => Assembly.GetExecutingAssembly().GetName().Version.ToString();

        public string AssemblyDescription
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
                if (attributes.Length == 0)
                    return "";
                return ((AssemblyDescriptionAttribute)attributes[0]).Description;
            }
        }

        public string AssemblyProduct
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
                if (attributes.Length == 0)
                    return "";
                return ((AssemblyProductAttribute)attributes[0]).Product;
            }
        }

        public string AssemblyCopyright
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
                if (attributes.Length == 0)
                    return "";
                return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
            }
        }

        public string AssemblyCompany
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
                if (attributes.Length == 0)
                    return "";
                return ((AssemblyCompanyAttribute)attributes[0]).Company;
            }
        }
        #endregion

        #region Animation related methods
        float anim_pos, wait;
        private void Anim(object sender, EventArgs e)
        {
            if (PosY < 0)
            {
                if (anim_pos > -1f)
                    anim_pos = 0f;
                else
                    anim_pos -= anim_pos / 10f;
                PosY = anim_pos;
            }
            Invoke((MethodInvoker)delegate () { Refresh(); });
            if (wait < waitTime)
                wait += 0.016f; //16ms
            else
                close();
        }

        private float PosY
        {
            get => Location.Y;
            set
            {
                if (InvokeRequired)
                    Invoke((MethodInvoker)delegate () { Location = new Point(Location.X, (int)value); });
                else
                    Location = new Point(Location.X, (int)value);
            }
        }
        #endregion

        private void linkLabel_antim_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => Process.Start("https://github.com/antimYT");
    }
}
