using System;
using System.Windows.Forms;
using MediaPortal.Configuration;
using MediaPortal.GUI.Library;
using MediaPortal.Profile;

namespace IntelligentFrameCorrection
{
    public partial class IntelligentFrameCorrectionSetup : Form
    {
        private Project projectSection;
        private General generalSection;
        private TvRec tvrecSection;
        private Video videoSection;
        public static IntelligentFrameCorrectionSetup INSTANCE;

        public IntelligentFrameCorrectionSetup()
        {
            InitializeComponent();
            projectSection = new Project();
            generalSection = new General();
            tvrecSection = new TvRec();
            videoSection = new Video();
            INSTANCE = this;
        }


        private void IntelligentFrameCorrectionSetup_Load(object sender, EventArgs e)
        {
            var success = loadConfig(Config.GetFile(Config.Dir.Config, "IntelligentFrameCorrection.xml"));

            if (!success)
            {
                MessageBox.Show("Can't load configuration, check your IntelligentFrameCorrection.xml!", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }

        private bool loadConfig(string path)
        {
            var result = false;

            using (var reader = new Settings(path, false))
            {
                try
                {
                    generalSection.rdb4to3.Checked = reader.GetValueAsBool("Config", "4:3", false);
                    generalSection.rdb16to9.Checked = reader.GetValueAsBool("Config", "16:9", true);
                    generalSection.rdb21to9.Checked = reader.GetValueAsBool("Config", "21:9", false);

                    generalSection.numUpDownMaxBrightnessThreashold.Value = reader.GetValueAsInt("Config",
                                                                                                 "maxBrightnessTreshold",
                                                                                                 40);
                    generalSection.numUpDownMinBrightnessThreashold.Value = reader.GetValueAsInt("Config",
                                                                                                 "minBrightnessTreshold",
                                                                                                 23);

                    generalSection.numUpDownScanInterval.Value = reader.GetValueAsInt("Config", "scaninterval", 6000);
                    generalSection.numUpDownDetectionCounter.Value = reader.GetValueAsInt("Config", "stop counter", 3);

                    generalSection.ckbAutoStart.Checked = reader.GetValueAsBool("Config", "auto start", true);

                    generalSection.ckbBlackBarScanner.Checked = reader.GetValueAsBool("Config",
                                                                                      "isBlackBarScannerEnabled",
                                                                                      true);

                    generalSection.ckbHDSupport.Checked = reader.GetValueAsBool("Config",
                                                                                      "HD support",
                                                                                      true);

                    generalSection.numUpDownHDHeight.Value = reader.GetValueAsInt("Config", "HD height", 600);

                    generalSection.numUpDownHDWidth.Value = reader.GetValueAsInt("Config", "HD width", 1200);

                    generalSection.btnOperator.Text = reader.GetValueAsString("Config", "HD operator", "or");


                    generalSection.ckbVideoSupport.Checked = reader.GetValueAsBool("Config",
                                                                  "video support",
                                                                  true);

                    generalSection.numUpDownStabilizationFactor.Value = reader.GetValueAsInt("Config", "stabilization factor", 10);

                    generalSection.numUpDownStabilizationTolerance.Value = reader.GetValueAsInt("Config", "stabilization tolerance", 7);

                    generalSection.numUpDownEdgeDetectionTolerance.Value = reader.GetValueAsInt("Config", "edge detection tolerance", 3);

                    generalSection.numUpDownFrameCaptureSize.Value = reader.GetValueAsInt("Config", "frame capture size", 50);

                    generalSection.ckbVerboseLogging.Checked = reader.GetValueAsBool("Config", "verboselogging", false);
                    generalSection.ckbCorrectAspectRatio.Checked = reader.GetValueAsBool("Config", "correct AR", true);

                    generalSection.ckbUseZoomFactorOnly.Checked = reader.GetValueAsBool("Config", "use only zoom factor", false);

                    generalSection.numUpDownSingleBlackBarHeight.Value =
                        (decimal)reader.GetValueAsInt("Config", "single black bar height", 70)/10;
                    generalSection.numUpDownDoubleBlackBarHeight.Value =
                        (decimal)reader.GetValueAsInt("Config", "double black bar height", 180)/10;


                    videoSection.numUpDownVideoCropTop.Value = reader.GetValueAsInt("Video Crop", "top", 0);
                    videoSection.numUpDownVideoCropBottom.Value = reader.GetValueAsInt("Video Crop", "bottom", 0);
                    videoSection.numUpDownVideoCropLeft.Value = reader.GetValueAsInt("Video Crop", "left", 0);
                    videoSection.numUpDownVideoCropRight.Value = reader.GetValueAsInt("Video Crop", "right", 0);


                    generalSection.numUpDownOverscanCropTop.Value = reader.GetValueAsInt("Overscan Crop", "top", 0);
                    generalSection.numUpDownOverscanCropBottom.Value = reader.GetValueAsInt("Overscan Crop", "bottom", 0);
                    generalSection.numUpDownOverscanCropLeft.Value = reader.GetValueAsInt("Overscan Crop", "left", 0);
                    generalSection.numUpDownOverscanCropRight.Value = reader.GetValueAsInt("Overscan Crop", "right", 0);


                    using (var xmlreader = new Settings(Config.GetFile(Config.Dir.Config, "MediaPortal.xml")))
                    {
                        tvrecSection.numUpDownTVCropTop.Value = xmlreader.GetValueAsInt("tv", "croptop", 0);
                        tvrecSection.numUpDownTVCropBottom.Value = xmlreader.GetValueAsInt("tv", "cropbottom", 0);
                        tvrecSection.numUpDownTVCropLeft.Value = xmlreader.GetValueAsInt("tv", "cropleft", 0);
                        tvrecSection.numUpDownTVCropRight.Value = xmlreader.GetValueAsInt("tv", "cropright", 0);
                    }

                    generalSection.listViewScanArea.Items[0].SubItems[1].Text = reader.GetValueAsString(
                        "Top Scan Area", "height", "22");
                    generalSection.listViewScanArea.Items[0].SubItems[2].Text = reader.GetValueAsString(
                        "Top Scan Area", "width", "30");
                    generalSection.listViewScanArea.Items[0].SubItems[3].Text = reader.GetValueAsString(
                        "Top Scan Area", "x", "31");
                    generalSection.listViewScanArea.Items[0].SubItems[4].Text = reader.GetValueAsString(
                        "Top Scan Area", "y", "0");

                    setScanAreaSize(generalSection.TopScanArea, reader.GetValueAsInt("Top Scan Area", "height", 22),
                                    reader.GetValueAsInt("Top Scan Area", "width", 30),
                                    reader.GetValueAsInt("Top Scan Area", "x", 31),
                                    reader.GetValueAsInt("Top Scan Area", "y", 0));

                    generalSection.listViewScanArea.Items[1].SubItems[1].Text =
                        reader.GetValueAsString("Bottom Scan Area", "height",
                                                "22");
                    generalSection.listViewScanArea.Items[1].SubItems[2].Text =
                        reader.GetValueAsString("Bottom Scan Area", "width",
                                                "30");
                    generalSection.listViewScanArea.Items[1].SubItems[3].Text =
                        reader.GetValueAsString("Bottom Scan Area", "x", "31");
                    generalSection.listViewScanArea.Items[1].SubItems[4].Text =
                        reader.GetValueAsString("Bottom Scan Area", "y", "78");

                    setScanAreaSize(generalSection.BottomScanArea,
                                    reader.GetValueAsInt("Bottom Scan Area", "height", 22),
                                    reader.GetValueAsInt("Bottom Scan Area", "width", 30),
                                    reader.GetValueAsInt("Bottom Scan Area", "x", 31),
                                    reader.GetValueAsInt("Bottom Scan Area", "y", 78));

                    generalSection.listViewScanArea.Items[2].SubItems[1].Text = reader.GetValueAsString(
                        "Left Scan Area", "height", "30");
                    generalSection.listViewScanArea.Items[2].SubItems[2].Text = reader.GetValueAsString(
                        "Left Scan Area", "width", "13");
                    generalSection.listViewScanArea.Items[2].SubItems[3].Text = reader.GetValueAsString(
                        "Left Scan Area", "x", "0");
                    generalSection.listViewScanArea.Items[2].SubItems[4].Text = reader.GetValueAsString(
                        "Left Scan Area", "y", "30");

                    setScanAreaSize(generalSection.LeftScanArea,
                                    reader.GetValueAsInt("Left Scan Area", "height", 30),
                                    reader.GetValueAsInt("Left Scan Area", "width", 13),
                                    reader.GetValueAsInt("Left Scan Area", "x", 0),
                                    reader.GetValueAsInt("Left Scan Area", "y", 30));

                    generalSection.listViewScanArea.Items[3].SubItems[1].Text =
                        reader.GetValueAsString("Right Scan Area", "height",
                                                "30");
                    generalSection.listViewScanArea.Items[3].SubItems[2].Text =
                        reader.GetValueAsString("Right Scan Area", "width", "13");
                    generalSection.listViewScanArea.Items[3].SubItems[3].Text =
                        reader.GetValueAsString("Right Scan Area", "x", "87");
                    generalSection.listViewScanArea.Items[3].SubItems[4].Text =
                        reader.GetValueAsString("Right Scan Area", "y", "30");


                    setScanAreaSize(generalSection.RightScanArea,
                                    reader.GetValueAsInt("Right Scan Area", "height", 30),
                                    reader.GetValueAsInt("Right Scan Area", "width", 13),
                                    reader.GetValueAsInt("Right Scan Area", "x", 87),
                                    reader.GetValueAsInt("Right Scan Area", "y", 30));

                    CustomViewMode tempViewMode =
                        Utils.stringToCustomViewMode(reader.GetValueAsString("View Mode", "4:3",
                                                                             "NonLinearStretch,0,0,0,0"));

                    generalSection.listViewAdvancedViewMode.Items[0].SubItems[1].Text = tempViewMode.ViewMode.ToString();
                    generalSection.listViewAdvancedViewMode.Items[0].SubItems[2].Text =
                        tempViewMode.Zoom.Top.ToString();
                    generalSection.listViewAdvancedViewMode.Items[0].SubItems[3].Text =
                        tempViewMode.Zoom.Bottom.ToString();
                    generalSection.listViewAdvancedViewMode.Items[0].SubItems[4].Text =
                        tempViewMode.Zoom.Left.ToString();
                    generalSection.listViewAdvancedViewMode.Items[0].SubItems[5].Text =
                        tempViewMode.Zoom.Right.ToString();

                    tempViewMode =
                        Utils.stringToCustomViewMode(reader.GetValueAsString("View Mode", "4:3 Letterbox",
                                                                             "Stretch,0,0,0,0"));
                    generalSection.listViewAdvancedViewMode.Items[1].SubItems[1].Text = tempViewMode.ViewMode.ToString();
                    generalSection.listViewAdvancedViewMode.Items[1].SubItems[2].Text =
                        tempViewMode.Zoom.Top.ToString();
                    generalSection.listViewAdvancedViewMode.Items[1].SubItems[3].Text =
                        tempViewMode.Zoom.Bottom.ToString();
                    generalSection.listViewAdvancedViewMode.Items[1].SubItems[4].Text =
                        tempViewMode.Zoom.Left.ToString();
                    generalSection.listViewAdvancedViewMode.Items[1].SubItems[5].Text =
                        tempViewMode.Zoom.Right.ToString();

                    tempViewMode =
                        Utils.stringToCustomViewMode(reader.GetValueAsString("View Mode", "16:9", "Stretch,0,0,0,0"));
                    generalSection.listViewAdvancedViewMode.Items[2].SubItems[1].Text = tempViewMode.ViewMode.ToString();
                    generalSection.listViewAdvancedViewMode.Items[2].SubItems[2].Text =
                        tempViewMode.Zoom.Top.ToString();
                    generalSection.listViewAdvancedViewMode.Items[2].SubItems[3].Text =
                        tempViewMode.Zoom.Bottom.ToString();
                    generalSection.listViewAdvancedViewMode.Items[2].SubItems[4].Text =
                        tempViewMode.Zoom.Left.ToString();
                    generalSection.listViewAdvancedViewMode.Items[2].SubItems[5].Text =
                        tempViewMode.Zoom.Right.ToString();

                    tempViewMode =
                        Utils.stringToCustomViewMode(reader.GetValueAsString("View Mode", "16:9 Letterbox",
                                                                             "Stretch,0,0,0,0"));
                    generalSection.listViewAdvancedViewMode.Items[3].SubItems[1].Text = tempViewMode.ViewMode.ToString();
                    generalSection.listViewAdvancedViewMode.Items[3].SubItems[2].Text =
                        tempViewMode.Zoom.Top.ToString();
                    generalSection.listViewAdvancedViewMode.Items[3].SubItems[3].Text =
                        tempViewMode.Zoom.Bottom.ToString();
                    generalSection.listViewAdvancedViewMode.Items[3].SubItems[4].Text =
                        tempViewMode.Zoom.Left.ToString();
                    generalSection.listViewAdvancedViewMode.Items[3].SubItems[5].Text =
                        tempViewMode.Zoom.Right.ToString();

                    tempViewMode =
                        Utils.stringToCustomViewMode(reader.GetValueAsString("View Mode", "16:9 with Sidebars",
                                                                             "NonLinearStretch,0,0,0,0"));
                    generalSection.listViewAdvancedViewMode.Items[4].SubItems[1].Text = tempViewMode.ViewMode.ToString();
                    generalSection.listViewAdvancedViewMode.Items[4].SubItems[2].Text =
                        tempViewMode.Zoom.Top.ToString();
                    generalSection.listViewAdvancedViewMode.Items[4].SubItems[3].Text =
                        tempViewMode.Zoom.Bottom.ToString();
                    generalSection.listViewAdvancedViewMode.Items[4].SubItems[4].Text =
                        tempViewMode.Zoom.Left.ToString();
                    generalSection.listViewAdvancedViewMode.Items[4].SubItems[5].Text =
                        tempViewMode.Zoom.Right.ToString();

                    tempViewMode =
                        Utils.stringToCustomViewMode(reader.GetValueAsString("View Mode", "21:9", "Normal,0,0,0,0"));
                    generalSection.listViewAdvancedViewMode.Items[5].SubItems[1].Text = tempViewMode.ViewMode.ToString();
                    generalSection.listViewAdvancedViewMode.Items[5].SubItems[2].Text =
                        tempViewMode.Zoom.Top.ToString();
                    generalSection.listViewAdvancedViewMode.Items[5].SubItems[3].Text =
                        tempViewMode.Zoom.Bottom.ToString();
                    generalSection.listViewAdvancedViewMode.Items[5].SubItems[4].Text =
                        tempViewMode.Zoom.Left.ToString();
                    generalSection.listViewAdvancedViewMode.Items[5].SubItems[5].Text =
                        tempViewMode.Zoom.Right.ToString();

                    tempViewMode =
                        Utils.stringToCustomViewMode(reader.GetValueAsString("View Mode", "Default", "Stretch,0,0,0,0"));
                    generalSection.listViewAdvancedViewMode.Items[6].SubItems[1].Text = tempViewMode.ViewMode.ToString();
                    generalSection.listViewAdvancedViewMode.Items[6].SubItems[2].Text =
                        tempViewMode.Zoom.Top.ToString();
                    generalSection.listViewAdvancedViewMode.Items[6].SubItems[3].Text =
                        tempViewMode.Zoom.Bottom.ToString();
                    generalSection.listViewAdvancedViewMode.Items[6].SubItems[4].Text =
                        tempViewMode.Zoom.Left.ToString();
                    generalSection.listViewAdvancedViewMode.Items[6].SubItems[5].Text =
                        tempViewMode.Zoom.Right.ToString();

                    generalSection.cmbboxViewModes.Items.AddRange(Enum.GetNames(typeof (Geometry.Type)));

                    Log.Debug("I.F.C.: Config loaded!");
                    result = true;
                }
                catch (Exception e)
                {
                    Log.Error("I.F.C.: Config load failed!");
                    Log.Error(e);
                    result = false;
                }
            }
            return result;
        }


        private void sectionView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            holderPanel.Controls.Clear();

            switch (e.Node.Index)
            {
                case 0:
                    {
                        headerLabel.Caption = "Project";
                        holderPanel.Controls.Add(projectSection);
                        break;
                    }
                case 1:
                    {
                        headerLabel.Caption = "General";
                        holderPanel.Controls.Add(generalSection);
                        break;
                    }
                case 2:
                    {
                        headerLabel.Caption = "TV/Recordings";
                        holderPanel.Controls.Add(tvrecSection);
                        break;
                    }
                case 3:
                    {
                        headerLabel.Caption = "Video";
                        holderPanel.Controls.Add(videoSection);
                        break;
                    }
            }
        }

        /// <summary>
        /// Initial set of the scan area GUI controls
        /// </summary>
        /// <param name="scanarea"></param>
        /// <param name="height"></param>
        /// <param name="width"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        private void setScanAreaSize(Control scanarea, int height, int width, int x, int y)
        {
            scanarea.Height = (int) Math.Round((float) generalSection.scanAreaPicture.Height/100*height, 1);
            scanarea.Width = (int) Math.Round((float) generalSection.scanAreaPicture.Width/100*width, 1);
            scanarea.Left = (int) Math.Round((float) generalSection.scanAreaPicture.Width/100*x, 1);
            scanarea.Top = (int) Math.Round((float) generalSection.scanAreaPicture.Height/100*y, 1);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            saveConfig(Config.GetFile(Config.Dir.Config, "IntelligentFrameCorrection.xml"));
            Close();
        }

        internal void saveConfig(String path)
        {
            using (var xmlwriter = new Settings(path, false))
            {
                try
                {
                    xmlwriter.SetValueAsBool("Config", "4:3", generalSection.rdb4to3.Checked);
                    xmlwriter.SetValueAsBool("Config", "16:9", generalSection.rdb16to9.Checked);
                    xmlwriter.SetValueAsBool("Config", "21:9", generalSection.rdb21to9.Checked);

                    xmlwriter.SetValue("Config", "scaninterval", generalSection.numUpDownScanInterval.Value);
                    xmlwriter.SetValue("Config", "stop counter", generalSection.numUpDownDetectionCounter.Value);
                    xmlwriter.SetValueAsBool("Config", "verboselogging", generalSection.ckbVerboseLogging.Checked);
                    xmlwriter.SetValueAsBool("Config", "correct AR", generalSection.ckbCorrectAspectRatio.Checked);
                    xmlwriter.SetValueAsBool("Config", "use only zoom factor", generalSection.ckbUseZoomFactorOnly.Checked);
                    

                    xmlwriter.SetValueAsBool("Config", "isBlackBarScannerEnabled",
                                             generalSection.ckbBlackBarScanner.Checked);
                    xmlwriter.SetValueAsBool("Config", "HD support",
                                             generalSection.ckbHDSupport.Checked);

                    xmlwriter.SetValue("Config", "HD height",
                                            generalSection.numUpDownHDHeight.Value);

                    xmlwriter.SetValue("Config", "HD width",
                                            generalSection.numUpDownHDWidth.Value);

                    xmlwriter.SetValue("Config", "HD operator",
                                            generalSection.btnOperator.Text);

                    xmlwriter.SetValueAsBool("Config", "video support",
                         generalSection.ckbVideoSupport.Checked);

                    xmlwriter.SetValue("Config", "maxBrightnessTreshold",
                                       generalSection.numUpDownMaxBrightnessThreashold.Value);
                    xmlwriter.SetValue("Config", "minBrightnessTreshold",
                                       generalSection.numUpDownMinBrightnessThreashold.Value);

                    xmlwriter.SetValueAsBool("Config", "auto start", generalSection.ckbAutoStart.Checked);
                    xmlwriter.SetValue("Config", "stabilization factor", generalSection.numUpDownStabilizationFactor.Value);

                    xmlwriter.SetValue("Config", "stabilization tolerance", generalSection.numUpDownStabilizationTolerance.Value);

                    xmlwriter.SetValue("Config", "edge detection tolerance", generalSection.numUpDownEdgeDetectionTolerance.Value);

                    xmlwriter.SetValue("Config", "frame capture size", generalSection.numUpDownFrameCaptureSize.Value);

                    xmlwriter.SetValue("Config", "single black bar height",
                                       generalSection.numUpDownSingleBlackBarHeight.Value*10);
                    xmlwriter.SetValue("Config", "double black bar height",
                                       generalSection.numUpDownDoubleBlackBarHeight.Value*10);

                    xmlwriter.SetValue("Top Scan Area", "height",
                                       generalSection.listViewScanArea.Items[0].SubItems[1].Text);
                    xmlwriter.SetValue("Top Scan Area", "width",
                                       generalSection.listViewScanArea.Items[0].SubItems[2].Text);
                    xmlwriter.SetValue("Top Scan Area", "x", generalSection.listViewScanArea.Items[0].SubItems[3].Text);
                    xmlwriter.SetValue("Top Scan Area", "y", generalSection.listViewScanArea.Items[0].SubItems[4].Text);

                    xmlwriter.SetValue("Bottom Scan Area", "height",
                                       generalSection.listViewScanArea.Items[1].SubItems[1].Text);
                    xmlwriter.SetValue("Bottom Scan Area", "width",
                                       generalSection.listViewScanArea.Items[1].SubItems[2].Text);
                    xmlwriter.SetValue("Bottom Scan Area", "x",
                                       generalSection.listViewScanArea.Items[1].SubItems[3].Text);
                    xmlwriter.SetValue("Bottom Scan Area", "y",
                                       generalSection.listViewScanArea.Items[1].SubItems[4].Text);

                    xmlwriter.SetValue(
                        "Left Scan Area", "height", generalSection.listViewScanArea.Items[2].SubItems[1].Text);
                    xmlwriter.SetValue(
                        "Left Scan Area", "width", generalSection.listViewScanArea.Items[2].SubItems[2].Text);
                    xmlwriter.SetValue(
                        "Left Scan Area", "x", generalSection.listViewScanArea.Items[2].SubItems[3].Text);
                    xmlwriter.SetValue(
                        "Left Scan Area", "y", generalSection.listViewScanArea.Items[2].SubItems[4].Text);
                    
                    xmlwriter.SetValue("Right Scan Area", "height",
                                       generalSection.listViewScanArea.Items[3].SubItems[1].Text);
                    xmlwriter.SetValue("Right Scan Area", "width",
                                       generalSection.listViewScanArea.Items[3].SubItems[2].Text);
                    xmlwriter.SetValue("Right Scan Area", "x", generalSection.listViewScanArea.Items[3].SubItems[3].Text);
                    xmlwriter.SetValue("Right Scan Area", "y", generalSection.listViewScanArea.Items[3].SubItems[4].Text);

                    xmlwriter.SetValue("Video Crop", "top", videoSection.numUpDownVideoCropTop.Value);
                    xmlwriter.SetValue("Video Crop", "bottom", videoSection.numUpDownVideoCropBottom.Value);
                    xmlwriter.SetValue("Video Crop", "left", videoSection.numUpDownVideoCropLeft.Value);
                    xmlwriter.SetValue("Video Crop", "right", videoSection.numUpDownVideoCropRight.Value);

                    xmlwriter.SetValue("Overscan Crop", "top", generalSection.numUpDownOverscanCropTop.Value);
                    xmlwriter.SetValue("Overscan Crop", "bottom", generalSection.numUpDownOverscanCropBottom.Value);
                    xmlwriter.SetValue("Overscan Crop", "left", generalSection.numUpDownOverscanCropLeft.Value);
                    xmlwriter.SetValue("Overscan Crop", "right", generalSection.numUpDownOverscanCropRight.Value);

                    using (var writer = new Settings(Config.GetFile(Config.Dir.Config, "MediaPortal.xml"), true))
                    {
                        writer.SetValue("tv", "croptop", tvrecSection.numUpDownTVCropTop.Value);
                        writer.SetValue("tv", "cropbottom", tvrecSection.numUpDownTVCropBottom.Value);
                        writer.SetValue("tv", "cropleft", tvrecSection.numUpDownTVCropLeft.Value);
                        writer.SetValue("tv", "cropright", tvrecSection.numUpDownTVCropRight.Value);
                    }


                    xmlwriter.SetValue("View Mode", "4:3",
                                       generalSection.listViewAdvancedViewMode.Items[0].SubItems[1].Text + "," +
                                       generalSection.listViewAdvancedViewMode.Items[0].SubItems[2].Text + "," +
                                       generalSection.listViewAdvancedViewMode.Items[0].SubItems[3].Text + "," +
                                       generalSection.listViewAdvancedViewMode.Items[0].SubItems[4].Text + "," +
                                       generalSection.listViewAdvancedViewMode.Items[0].SubItems[5].Text);

                    xmlwriter.SetValue("View Mode", "4:3 Letterbox",
                                       generalSection.listViewAdvancedViewMode.Items[1].SubItems[1].Text + "," +
                                       generalSection.listViewAdvancedViewMode.Items[1].SubItems[2].Text + "," +
                                       generalSection.listViewAdvancedViewMode.Items[1].SubItems[3].Text + "," +
                                       generalSection.listViewAdvancedViewMode.Items[1].SubItems[4].Text + "," +
                                       generalSection.listViewAdvancedViewMode.Items[1].SubItems[5].Text);

                    xmlwriter.SetValue("View Mode", "16:9",
                                       generalSection.listViewAdvancedViewMode.Items[2].SubItems[1].Text + "," +
                                       generalSection.listViewAdvancedViewMode.Items[2].SubItems[2].Text + "," +
                                       generalSection.listViewAdvancedViewMode.Items[2].SubItems[3].Text + "," +
                                       generalSection.listViewAdvancedViewMode.Items[2].SubItems[4].Text + "," +
                                       generalSection.listViewAdvancedViewMode.Items[2].SubItems[5].Text);

                    xmlwriter.SetValue("View Mode", "16:9 Letterbox",
                                       generalSection.listViewAdvancedViewMode.Items[3].SubItems[1].Text + "," +
                                       generalSection.listViewAdvancedViewMode.Items[3].SubItems[2].Text + "," +
                                       generalSection.listViewAdvancedViewMode.Items[3].SubItems[3].Text + "," +
                                       generalSection.listViewAdvancedViewMode.Items[3].SubItems[4].Text + "," +
                                       generalSection.listViewAdvancedViewMode.Items[3].SubItems[5].Text);

                    xmlwriter.SetValue("View Mode", "16:9 with Sidebars",
                                       generalSection.listViewAdvancedViewMode.Items[4].SubItems[1].Text + "," +
                                       generalSection.listViewAdvancedViewMode.Items[4].SubItems[2].Text + "," +
                                       generalSection.listViewAdvancedViewMode.Items[4].SubItems[3].Text + "," +
                                       generalSection.listViewAdvancedViewMode.Items[4].SubItems[4].Text + "," +
                                       generalSection.listViewAdvancedViewMode.Items[4].SubItems[5].Text);

                    xmlwriter.SetValue("View Mode", "21:9",
                                       generalSection.listViewAdvancedViewMode.Items[5].SubItems[1].Text + "," +
                                       generalSection.listViewAdvancedViewMode.Items[5].SubItems[2].Text + "," +
                                       generalSection.listViewAdvancedViewMode.Items[5].SubItems[3].Text + "," +
                                       generalSection.listViewAdvancedViewMode.Items[5].SubItems[4].Text + "," +
                                       generalSection.listViewAdvancedViewMode.Items[5].SubItems[5].Text);

                    xmlwriter.SetValue("View Mode", "Default",
                                       generalSection.listViewAdvancedViewMode.Items[6].SubItems[1].Text + "," +
                                       generalSection.listViewAdvancedViewMode.Items[6].SubItems[2].Text + "," +
                                       generalSection.listViewAdvancedViewMode.Items[6].SubItems[3].Text + "," +
                                       generalSection.listViewAdvancedViewMode.Items[6].SubItems[4].Text + "," +
                                       generalSection.listViewAdvancedViewMode.Items[6].SubItems[5].Text);


                    Log.Debug("I.F.C.: Config saved!");
                }
                catch (Exception error)
                {
                    Log.Error("I.F.C.: " + error);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog
                          {
                              Filter = "XML Files (*.xml)|*.xml",
                              RestoreDirectory = true
                          };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                var success = loadConfig(ofd.FileName);

                if (!success)
                {
                    MessageBox.Show("Can't import configuration, check your configuration file!", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog
                          {
                              Filter = "XML Files (*.xml)|*.xml",
                              RestoreDirectory = true
                          };
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                saveConfig(sfd.FileName);
            }
        }
    }
}