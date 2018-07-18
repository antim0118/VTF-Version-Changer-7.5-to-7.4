using System;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;

namespace VTFversionChanger
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        #region Методы доступа к атрибутам сборки

        public string AssemblyTitle
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
                if (attributes.Length > 0)
                {
                    AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
                    if (titleAttribute.Title != "")
                    {
                        return titleAttribute.Title;
                    }
                }
                return System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
            }
        }

        public string AssemblyVersion
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }

        public string AssemblyDescription
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyDescriptionAttribute)attributes[0]).Description;
            }
        }

        public string AssemblyProduct
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyProductAttribute)attributes[0]).Product;
            }
        }

        public string AssemblyCopyright
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
            }
        }

        public string AssemblyCompany
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCompanyAttribute)attributes[0]).Company;
            }
        }
        #endregion


        private Thread th, th2, th3;
        private void About_Load(object sender, EventArgs e)
        {
            label_soft.Text = $"{AssemblyTitle} {AssemblyVersion}";

            th = new Thread(Anim);
            th2 = new Thread(Timer);
            th3 = new Thread(refresh);
            th.Start();
            th2.Start();
            th3.Start();
        }

        #region Анимация при запуске
        private void Anim()
        {
            PosY = Height * -1;
            float pos = Height * -1;
            while (PosY < 0)
            {
                if (pos > -1f)
                    pos = 0f;
                else
                    pos -= pos / 15f;
                PosY = pos;
                Application.DoEvents();
                Thread.Sleep(10);
            }
        }
        private float PosY
        {
            get
            {
                return Location.Y;
            }
            set
            {
                if (InvokeRequired)
                    Invoke(new Action<string>(
                        (s) =>
                    Location = new Point(Location.X, (int)value)
                    ), "");
                else
                    Location = new Point(Location.X, (int)value);
            }
        }
        #endregion
        #region выход по истечении времени
        private int wait = 0;
        private void Timer()
        {
            while (wait < 40 * 10)
            {
                Thread.Sleep(25);
                wait++;
            }
            close();
        }
        #endregion

        private void refresh()
        {
            while (true)
            {
                Invoke((MethodInvoker)delegate ()
                {
                    Refresh();
                });
            }
        }

        private void linkLabel_antim_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/antimYT");
        }

        private void close()
        {
            Invoke((MethodInvoker)delegate ()
            {
                if (th.IsAlive)
                    th.Suspend();
                if (th2.IsAlive)
                    th2.Suspend();
                if (th3.IsAlive)
                    th3.Suspend();
                this.Close();
                this.Dispose();
            });
            
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            close();
        }


        private void About_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.FromArgb(39, 111, 169)), 0f, 0f, Width - 1, Height - 1);
            
            for(int i = 0; i < 3; i++)
            {
                e.Graphics.DrawLine(new Pen(Color.FromArgb(39, 111, 169)), 1f, Height - 2 - i, Width - (Width / (40f * 10f) * wait - 1f), Height - 2 - i);
            }

            //Refresh();
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x84)
            {
                m.Result = (IntPtr)2;  // move
                return;
            }
            base.WndProc(ref m);
        }
    }
}
