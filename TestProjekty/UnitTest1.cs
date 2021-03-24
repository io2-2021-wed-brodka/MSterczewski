using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MSterczewski_Git;

namespace TestProjekty
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string number = "7";
            int realValue = 7;

            int res = Class.MyParse(number);
            Assert.AreEqual(res, realValue);
        }
    }
}
