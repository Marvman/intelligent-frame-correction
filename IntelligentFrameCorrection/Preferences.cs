using System;
using System.Drawing;
using MediaPortal.Configuration;
using MediaPortal.GUI.Library;
using MediaPortal.Player;
using MediaPortal.Profile;

namespace IntelligentFrameCorrection
{
    public class Preferences
    {
        private static Preferences instance;

        public CustomViewMode ViewModeDefault { get; set; }

        public CustomViewMode ViewMode219 { get; set; }

        public CustomViewMode ViewMode169 { get; set; }

        public CustomViewMode ViewMode169Letterbox { get; set; }

        public CustomViewMode ViewMode169WithSidebars { get; set; }

        public CustomViewMode ViewMode43 { get; set; }

        public CustomViewMode ViewMode43Letterbox { get; set; }

        public bool verboselogging { get; set; }

        public bool correctAR { get; set; }

        public bool isHDSupportEnabled { get; set; }

        public bool isVideoSupportEnabled { get; set; }

        public bool autoStart { get; set; }

        public bool isBlackBarScannerEnabled { get; set; }

        public int stopCounter { get; set; }

        public int stopCounterEnd { get; set; }

        public int scanInterval { get; set; }

        public int stabilizationFactor { get; set; }

        public int stabilizationTolerance { get; set; }

        public int frameCaptureSize { get; set; }

        public float singleBlackBarHeight { get; set; } //0.125f;

        public float doubleBlackBarHeight { get; set; } //0.2135f;

        public bool isMyPluginsUsed { get; set; }

        public int HDHeight { get; set; }

        public int HDWidth { get; set; }

        public string HDOperator { get; set;}

        public bool isUseFixedZoomFactor{ get; set; }

        public int edgeDetectorTolerance { get; set; }

        /// <summary>
        /// last faded cropsettings
        /// </summary>
        public CropSettings lastCalcedCropSettings { get; set; }

        /// <summary>
        /// last cropsettings before the stabilizer
        /// </summary>
        public CropSettings lastCropSettings { get; set; }

        internal CropSettings videoCropSettings { get; set; }
        internal CropSettings tvCropSettings { get; set; }
        internal CropSettings overscanCropSettings { get; set; }


        internal Rectangle topScanArea;
        internal Rectangle bottomScanArea;
        internal Rectangle leftScanArea;
        internal Rectangle rightScanArea;

        //at which threshold is content detected
        public int maxBrightnessTreshold { get; set; }
        public int minBrightnessTreshold { get; set; }

        public CropSettings lastStabilizer { get; set; }

        internal int[] histR = new int[256];
        internal int[] histG = new int[256];
        internal int[] histB = new int[256];

        internal const float ADD_SINGLE_BLACK_BAR = 0.0885f;

        private Preferences()
        {
            lastCalcedCropSettings = new CropSettings();
            lastCropSettings = new CropSettings();
            lastStabilizer = new CropSettings();
        }

        public static Preferences getInstance()
        {
            if (instance != null)
            {
                return instance;
            }

            instance = new Preferences();
            return instance;
        }

        public bool loadSettings(String path)
        {
            var result = false;
            //using (
            //    var reader = new Settings(Config.GetFile(Config.Dir.Config, "IntelligentFrameCorrection.xml"),
                                          //false))
            using (var reader = new Settings(path, false))
            {
                try
                {
                    IntelligentFrameCorrection.getInstance.isAspectRatio4To3 = reader.GetValueAsBool("Config", "4:3",
                                                                                                     false);
                    IntelligentFrameCorrection.getInstance.isAspectRatio16To9 = reader.GetValueAsBool("Config", "16:9",
                                                                                                      true);
                    IntelligentFrameCorrection.getInstance.isAspectRatio21To9 = reader.GetValueAsBool("Config", "21:9",
                                                                                                      false);

                    maxBrightnessTreshold = reader.GetValueAsInt("Config",
                                                                 "maxBrightnessTreshold", 40);
                    minBrightnessTreshold = reader.GetValueAsInt("Config",
                                                                 "minBrightnessTreshold", 23);

                    scanInterval = reader.GetValueAsInt("Config", "scaninterval", 5000);
                    stopCounterEnd = reader.GetValueAsInt("Config", "stop counter", 5);
                    autoStart = reader.GetValueAsBool("Config", "auto start", true);

                    isBlackBarScannerEnabled = reader.GetValueAsBool("Config",
                                                                     "isBlackBarScannerEnabled",
                                                                     true);

                    isHDSupportEnabled = reader.GetValueAsBool("Config",
                                                                     "HD support",
                                                                     true);

                    HDHeight = reader.GetValueAsInt("Config", "HD height", 600);

                    HDWidth = reader.GetValueAsInt("Config", "HD width", 1200);

                    HDOperator = reader.GetValueAsString("Config", "HD operator", "or");

                    isVideoSupportEnabled = reader.GetValueAsBool("Config",
                                                                     "video support",
                                                                     true);

                    stabilizationFactor = reader.GetValueAsInt("Config", "stabilization factor", 10);
                    stabilizationTolerance = reader.GetValueAsInt("Config", "stabilization tolerance", 7);

                    edgeDetectorTolerance = reader.GetValueAsInt("Config", "edge detection tolerance", 3);

                    frameCaptureSize = reader.GetValueAsInt("Config", "frame capture size", 50);

                    verboselogging = reader.GetValueAsBool("Config", "verboselogging", false);
                    correctAR = reader.GetValueAsBool("Config", "correct AR", true);
                    isUseFixedZoomFactor = reader.GetValueAsBool("Config", "use only zoom factor", false);
                    

                    singleBlackBarHeight =
                        (float)reader.GetValueAsInt("Config", "single black bar height", 70)/1000;
                    doubleBlackBarHeight =
                        (float)reader.GetValueAsInt("Config", "double black bar height", 180)/1000;

                    videoCropSettings = new CropSettings(
                        reader.GetValueAsInt("Video Crop", "top", 0),
                        reader.GetValueAsInt("Video Crop", "bottom", 0),
                        reader.GetValueAsInt("Video Crop", "left", 0),
                        reader.GetValueAsInt("Video Crop", "right", 0)
                        );

                    overscanCropSettings = new CropSettings(
                        reader.GetValueAsInt("Overscan Crop", "top", 0),
                        reader.GetValueAsInt("Overscan Crop", "bottom", 0),
                        reader.GetValueAsInt("Overscan Crop", "left", 0),
                        reader.GetValueAsInt("Overscan Crop", "right", 0)
                        );

                    using (var xmlreader = new Settings(Config.GetFile(Config.Dir.Config, "MediaPortal.xml")))
                    {
                        tvCropSettings = new CropSettings(
                            xmlreader.GetValueAsInt("tv", "croptop", 0),
                            xmlreader.GetValueAsInt("tv", "cropbottom", 0),
                            xmlreader.GetValueAsInt("tv", "cropleft", 0),
                            xmlreader.GetValueAsInt("tv", "cropright", 0)
                            );

                        isMyPluginsUsed = xmlreader.GetValueAsBool("home", "usemyplugins", true);
                    }

                    topScanArea.Height = reader.GetValueAsInt("Top Scan Area", "height", 22);
                    topScanArea.Width = reader.GetValueAsInt("Top Scan Area", "width", 30);
                    topScanArea.Y = reader.GetValueAsInt("Top Scan Area", "y", 0);
                    topScanArea.X = reader.GetValueAsInt("Top Scan Area", "x", 31);

                    bottomScanArea.Height = reader.GetValueAsInt("Bottom Scan Area", "height",
                                                                 22);
                    bottomScanArea.Width = reader.GetValueAsInt("Bottom Scan Area", "width",
                                                                30);
                    bottomScanArea.Y = reader.GetValueAsInt("Bottom Scan Area", "y", 78);
                    bottomScanArea.X = reader.GetValueAsInt("Bottom Scan Area", "x", 31);

                    leftScanArea.Height = reader.GetValueAsInt("Left Scan Area", "height", 30);
                    leftScanArea.Width = reader.GetValueAsInt("Left Scan Area", "width", 13);
                    leftScanArea.Y = reader.GetValueAsInt("Left Scan Area", "y", 30);
                    leftScanArea.X = reader.GetValueAsInt("Left Scan Area", "x", 0);

                    rightScanArea.Height = reader.GetValueAsInt("Right Scan Area", "height",
                                                                30);
                    rightScanArea.Width = reader.GetValueAsInt("Right Scan Area", "width", 13);
                    rightScanArea.Y = reader.GetValueAsInt("Right Scan Area", "y", 30);
                    rightScanArea.X = reader.GetValueAsInt("Right Scan Area", "x", 87);

                    ViewMode43 =
                        Utils.stringToCustomViewMode(reader.GetValueAsString("View Mode", "4:3",
                                                                             "NonLinearStretch,0,0,0,0"));

                    ViewMode43Letterbox =
                        Utils.stringToCustomViewMode(reader.GetValueAsString("View Mode", "4:3 Letterbox",
                                                                             "Stretch,0,0,0,0"));

                    ViewMode169 =
                        Utils.stringToCustomViewMode(reader.GetValueAsString("View Mode", "16:9", "Stretch,0,0,0,0"));

                    ViewMode169Letterbox =
                        Utils.stringToCustomViewMode(reader.GetValueAsString("View Mode", "16:9 Letterbox",
                                                                             "Stretch,0,0,0,0"));

                    ViewMode169WithSidebars =
                        Utils.stringToCustomViewMode(reader.GetValueAsString("View Mode", "16:9 with Sidebars",
                                                                             "NonLinearStretch,0,0,0,0"));

                    ViewMode219 =
                        Utils.stringToCustomViewMode(reader.GetValueAsString("View Mode", "21:9", "Normal,0,0,0,0"));

                    ViewModeDefault =
                        Utils.stringToCustomViewMode(reader.GetValueAsString("View Mode", "Default", "Stretch,0,0,0,0"));

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

        public void saveConfig(String path)
        {
            using (var xmlwriter = new Settings(path, false))
            {
                try
                {
                    xmlwriter.SetValueAsBool("Config", "4:3", IntelligentFrameCorrection.getInstance.isAspectRatio4To3);
                    xmlwriter.SetValueAsBool("Config", "16:9", IntelligentFrameCorrection.getInstance.isAspectRatio16To9);
                    xmlwriter.SetValueAsBool("Config", "21:9", IntelligentFrameCorrection.getInstance.isAspectRatio21To9);

                    xmlwriter.SetValue("Config", "scaninterval", scanInterval);
                    xmlwriter.SetValue("Config", "stop counter", stopCounterEnd);
                    xmlwriter.SetValueAsBool("Config", "verboselogging", verboselogging);
                    xmlwriter.SetValueAsBool("Config", "correct AR", correctAR);

                    xmlwriter.SetValueAsBool("Config", "use only zoom factor", isUseFixedZoomFactor);

                    xmlwriter.SetValueAsBool("Config", "isBlackBarScannerEnabled",
                                             isBlackBarScannerEnabled);

                    xmlwriter.SetValueAsBool("Config", "HD support",
                                             isHDSupportEnabled);

                    xmlwriter.SetValue("Config", "HD height", HDHeight);
                    xmlwriter.SetValue("Config", "HD width", HDWidth);

                    xmlwriter.SetValue("Config", "HD operator", HDOperator);

                    xmlwriter.SetValueAsBool("Config", "video support",
                                             isVideoSupportEnabled);

                    xmlwriter.SetValue("Config", "maxBrightnessTreshold",
                                       maxBrightnessTreshold);
                    xmlwriter.SetValue("Config", "minBrightnessTreshold",
                                       minBrightnessTreshold);

                    xmlwriter.SetValueAsBool("Config", "auto start", autoStart);
                    xmlwriter.SetValue("Config", "stabilization factor", stabilizationFactor);
                    xmlwriter.SetValue("Config", "stabilization tolerance", stabilizationTolerance);

                    xmlwriter.SetValue("Config", "frame capture size", frameCaptureSize);

                    xmlwriter.SetValue("Config", "edge detection tolerance", edgeDetectorTolerance);

                    xmlwriter.SetValue("Config", "single black bar height",
                                       singleBlackBarHeight*1000);
                    xmlwriter.SetValue("Config", "double black bar height",
                                       doubleBlackBarHeight*1000);

                    xmlwriter.SetValue("Top Scan Area", "height",
                                       topScanArea.Height);
                    xmlwriter.SetValue("Top Scan Area", "width",
                                       topScanArea.Width);
                    xmlwriter.SetValue("Top Scan Area", "x", topScanArea.X);
                    xmlwriter.SetValue("Top Scan Area", "y", topScanArea.Y);

                    xmlwriter.SetValue("Bottom Scan Area", "height",
                                       bottomScanArea.Height);
                    xmlwriter.SetValue("Bottom Scan Area", "width",
                                       bottomScanArea.Width);
                    xmlwriter.SetValue("Bottom Scan Area", "x",
                                       bottomScanArea.X);
                    xmlwriter.SetValue("Bottom Scan Area", "y",
                                       bottomScanArea.Y);

                    xmlwriter.SetValue(
                        "Left Scan Area", "height", leftScanArea.Height);
                    xmlwriter.SetValue(
                        "Left Scan Area", "width", leftScanArea.Width);
                    xmlwriter.SetValue(
                        "Left Scan Area", "x", leftScanArea.X);
                    xmlwriter.SetValue(
                        "Left Scan Area", "y", leftScanArea.Y);

                    xmlwriter.SetValue("Right Scan Area", "height",
                                       rightScanArea.Height);
                    xmlwriter.SetValue("Right Scan Area", "width",
                                       rightScanArea.Width);
                    xmlwriter.SetValue("Right Scan Area", "x", rightScanArea.X);
                    xmlwriter.SetValue("Right Scan Area", "y", rightScanArea.Y);

                    xmlwriter.SetValue("Video Crop", "top", videoCropSettings.Top);
                    xmlwriter.SetValue("Video Crop", "bottom", videoCropSettings.Bottom);
                    xmlwriter.SetValue("Video Crop", "left", videoCropSettings.Left);
                    xmlwriter.SetValue("Video Crop", "right", videoCropSettings.Right);

                    xmlwriter.SetValue("Overscan Crop", "top", overscanCropSettings.Top);
                    xmlwriter.SetValue("Overscan Crop", "bottom", overscanCropSettings.Bottom);
                    xmlwriter.SetValue("Overscan Crop", "left", overscanCropSettings.Left);
                    xmlwriter.SetValue("Overscan Crop", "right", overscanCropSettings.Right);

                    using (var writer = new Settings(Config.GetFile(Config.Dir.Config, "MediaPortal.xml"), true))
                    {
                        writer.SetValue("tv", "croptop", tvCropSettings.Top);
                        writer.SetValue("tv", "cropbottom", tvCropSettings.Bottom);
                        writer.SetValue("tv", "cropleft", tvCropSettings.Left);
                        writer.SetValue("tv", "cropright", tvCropSettings.Right);
                    }

                    xmlwriter.SetValue("View Mode", "4:3",
                                       ViewMode43.ViewMode + "," +
                                       ViewMode43.CropSettings.Top + "," +
                                       ViewMode43.CropSettings.Bottom + "," +
                                       ViewMode43.CropSettings.Left + "," +
                                       ViewMode43.CropSettings.Right);

                    xmlwriter.SetValue("View Mode", "4:3 Letterbox",
                                       ViewMode43Letterbox.ViewMode + "," +
                                       ViewMode43Letterbox.CropSettings.Top + "," +
                                       ViewMode43Letterbox.CropSettings.Bottom + "," +
                                       ViewMode43Letterbox.CropSettings.Left + "," +
                                       ViewMode43Letterbox.CropSettings.Right);

                    xmlwriter.SetValue("View Mode", "16:9",
                                       ViewMode169.ViewMode + "," +
                                       ViewMode169.CropSettings.Top + "," +
                                       ViewMode169.CropSettings.Bottom + "," +
                                       ViewMode169.CropSettings.Left + "," +
                                       ViewMode169.CropSettings.Right);

                    xmlwriter.SetValue("View Mode", "16:9 Letterbox",
                                       ViewMode169Letterbox.ViewMode + "," +
                                       ViewMode169Letterbox.CropSettings.Top + "," +
                                       ViewMode169Letterbox.CropSettings.Bottom + "," +
                                       ViewMode169Letterbox.CropSettings.Left + "," +
                                       ViewMode169Letterbox.CropSettings.Right);

                    xmlwriter.SetValue("View Mode", "16:9 with Sidebars",
                                       ViewMode169WithSidebars.ViewMode + "," +
                                       ViewMode169WithSidebars.CropSettings.Top + "," +
                                       ViewMode169WithSidebars.CropSettings.Bottom + "," +
                                       ViewMode169WithSidebars.CropSettings.Left + "," +
                                       ViewMode169WithSidebars.CropSettings.Right);

                    xmlwriter.SetValue("View Mode", "21:9",
                                       ViewMode219.ViewMode + "," +
                                       ViewMode219.CropSettings.Top + "," +
                                       ViewMode219.CropSettings.Bottom + "," +
                                       ViewMode219.CropSettings.Left + "," +
                                       ViewMode219.CropSettings.Right);

                    xmlwriter.SetValue("View Mode", "Default",
                                       ViewModeDefault.ViewMode + "," +
                                       ViewModeDefault.CropSettings.Top + "," +
                                       ViewModeDefault.CropSettings.Bottom + "," +
                                       ViewModeDefault.CropSettings.Left + "," +
                                       ViewModeDefault.CropSettings.Right);


                    Utils.log(verboselogging, "Config saved!");
                }
                catch (Exception error)
                {
                    Utils.log(true, error.ToString());
                }
            }
        }
    }
}