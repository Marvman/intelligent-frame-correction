using System;
using System.Collections.Generic;
using MediaPortal.GUI.Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using IntelligentFrameCorrection;

namespace IFCTests
{
    /// <summary>
    /// Summary description for bestMatchedViewMode
    /// </summary>
    [TestClass]
    public class bestMatchedViewMode
    {
        Dictionary<CustomViewMode, int> _bestMatchedViewMode = new Dictionary<CustomViewMode, int>();
        CustomViewMode customViewMode = new CustomViewMode(Geometry.Type.Stretch, 0, 0, 0, 0);
        CustomViewMode customViewMode2 = new CustomViewMode(Geometry.Type.Normal, 0, 0, 0, 0);

        public bestMatchedViewMode()
        {
            //
            // TODO: Add constructor logic here
            //
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
        public void TestaddViewModeForBestMatch()
        {
            DateTime startTime = DateTime.Now;
            Console.Out.WriteLine(startTime);
            
            for (int i = 0; i < 3; i++)
            {

                if (_bestMatchedViewMode.ContainsKey(customViewMode))
                {
                    _bestMatchedViewMode[customViewMode]++ ;
                    Assert.AreEqual(i, _bestMatchedViewMode[customViewMode]);
                }
                else
                {
                    _bestMatchedViewMode.Add(customViewMode, 0);
                }
            }

            for (int i = 0; i < 3; i++)
            {

                if (_bestMatchedViewMode.ContainsKey(customViewMode2))
                {
                    _bestMatchedViewMode[customViewMode2]++;
                    Assert.AreEqual(i, _bestMatchedViewMode[customViewMode2]);
                }
                else
                {
                    _bestMatchedViewMode.Add(customViewMode2, 0);
                }
            }

            if (_bestMatchedViewMode.Count > 1)
            {
                int highestCount = 0;
                int found = 0;
                CustomViewMode bestmatchedviewmode = null;

                foreach (var mode in _bestMatchedViewMode)
                    {
                        if (mode.Value > highestCount)
                        {
                            highestCount = mode.Value;
                        }
                    }
                
                foreach (var mode in _bestMatchedViewMode)
                {                    
                    if (mode.Value == highestCount)
                    {
                        found++;
                        bestmatchedviewmode = mode.Key;
                    }
                }

                if (!(found > 1))
                {
                    Console.Out.WriteLine(bestmatchedviewmode.ViewMode);
                }
                else
                {
                    Console.Out.WriteLine("no best match found");
                }

            }



            DateTime stopTime = DateTime.Now;
            Console.Out.WriteLine(stopTime);
            TimeSpan duration = stopTime - startTime;
            Console.Out.WriteLine("Duration: " + duration.Milliseconds);

        }
    }
}
