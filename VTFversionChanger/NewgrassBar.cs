using System;
using System.Drawing;
using System.Windows.Forms;

namespace VTFversionChanger
{
    public class NewgrassBar : ProgressBar
    {
        float tempprogress = 0f;
        Rectangle rec;
        Brush brush;

        public NewgrassBar()
        {
            brush = new SolidBrush(Color.FromArgb(39, 111, 169));
            this.SetStyle(ControlStyles.UserPaint, true);
            Timer timer = new Timer
            {
                Interval = 33,
                Enabled = true
            };
            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (Math.Round(tempprogress, 0) != rec.Width)
                this.Refresh();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Rectangle _rec = e.ClipRectangle;

            _rec.Width = (int)(_rec.Width * ((double)Value / Maximum)) - 4;
            if (ProgressBarRenderer.IsSupported)
                ProgressBarRenderer.DrawHorizontalBar(e.Graphics, e.ClipRectangle);
            _rec.Height = _rec.Height - 4;

            e.Graphics.FillRectangle(brush, 2, 2, tempprogress, _rec.Height);

            if (_rec.Width >= tempprogress)
                tempprogress += (_rec.Width - tempprogress) / 10f;
            else
                tempprogress = _rec.Width;
            rec = _rec;
        }
    }
}
