using System;
using System.Drawing;
using System.Windows.Forms;

namespace IntelligentFrameCorrection
{
    public partial class Video : UserControl
    {
        public Video()
        {
            InitializeComponent();
            videoCropPicture.Controls.Add(lineVideoCropTop);
            videoCropPicture.Controls.Add(lineVideoCropBottom);
            videoCropPicture.Controls.Add(lineVideoCropLeft);
            videoCropPicture.Controls.Add(lineVideoCropRight);
            lineVideoCropTop.Location = new Point(0, 0);
            lineVideoCropBottom.Location = new Point(0, videoCropPicture.Height);
            lineVideoCropLeft.Location = new Point(0, 0);
            lineVideoCropRight.Location = new Point(videoCropPicture.Width, 0);
        }

        private void numUpDownVideoCropTop_ValueChanged(object sender, EventArgs e)
        {
            lineVideoCropTop.Top = (int)numUpDownVideoCropTop.Value;
            sliderVideoCropTop.Value = (int)numUpDownVideoCropTop.Value;
        }

        private void numUpDownVideoCropBottom_ValueChanged(object sender, EventArgs e)
        {
            lineVideoCropBottom.Location = new Point(0, videoCropPicture.Height - (int)numUpDownVideoCropBottom.Value);
            sliderVideoCropBottom.Value = (int)numUpDownVideoCropBottom.Value;
        }

        private void numUpDownVideoCropLeft_ValueChanged(object sender, EventArgs e)
        {
            lineVideoCropLeft.Left = (int)numUpDownVideoCropLeft.Value;
            sliderVideoCropLeft.Value = (int)numUpDownVideoCropLeft.Value;
        }

        private void numUpDownVideoCropRight_ValueChanged(object sender, EventArgs e)
        {
            lineVideoCropRight.Location = new Point(videoCropPicture.Width - (int)numUpDownVideoCropRight.Value, 0);
            sliderVideoCropRight.Value = (int)numUpDownVideoCropRight.Value;
        }

        private void sliderVideoCropTop_Scroll(object sender, EventArgs e)
        {
            numUpDownVideoCropTop.Value = sliderVideoCropTop.Value;
        }

        private void sliderVideoCropBottom_Scroll(object sender, EventArgs e)
        {
            numUpDownVideoCropBottom.Value = sliderVideoCropBottom.Value;
        }

        private void sliderVideoCropLeft_Scroll(object sender, EventArgs e)
        {
            numUpDownVideoCropLeft.Value = sliderVideoCropLeft.Value;
        }

        private void sliderVideoCropRight_Scroll(object sender, EventArgs e)
        {
            numUpDownVideoCropRight.Value = sliderVideoCropRight.Value;
        }
    }
}
