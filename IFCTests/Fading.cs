using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IFCTests
{
    /// <summary>
    /// Summary description for Fading
    /// </summary>
    [TestClass]
    public class Fading
    {
        private int fromTop, fromBottom, fromLeft, fromRight;
        private int toTop, toBottom, toLeft, toRight;

        public Fading()
        {
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the from test run.
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
        public void TestFade()
        {
            Random random = new Random();

            for (int i = 0; i < 10; i++)
            { 
                fromTop = random.Next(50);
                fromBottom = random.Next(50);
                fromLeft = random.Next(50);
                fromRight = random.Next(50);

                toTop = random.Next(50);
                toBottom = random.Next(50);
                toLeft = random.Next(50);
                toRight = random.Next(50);

                do
                {
                    if (fromTop > toTop)
                    {
                        fromTop--;
                    }
                    else if (fromTop < toTop)
                    {
                        fromTop++;
                    }
                    else
                    {
                        Assert.IsTrue(fromTop == toTop);
                    }

                    if (fromBottom > toBottom)
                    {
                        fromBottom--;
                    }
                    else if (fromBottom < toBottom)
                    {
                        fromBottom++;
                    }

                    if (fromLeft > toLeft)
                    {
                        fromLeft--;
                    }
                    else if (fromLeft < toLeft)
                    {
                        fromLeft++;
                    }

                    if (fromRight > toRight)
                    {
                        fromRight--;
                    }
                    else if (fromRight < toRight)
                    {
                        fromRight++;
                    }
                //System.Console.Out.WriteLine(toTop + " " + toBottom + " " + toLeft + " " + toRight);  
                System.Console.Out.WriteLine(fromTop + " " + fromBottom + " " + fromLeft + " " + fromRight); 
                } while (fromTop != toTop || fromBottom != toBottom || fromLeft != toLeft || fromRight != toRight);

                System.Console.Out.WriteLine("");
                Assert.AreEqual(toTop, fromTop);
                Assert.AreEqual(toBottom, fromBottom);
                Assert.AreEqual(toLeft, fromLeft);
                Assert.AreEqual(toRight, fromRight);
            }
            
            
        }
    }
}
