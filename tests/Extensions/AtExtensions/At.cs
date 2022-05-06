using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Hestia.Core.Tests.Extensions.IListExtensions
{
    [TestClass]
    public sealed class At
    {
        internal List<string> nullClassList = null;
        internal List<int> nullStructList = null;
        internal string[] nullClassArray = null;
        internal int[] nullStructArray = null;
        internal List<string> emptyClassList = new List<string>();
        internal List<int> emptyStructList = new List<int>();
        internal string[] emptyClassArray = new string[0];
        internal int[] emptyStructArray = new int[0];
        internal List<string> classList =new List<string>() { "A","B","C" };
        internal List<int> structList = new List<int>() { 0,1,2 };
        internal string[] classArray = new string[] { "A","B","C" };
        internal int[] structArray = new int[] { 0,1,2 };


        [TestMethod]
        public void Test1()
        {
            Assert.AreEqual("A", classList.At(0));
        }

        [TestMethod]
        public void Test2()
        {
            Assert.AreEqual("A", classList.At(-3));
        }

        [TestMethod]
        public void Test3()
        {
            Assert.AreEqual("C", classList.At(2));
        }

        [TestMethod]
        public void Test4()
        {
            Assert.AreEqual("C", classList.At(-1));
        }

        [TestMethod]
        public void Test5()
        {
            Assert.AreEqual(null, classList.At(3));
        }

        [TestMethod]
        public void Test6()
        {
            Assert.AreEqual(null, classList.At(-4));
        }

        [TestMethod]
        public void Test7()
        {
            Assert.AreEqual(0, structList.At(0));
        }

        [TestMethod]
        public void Test8()
        {
            Assert.AreEqual(0, structList.At(-3));
        }

        [TestMethod]
        public void Test9()
        {
            Assert.AreEqual(2, structList.At(2));
        }

        [TestMethod]
        public void Test10()
        {
            Assert.AreEqual(2, structList.At(-1));
        }

        [TestMethod]
        public void Test11()
        {
            Assert.AreEqual(null, structList.At(3));
        }

        [TestMethod]
        public void Test12()
        {
            Assert.AreEqual(null, structList.At(-4));
        }

        [TestMethod]
        public void Test13()
        {
            Assert.AreEqual("A", classArray.At(0));
        }

        [TestMethod]
        public void Test14()
        {
            Assert.AreEqual("A", classArray.At(-3));
        }

        [TestMethod]
        public void Test15()
        {
            Assert.AreEqual("C", classArray.At(2));
        }

        [TestMethod]
        public void Test16()
        {
            Assert.AreEqual("C", classArray.At(-1));
        }

        [TestMethod]
        public void Test17()
        {
            Assert.AreEqual(null, classArray.At(3));
        }

        [TestMethod]
        public void Test18()
        {
            Assert.AreEqual(null, classArray.At(-4));
        }

        [TestMethod]
        public void Test19()
        {
            Assert.AreEqual(0, structArray.At(0));
        }

        [TestMethod]
        public void Test20()
        {
            Assert.AreEqual(0, structArray.At(-3));
        }

        [TestMethod]
        public void Test21()
        {
            Assert.AreEqual(2, structArray.At(2));
        }

        [TestMethod]
        public void Test22()
        {
            Assert.AreEqual(2, structArray.At(-1));
        }

        [TestMethod]
        public void Test23()
        {
            Assert.AreEqual(null, structArray.At(3));
        }

        [TestMethod]
        public void Test24()
        {
            Assert.AreEqual(null, structArray.At(-4));
        }

        [TestMethod]
        public void Test25()
        {
            Assert.AreEqual(null, nullClassList.At());
        }

        [TestMethod]
        public void Test26()
        {
            Assert.AreEqual(null, nullStructList.At());
        }

        [TestMethod]
        public void Test27()
        {
            Assert.AreEqual(null, nullClassArray.At());
        }

        [TestMethod]
        public void Test28()
        {
            Assert.AreEqual(null, nullStructArray.At());
        }

        [TestMethod]
        public void Test29()
        {
            Assert.AreEqual(null, emptyClassList.At());
        }

        [TestMethod]
        public void Test30()
        {
            Assert.AreEqual(null, emptyStructList.At());
        }

        [TestMethod]
        public void Test31()
        {
            Assert.AreEqual(null, emptyClassArray.At());
        }

        [TestMethod]
        public void Test32()
        {
            Assert.AreEqual(null, emptyStructArray.At());
        }
    }
}
