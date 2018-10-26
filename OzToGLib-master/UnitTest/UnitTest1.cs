using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_OzToGMethod()
        {

            double res = OzToGLib.Convert.OzToG(10);
            Assert.AreEqual(283.495231, res);
        }
        [TestMethod]
        public void Test_GToOzMethod()
        {

            double res = OzToGLib.Convert.GToOz(100);
            Assert.AreEqual(res.ToString(), 3.52739619.ToString());
        }
    }
}
