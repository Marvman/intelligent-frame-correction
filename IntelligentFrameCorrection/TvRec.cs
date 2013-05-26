using System;
using System.Drawing;
using System.Windows.Forms;

namespace IntelligentFrameCorrection
{
    public partial class TvRec : UserControl
    {
        public TvRec()
        {
            InitializeComponent();
            tvCropPicture.Controls.Add(lineTVCropTop);
            tvCropPicture.Controls.Add(lineTVCropBottom);
            tvCropPicture.Controls.Add(lineTVCropLeft);
            tvCropPicture.Controls.Add(lineTVCropRight);
            lineTVCropTop.Location = new Point(0,0);
            lineTVCropBottom.Location = new Point(0, tvCropPicture.Height);
            lineTVCropLeft.Location = new Point(0, 0);
            lineTVCropRight.Location = new Point(tvCropPicture.Width, 0);
        }

        private void numUpDownTVCropTop_ValueChanged(object sender, EventArgs e)
        {
            lineTVCropTop.Top = (int)numUpDownTVCropTop.Value;
            sliderTVCropTop.Value = (int)numUpDownTVCropTop.Value;
        }

        private void numUpDownTVCropBottom_ValueChanged(object sender, EventArgs e)
        {
            lineTVCropBottom.Location = new Point(0, tvCropPicture.Height - (int)numUpDownTVCropBottom.Value);
            sliderTVCropBottom.Value = (int)numUpDownTVCropBottom.Value;
        }

        private void numUpDownTVCropLeft_ValueChanged(object sender, EventArgs e)
        {
            lineTVCropLeft.Left = (int)numUpDownTVCropLeft.Value;
            sliderTVCropLeft.Value = (int)numUpDownTVCropLeft.Value;
        }

        private void numUpDownTVCropRight_ValueChanged(object sender, EventArgs e)
        {
            lineTVCropRight.Location = new Point(tvCropPicture.Width - (int)numUpDownTVCropRight.Value, 0);
            sliderTVCropRight.Value = (int)numUpDownTVCropRight.Value;
        }

        private void sliderTVCropTop_Scroll(object sender, EventArgs e)
        {
            numUpDownTVCropTop.Value = sliderTVCropTop.Value;
        }

        private void sliderTVCropBottom_Scroll(object sender, EventArgs e)
        {
            numUpDownTVCropBottom.Value = sliderTVCropBottom.Value;
        }

        private void sliderTVCropLeft_Scroll(object sender, EventArgs e)
        {
            numUpDownTVCropLeft.Value = sliderTVCropLeft.Value;
        }

        private void sliderTVCropRight_Scroll(object sender, EventArgs e)
        {
            numUpDownTVCropRight.Value = sliderTVCropRight.Value;
        }
    }
}
