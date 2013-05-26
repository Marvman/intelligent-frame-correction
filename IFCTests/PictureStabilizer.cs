using IntelligentFrameCorrection;
using MediaPortal.Player;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IFCTests
{
    /// <summary>
    /// Summary description for PictureStabilizer
    /// </summary>
    [TestClass]
    public class PictureStabilizer
    {
        public PictureStabilizer()
        {
            new IntelligentFrameCorrection.IntelligentFrameCorrection();

        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void TestPictureStabilizer()
        {
            //DON'T CHANGE!!! Or the Test below will go wrong.
            Preferences.getInstance().stabilizationFactor = 5;
            Preferences.getInstance().stabilizationTolerance = 3;

            var cropSettings = new CropSettings(15, 15, 0, 5);
            FrameAnalyzer.pictureStabilizer(cropSettings);

            Assert.AreEqual(15, Preferences.getInstance().lastCropSettings.Top);
            Assert.AreEqual(15, Preferences.getInstance().lastStabilizer.Top);

            Assert.AreEqual(15, Preferences.getInstance().lastCropSettings.Bottom);
            Assert.AreEqual(15, Preferences.getInstance().lastStabilizer.Bottom);

            Assert.AreEqual(0, Preferences.getInstance().lastCropSettings.Left);
            Assert.AreEqual(0, Preferences.getInstance().lastStabilizer.Left);

            Assert.AreEqual(5, Preferences.getInstance().lastCropSettings.Right);
            Assert.AreEqual(5, Preferences.getInstance().lastStabilizer.Right);

            cropSettings = new CropSettings(9, 8, 0, 0);
            FrameAnalyzer.pictureStabilizer(cropSettings);

            Assert.AreEqual(9, Preferences.getInstance().lastCropSettings.Top);
            Assert.AreEqual(10, Preferences.getInstance().lastStabilizer.Top);

            Assert.AreEqual(8, Preferences.getInstance().lastCropSettings.Bottom);
            Assert.AreEqual(10, Preferences.getInstance().lastStabilizer.Bottom);

            Assert.AreEqual(0, Preferences.getInstance().lastCropSettings.Left);
            Assert.AreEqual(0, Preferences.getInstance().lastStabilizer.Left);

            Assert.AreEqual(0, Preferences.getInstance().lastCropSettings.Right);
            Assert.AreEqual(0, Preferences.getInstance().lastStabilizer.Right);

        }

        [TestMethod]
        public void TestPictureStabilizer2()
        {
            //DON'T CHANGE!!! Or the Test below will go wrong.
            Preferences.getInstance().stabilizationFactor = 10;
            Preferences.getInstance().stabilizationTolerance = 7;

            var cropSettings = new CropSettings(0,0,0,0);
            FrameAnalyzer.pictureStabilizer(cropSettings);
            
            Assert.AreEqual(0, Preferences.getInstance().lastCropSettings.Top);
            Assert.AreEqual(0, Preferences.getInstance().lastStabilizer.Top);

            cropSettings.Top = 10;
            FrameAnalyzer.pictureStabilizer(cropSettings);

            Assert.AreEqual(10, Preferences.getInstance().lastCropSettings.Top);
            Assert.AreEqual(10, Preferences.getInstance().lastStabilizer.Top);

            cropSettings.Top = 0;
            FrameAnalyzer.pictureStabilizer(cropSettings);

            Assert.AreEqual(0, Preferences.getInstance().lastCropSettings.Top);
            Assert.AreEqual(10, Preferences.getInstance().lastStabilizer.Top);

            cropSettings.Top = 10;
            FrameAnalyzer.pictureStabilizer(cropSettings);

            Assert.AreEqual(10, Preferences.getInstance().lastCropSettings.Top);
            Assert.AreEqual(10, Preferences.getInstance().lastStabilizer.Top);

            cropSettings.Top = 7;
            FrameAnalyzer.pictureStabilizer(cropSettings);

            Assert.AreEqual(7, Preferences.getInstance().lastCropSettings.Top);
            Assert.AreEqual(10, Preferences.getInstance().lastStabilizer.Top);

            cropSettings.Top = 3;
            FrameAnalyzer.pictureStabilizer(cropSettings);

            Assert.AreEqual(3, Preferences.getInstance().lastCropSettings.Top);
            Assert.AreEqual(10, Preferences.getInstance().lastStabilizer.Top);

            cropSettings.Top = 11;
            FrameAnalyzer.pictureStabilizer(cropSettings);

            Assert.AreEqual(11, Preferences.getInstance().lastCropSettings.Top);
            Assert.AreEqual(20, Preferences.getInstance().lastStabilizer.Top);

            cropSettings.Top = 7;
            FrameAnalyzer.pictureStabilizer(cropSettings);

            Assert.AreEqual(7, Preferences.getInstance().lastCropSettings.Top);
            Assert.AreEqual(20, Preferences.getInstance().lastStabilizer.Top);

            cropSettings.Top = 3;
            FrameAnalyzer.pictureStabilizer(cropSettings);

            Assert.AreEqual(3, Preferences.getInstance().lastCropSettings.Top);
            Assert.AreEqual(10, Preferences.getInstance().lastStabilizer.Top);

            cropSettings.Top = 6;
            FrameAnalyzer.pictureStabilizer(cropSettings);

            Assert.AreEqual(6, Preferences.getInstance().lastCropSettings.Top);
            Assert.AreEqual(10, Preferences.getInstance().lastStabilizer.Top);

            cropSettings.Top = 0;
            FrameAnalyzer.pictureStabilizer(cropSettings);

            Assert.AreEqual(0, Preferences.getInstance().lastCropSettings.Top);
            Assert.AreEqual(10, Preferences.getInstance().lastStabilizer.Top);

            cropSettings.Top = 0;
            FrameAnalyzer.pictureStabilizer(cropSettings);

            Assert.AreEqual(0, Preferences.getInstance().lastCropSettings.Top);
            Assert.AreEqual(10, Preferences.getInstance().lastStabilizer.Top);
        }
    }
}
