using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Controls
{
    public class ColoredPanel : Panel
    {
        protected override void OnPaint(PaintEventArgs pe)
        {
            var pen = new Pen(BorderColor, BorderColorWidth);
            pe.Graphics.DrawRectangle(pen,
                                      0,
                                      0,
                                      Size.Width - 1,
                                      Size.Height - 1);
            
            // Calling the base class OnPaint
            base.OnPaint(pe);

        }

        protected override void OnResize(EventArgs e)
        {
            base.Refresh();
            base.OnResize(e);
        }

        [Browsable(true), Category("")]
        public Color BorderColor { get; set; }

        [Browsable(true), Category("")]
        public float BorderColorWidth { get; set; }
    }
}