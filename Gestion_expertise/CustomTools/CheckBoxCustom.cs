using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace WinFormsApp1
{
    public class CheckBoxCustom : CheckBox
    {
        private Color onBackColor = Color.MediumSlateBlue;
        private Color onToggleColor = Color.WhiteSmoke;
        private Color offBackColor = Color.Gray;
        private Color offToggleColor = Color.Gainsboro;
        [Category ("Style")]
        public Color OnBackColor { get => onBackColor; set { onBackColor = value; this.Invalidate(); } }
        [Category("Style")]
        public Color OnToggleColor { get => onToggleColor; set { onToggleColor = value; this.Invalidate(); } }
        [Category("Style")]
        public Color OffBackColor { get => offBackColor; set { offBackColor = value; this.Invalidate(); } }
        [Category("Style")]
        public Color OffToggleColor { get => offToggleColor; set { offToggleColor = value; this.Invalidate(); } }
       
        public override string Text { get => base.Text; set { } }

        public CheckBoxCustom()
        {
            this.MinimumSize = new Size(45, 42);
        }

        private GraphicsPath GetFigurePath()
        {
            int arcSize = this.Height - 1;
            Rectangle leftarc = new Rectangle(0, 0, arcSize, arcSize);
            Rectangle righttarc = new Rectangle(this.Width - arcSize - 2, 0, arcSize, arcSize);

            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(leftarc, 90, 180);
            path.AddArc(righttarc, 270, 180);
            path.CloseFigure();

            return path;
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            int toggleSize = this.Height - 5;
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            pevent.Graphics.Clear(this.Parent.BackColor);

            if (this.Checked)
            {
                pevent.Graphics.FillPath(new SolidBrush(onBackColor), GetFigurePath());

                pevent.Graphics.FillEllipse(new SolidBrush(onToggleColor),
                    new Rectangle(this.Width-this.Height+1,2,toggleSize, toggleSize));
            }
            else
            {
                pevent.Graphics.FillPath(new SolidBrush(offBackColor), GetFigurePath());

                pevent.Graphics.FillEllipse(new SolidBrush(offToggleColor),
                     new Rectangle(2, 2, toggleSize, toggleSize));
            }
        }

    }
}
