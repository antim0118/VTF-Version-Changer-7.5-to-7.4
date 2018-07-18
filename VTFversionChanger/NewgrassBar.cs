using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VTFversionChanger
{
    public class NewgrassBar : ProgressBar
    {
        public NewgrassBar()
        {
            this.SetStyle(ControlStyles.UserPaint, true);
        }

        float _ = 0;
        float tempprogress = 0f;
        protected override void OnPaint(PaintEventArgs e)
        {
            Rectangle rec = e.ClipRectangle;

            rec.Width = (int)(rec.Width * ((double)Value / Maximum)) - 4;
            if (ProgressBarRenderer.IsSupported)
                ProgressBarRenderer.DrawHorizontalBar(e.Graphics, e.ClipRectangle);
            rec.Height = rec.Height - 4;
            var brush = new SolidBrush(Color.FromArgb(39, 111, 169));
            e.Graphics.FillRectangle(brush, 2, 2, tempprogress, rec.Height);

            
            for(int a = 0; a < 3; a++)
            {
                for(int i = 0; i < 5; i++)
                {
                    float _1 = 2 + (_ + 10) % (Width + 60) + i + a * 6 - 30;
                    float _2 = 2 + _ % (Width+ 60) + i + a * 6 - 30;
                    if (_1 > _2)
                        e.Graphics.DrawLine(new Pen(Color.FromArgb((int)(100f / 4 * i), 230, 230, 230)), _1, 2, _2, 2 + rec.Height);
                }
            }

            _++;
            if (rec.Width >= tempprogress)
                tempprogress += (rec.Width - tempprogress) / 20f;
            else
                tempprogress = rec.Width; 
        }
    }
}
