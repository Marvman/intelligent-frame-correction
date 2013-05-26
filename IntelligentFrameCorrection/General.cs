using System;
using System.Drawing;
using System.Windows.Forms;
using MediaPortal.Configuration;


namespace IntelligentFrameCorrection
{
    public partial class General : UserControl
    {
        private readonly Control[] scanAreas = new Control[4];
        private Control selectedScanArea;

        public General()
        {
            InitializeComponent();
            overscanCropPicture.Controls.Add(lineOverscanCropTop);
            overscanCropPicture.Controls.Add(lineOverscanCropBottom);
            overscanCropPicture.Controls.Add(lineOverscanCropLeft);
            overscanCropPicture.Controls.Add(lineOverscanCropRight);
            lineOverscanCropTop.Location = new Point(0, 0);
            lineOverscanCropBottom.Location = new Point(0, overscanCropPicture.Height);
            lineOverscanCropLeft.Location = new Point(0, 0);
            lineOverscanCropRight.Location = new Point(overscanCropPicture.Width, 0);
        }

        private void General_Load(object sender, EventArgs e)
        {
            //For transparency
            scanAreaPicture.Controls.Add(TopScanArea);
            scanAreaPicture.Controls.Add(BottomScanArea);
            scanAreaPicture.Controls.Add(LeftScanArea);
            scanAreaPicture.Controls.Add(RightScanArea);

            scanAreas[0] = TopScanArea;
            scanAreas[1] = BottomScanArea;
            scanAreas[2] = LeftScanArea;
            scanAreas[3] = RightScanArea;

            switch (btnOperator.Text)
            {
                case "or":
                    {
                        toolTip.SetToolTip(btnOperator, "If the picture width is greater than " + numUpDownHDWidth.Value + " or the picture height is greather than " + numUpDownHDHeight.Value + ", then HD content is present.");
                        break;
                    }
                case "and":
                    {
                        toolTip.SetToolTip(btnOperator, "If the picture width is greater than " + numUpDownHDWidth.Value + " and the picture height is greather than " + numUpDownHDHeight.Value + ", then HD content is present.");
                        break;
                    }
                case "multiply":
                    {
                        toolTip.SetToolTip(btnOperator, "If the number of pixel is greater than " + numUpDownHDWidth.Value * numUpDownHDHeight.Value + ", then HD content is present.");
                        break;
                    }
            }
        }

        private void listViewScanArea_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewScanArea.SelectedItems.Count > 0)

            {
                grpBoxBlackArea.Enabled = true;
                if (listViewScanArea.SelectedItems[0].Text.Equals("Top"))
                {
                    selectedScanArea = TopScanArea;
                }

                if (listViewScanArea.SelectedItems[0].Text.Equals("Bottom"))
                {
                    selectedScanArea = BottomScanArea;
                }

                if (listViewScanArea.SelectedItems[0].Text.Equals("Left"))
                {
                    selectedScanArea = LeftScanArea;
                }

                if (listViewScanArea.SelectedItems[0].Text.Equals("Right"))
                {
                    selectedScanArea = RightScanArea;
                }

                BlackAreaUpDownHeight.Value = int.Parse(listViewScanArea.SelectedItems[0].SubItems[1].Text);
                BlackAreaUpDownWidth.Value = int.Parse(listViewScanArea.SelectedItems[0].SubItems[2].Text);
                BlackAreaUpDownX.Value = int.Parse(listViewScanArea.SelectedItems[0].SubItems[3].Text);
                BlackAreaUpDownY.Value = int.Parse(listViewScanArea.SelectedItems[0].SubItems[4].Text);
            }
            else
            {
                grpBoxBlackArea.Enabled = false;
            }
        }

        private void BlackAreaUpDownHeight_ValueChanged(object sender, EventArgs e)
        {
            if (BlackAreaUpDownHeight.Value + BlackAreaUpDownY.Value <= 100)
            {
                selectedScanArea.Height =
                    (int) Math.Round((float) scanAreaPicture.Height/100*(int) BlackAreaUpDownHeight.Value, 1);
                listViewScanArea.SelectedItems[0].SubItems[1].Text = BlackAreaUpDownHeight.Value.ToString();
                sliderScanAreaHeight.Value = (int) BlackAreaUpDownHeight.Value;
            }
        }

        private void BlackAreaUpDownWidth_ValueChanged(object sender, EventArgs e)
        {
            if (BlackAreaUpDownWidth.Value + BlackAreaUpDownX.Value <= 100)
            {
                selectedScanArea.Width =
                    (int) Math.Round((float) scanAreaPicture.Width/100*(int) BlackAreaUpDownWidth.Value, 1);
            listViewScanArea.SelectedItems[0].SubItems[2].Text = BlackAreaUpDownWidth.Value.ToString();
            sliderScanAreaWidth.Value = (int) BlackAreaUpDownWidth.Value;
        }
    }

        private void BlackAreaUpDownX_ValueChanged(object sender, EventArgs e)
        {
            if (BlackAreaUpDownWidth.Value + BlackAreaUpDownX.Value <= 100)
            {
                selectedScanArea.Left =
                    (int) Math.Round((float) scanAreaPicture.Width/100*(int) BlackAreaUpDownX.Value, 1);
                listViewScanArea.SelectedItems[0].SubItems[3].Text = BlackAreaUpDownX.Value.ToString();
                sliderScanAreaX.Value = (int) BlackAreaUpDownX.Value;
            }
        }

        private void BlackAreaUpDownY_ValueChanged(object sender, EventArgs e)
        {
            if (BlackAreaUpDownHeight.Value + BlackAreaUpDownY.Value <= 100)
            {
                selectedScanArea.Top =
                    (int) Math.Round((float) scanAreaPicture.Height/100*(int) BlackAreaUpDownY.Value, 1);
                listViewScanArea.SelectedItems[0].SubItems[4].Text = BlackAreaUpDownY.Value.ToString();
                sliderScanAreaY.Value = (int) BlackAreaUpDownY.Value;
            }
        }

        private void sliderScanAreaHeight_Scroll(object sender, EventArgs e)
        {
            if (BlackAreaUpDownHeight.Value + BlackAreaUpDownY.Value <= 100 || sliderScanAreaHeight.Value + sliderScanAreaY.Value <= 100)
            {
                BlackAreaUpDownHeight.Value = sliderScanAreaHeight.Value;
            }
        }

        private void sliderScanAreaWidth_Scroll(object sender, EventArgs e)
        {
            if (BlackAreaUpDownWidth.Value + BlackAreaUpDownX.Value <= 100 || sliderScanAreaWidth.Value + sliderScanAreaX.Value <= 100)
            {
                BlackAreaUpDownWidth.Value = sliderScanAreaWidth.Value;
            }
        }

        private void sliderScanAreaX_Scroll(object sender, EventArgs e)
        {
            if (BlackAreaUpDownWidth.Value + BlackAreaUpDownX.Value <= 100 || sliderScanAreaWidth.Value + sliderScanAreaX.Value <= 100)
            {
                BlackAreaUpDownX.Value = sliderScanAreaX.Value;
            }
        }

        private void sliderScanAreaY_Scroll(object sender, EventArgs e)
        {
            if (BlackAreaUpDownHeight.Value + BlackAreaUpDownY.Value <= 100 || sliderScanAreaHeight.Value + sliderScanAreaY.Value <= 100)
            {
                BlackAreaUpDownY.Value = sliderScanAreaY.Value;
            }
        }

        private void numTopZoom_ValueChanged(object sender, EventArgs e)
        {
            sliderTopZoom.Value = (int) numTopZoom.Value;
            listViewAdvancedViewMode.SelectedItems[0].SubItems[2].Text = numTopZoom.Value.ToString();
        }

        private void numBottomZoom_ValueChanged(object sender, EventArgs e)
        {
            sliderBottomZoom.Value = (int) numBottomZoom.Value;
            listViewAdvancedViewMode.SelectedItems[0].SubItems[3].Text = numBottomZoom.Value.ToString();
        }

        private void numLeftZoom_ValueChanged(object sender, EventArgs e)
        {
            sliderLeftZoom.Value = (int) numLeftZoom.Value;
            listViewAdvancedViewMode.SelectedItems[0].SubItems[4].Text = numLeftZoom.Value.ToString();
        }

        private void numRightZoom_ValueChanged(object sender, EventArgs e)
        {
            sliderRightZoom.Value = (int) numRightZoom.Value;
            listViewAdvancedViewMode.SelectedItems[0].SubItems[5].Text = numRightZoom.Value.ToString();
        }

        private void sliderTopZoom_Scroll(object sender, EventArgs e)
        {
            numTopZoom.Value = sliderTopZoom.Value;
        }

        private void sliderBottomZoom_Scroll(object sender, EventArgs e)
        {
            numBottomZoom.Value = sliderBottomZoom.Value;
        }

        private void sliderLeftZoom_Scroll(object sender, EventArgs e)
        {
            numLeftZoom.Value = sliderLeftZoom.Value;
        }

        private void sliderRightZoom_Scroll(object sender, EventArgs e)
        {
            numRightZoom.Value = sliderRightZoom.Value;
        }

        private void listViewAdvancedViewMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewAdvancedViewMode.SelectedItems.Count > 0)
            {
                grpBoxAdjustViewMode.Enabled = true;
                cmbboxViewModes.SelectedItem = listViewAdvancedViewMode.SelectedItems[0].SubItems[1].Text;

                numTopZoom.Value = int.Parse(listViewAdvancedViewMode.SelectedItems[0].SubItems[2].Text);
                numBottomZoom.Value = int.Parse(listViewAdvancedViewMode.SelectedItems[0].SubItems[3].Text);
                numLeftZoom.Value = int.Parse(listViewAdvancedViewMode.SelectedItems[0].SubItems[4].Text);
                numRightZoom.Value = int.Parse(listViewAdvancedViewMode.SelectedItems[0].SubItems[5].Text);
            }
            else
            {
                grpBoxAdjustViewMode.Enabled = false;
            }
        }

        private void cmbboxViewModes_SelectedIndexChanged(object sender, EventArgs e)
        {
            listViewAdvancedViewMode.SelectedItems[0].SubItems[1].Text = cmbboxViewModes.SelectedItem.ToString();
        }

        private void numUpDownOverscanCropTop_ValueChanged(object sender, EventArgs e)
        {
            lineOverscanCropTop.Top = (int) numUpDownOverscanCropTop.Value;
            sliderOverscanCropTop.Value = (int) numUpDownOverscanCropTop.Value;
        }

        private void numUpDownOverscanCropBottom_ValueChanged(object sender, EventArgs e)
        {
            lineOverscanCropBottom.Location = new Point(0,
                                                        overscanCropPicture.Height -
                                                        (int) numUpDownOverscanCropBottom.Value);
            sliderOverscanCropBottom.Value = (int) numUpDownOverscanCropBottom.Value;
        }

        private void numUpDownOverscanCropLeft_ValueChanged(object sender, EventArgs e)
        {
            lineOverscanCropLeft.Left = (int) numUpDownOverscanCropLeft.Value;
            sliderOverscanCropLeft.Value = (int) numUpDownOverscanCropLeft.Value;
        }

        private void numUpDownOverscanCropRight_ValueChanged(object sender, EventArgs e)
        {
            lineOverscanCropRight.Location =
                new Point(overscanCropPicture.Width - (int) numUpDownOverscanCropRight.Value, 0);
            sliderOverscanCropRight.Value = (int) numUpDownOverscanCropRight.Value;
        }

        private void sliderOverscanCropTop_Scroll(object sender, EventArgs e)
        {
            numUpDownOverscanCropTop.Value = sliderOverscanCropTop.Value;
        }

        private void sliderOverscanCropBottom_Scroll(object sender, EventArgs e)
        {
            numUpDownOverscanCropBottom.Value = sliderOverscanCropBottom.Value;
        }

        private void sliderOverscanCropLeft_Scroll(object sender, EventArgs e)
        {
            numUpDownOverscanCropLeft.Value = sliderOverscanCropLeft.Value;
        }

        private void sliderOverscanCropRight_Scroll(object sender, EventArgs e)
        {
            numUpDownOverscanCropRight.Value = sliderOverscanCropRight.Value;
        }

        private void numUpDownScanInterval_ValueChanged(object sender, EventArgs e)
        {
            sliderScanInterval.Value = (int) numUpDownScanInterval.Value;
        }

        private void numUpDownDetectionCounter_ValueChanged(object sender, EventArgs e)
        {
            sliderDetectionCounter.Value = (int) numUpDownDetectionCounter.Value;
        }

        private void numUpDownMaxBrightnessThreashold_ValueChanged(object sender, EventArgs e)
        {
            sliderMaxBrightnessThreshold.Value = (int) numUpDownMaxBrightnessThreashold.Value;
        }

        private void numUpDownMinBrightnessThreashold_ValueChanged(object sender, EventArgs e)
        {
            sliderMinBrightnessThreshold.Value = (int) numUpDownMinBrightnessThreashold.Value;
        }

        private void numUpDownStabilizer_ValueChanged(object sender, EventArgs e)
        {
            sliderStabilizationFactor.Value = (int) numUpDownStabilizationFactor.Value;
        }

        private void numUpDownSingleBlackBarHeight_ValueChanged(object sender, EventArgs e)
        {
            sliderSingleBlackBarHeight.Value = (int) numUpDownSingleBlackBarHeight.Value;
        }

        private void numUpDownDoubleBlackBarHeight_ValueChanged(object sender, EventArgs e)
        {
            sliderDoubleBlackBarHeight.Value = (int) numUpDownDoubleBlackBarHeight.Value;
        }

        private void sliderScanInterval_Scroll(object sender, EventArgs e)
        {
            numUpDownScanInterval.Value = sliderScanInterval.Value;
        }

        private void sliderDetectionCounter_Scroll(object sender, EventArgs e)
        {
            numUpDownDetectionCounter.Value = sliderDetectionCounter.Value;
        }

        private void sliderMaxBrightnessThreshold_Scroll(object sender, EventArgs e)
        {
            numUpDownMaxBrightnessThreashold.Value = sliderMaxBrightnessThreshold.Value;
        }

        private void sliderMinBrightnessThreshold_Scroll(object sender, EventArgs e)
        {
            numUpDownMinBrightnessThreashold.Value = sliderMinBrightnessThreshold.Value;
        }

        private void sliderStabilizer_Scroll(object sender, EventArgs e)
        {
            numUpDownStabilizationFactor.Value = sliderStabilizationFactor.Value;
        }

        private void sliderSingleBlackBarHeight_Scroll(object sender, EventArgs e)
        {
            numUpDownSingleBlackBarHeight.Value = sliderSingleBlackBarHeight.Value;
        }

        private void sliderDoubleBlackBarHeight_Scroll(object sender, EventArgs e)
        {
            numUpDownDoubleBlackBarHeight.Value = sliderDoubleBlackBarHeight.Value;
        }

        private void btnLoadSreenshot_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog
            {
                Filter = @"Picture Files (*.BMP;*.png;*.JPG;*.Jpeg)|*.BMP;*.png;*.JPG;*.Jpeg|All Files (*.*)|*.*",
                RestoreDirectory = true
            };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                var img = new Bitmap(ofd.FileName);
                pictureBoxTestImage.Image = img;
                pictureBoxTestImage.ImageLocation = ofd.FileName;
                btnTestAndBenchmark.Enabled = true;
                pictureBoxTestImage.Refresh();

                #region reset checks

                ckbTopSingleBlackBar.Checked = false;
                ckbBottomSingleBlackBar.Checked = false;
                ckbLeftSideBlackBar.Checked = false;
                ckbRightSideBlackBar.Checked = false;
                ckbTopDoubleBlackBar.Checked = false;
                ckbBottomDoubleBlackBar.Checked = false;

                lblSpeed.Text = @"Speed in ms: ";

                #endregion
            }
        }

        private void btnTestAndBenchmark_Click(object sender, EventArgs e)
        {
            string path = Config.GetFile(Config.Dir.Config, "IntelligentFrameCorrection.temp");
            IntelligentFrameCorrectionSetup.INSTANCE.saveConfig(path);
            Preferences.getInstance().loadSettings(path);

            System.IO.File.Delete(path);

            var frameAnalyzer = new MockFrameAnalyzer();
            var bounds = new Rectangle();
            var img = (Bitmap)Image.FromFile(pictureBoxTestImage.ImageLocation);

            frameAnalyzer.setVideoSize(new Size(img.Width, img.Height));
            DateTime startTime = DateTime.Now;
            
            if(!frameAnalyzer.FindBounds(true, true, true, true, ref bounds, ref img))
            {
                MessageBox.Show(@"Frame was too dark! Check your scan areas or take another screenshot!", @"Information",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            

            #region check for black bars

            ckbTopSingleBlackBar.Checked = FrameAnalyzer.isSingleBlackBar(bounds.Y, img.Height);
            ckbBottomSingleBlackBar.Checked = FrameAnalyzer.isSingleBlackBar(bounds.Height, img.Height);
            ckbLeftSideBlackBar.Checked = FrameAnalyzer.isSideBlackBar(bounds.X,img.Width);
            ckbRightSideBlackBar.Checked = FrameAnalyzer.isSideBlackBar(bounds.Width, img.Width);
            ckbTopDoubleBlackBar.Checked = FrameAnalyzer.isDoubleBlackBar(bounds.Y, img.Height);
            ckbBottomDoubleBlackBar.Checked = FrameAnalyzer.isDoubleBlackBar(bounds.Height, img.Height);

            #endregion

            var stopTime = DateTime.Now - startTime;

            lblSpeed.Text = @"Speed in ms: " + stopTime.TotalMilliseconds;

            pictureBoxTestImage.Image = (Image)img.Clone();
            pictureBoxTestImage.Refresh();
            img.Dispose();
        }

        private void btnOperator_Click(object sender, EventArgs e)
        {
            switch(btnOperator.Text)
            {
                case "or":
                    {
                        btnOperator.Text = "and";
                        toolTip.SetToolTip(btnOperator, "If the picture width is greater than " + numUpDownHDWidth.Value + " and the picture height is greather than " + numUpDownHDHeight.Value + ", then HD content is present.");
                        break;
                    }
                case "and":
                    {
                        btnOperator.Text = "multiply";
                        toolTip.SetToolTip(btnOperator, "If the number of pixel is greater than " + numUpDownHDWidth.Value * numUpDownHDHeight.Value + ", then HD content is present.");
                        break;
                    }
                case "multiply":
                    {
                        btnOperator.Text = "or";
                        toolTip.SetToolTip(btnOperator, "If the picture width is greater than " + numUpDownHDWidth.Value + " or the picture height is greather than " + numUpDownHDHeight.Value + ", then HD content is present.");
                        break;
                    }
            }
        }

        private void sliderStabilizationTolerance_Scroll(object sender, EventArgs e)
        {
            numUpDownStabilizationTolerance.Value = sliderStabilizationTolerance.Value;
        }

        private void numUpDownStabilizationTolerance_ValueChanged(object sender, EventArgs e)
        {
            sliderStabilizationTolerance.Value = (int)numUpDownStabilizationTolerance.Value;
        }

        private void sliderEdgeDetectionTolerance_Scroll(object sender, EventArgs e)
        {
            numUpDownEdgeDetectionTolerance.Value = sliderEdgeDetectionTolerance.Value;
        }

        private void numericUpDownEdgeDetectionTolerance_ValueChanged(object sender, EventArgs e)
        {
            sliderEdgeDetectionTolerance.Value = (int)numUpDownEdgeDetectionTolerance.Value;
        }

        private void sliderFrameCaptureSize_Scroll(object sender, EventArgs e)
        {
            numUpDownFrameCaptureSize.Value = sliderFrameCaptureSize.Value;
        }

        private void numUpDownFrameCaptureSize_ValueChanged(object sender, EventArgs e)
        {
            sliderFrameCaptureSize.Value = (int)numUpDownFrameCaptureSize.Value;
        }
    }
}