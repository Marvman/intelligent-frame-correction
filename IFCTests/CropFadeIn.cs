using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;

namespace IFCTests
{
    /// <summary>
    /// Summary description for CropFadeIn
    /// </summary>
    [TestClass]
    public class CropFadeIn
    {
        //int toTop = 80, toBottom = 90, toLeft = 23, toRight = 34;
        //int fromTop = 2, fromBottom = 3, fromLeft = 4, fromRight = 5;

        public CropFadeIn()
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
        public void TestFadeIn(int fromTop, int fromBottom, int fromLeft, int fromRight, int toTop, int toBottom, int toLeft, int toRight)
        {

           int currentTop = fromTop, currentBottom = fromBottom, currentLeft = fromLeft, currentRight = fromRight;

            for (int t = fromTop, b = fromBottom, l = fromLeft, r = fromRight; 
                            t <= toTop ||
                            b <= toBottom ||
                            l <= toLeft ||
                            r <= toRight; 
                            t++, b++, l++, r++)
            {
                if (t <= toTop)
                {
                    currentTop = t;
                }
                if (b <= toBottom)
                {
                    currentBottom = b;
                }
                if (l <= toLeft)
                {
                    currentLeft = l;
                }
                if (r <= toRight)
                {
                    currentRight = r;
                }

                Thread.Sleep(1);
                System.Console.Out.WriteLine(currentTop + " " + currentBottom + " " + currentLeft + " " + currentRight);
            }


            System.Console.Out.WriteLine("");
            Assert.AreEqual(toTop, currentTop);
            Assert.AreEqual(toBottom, currentBottom);
            Assert.AreEqual(toLeft, currentLeft);
            Assert.AreEqual(toRight, currentRight);
            
        }
    }
}
