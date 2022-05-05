using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Hestia.Core.Tests.Extensions.StringExtensions
{
    [TestClass]
    public sealed class ToDateTime
    {
        [TestMethod]
        public void Test1()
        {
            Assert.AreEqual(null, string.Empty.ToDateTime());
        }

        [TestMethod]
        public void Test2()
        {
            Assert.AreEqual(DateTime.MinValue, $"{DateTime.MinValue:yyyyMMddHHmmss}".ToDateTime());
        }

        [TestMethod]
        public void Test3()
        {
            Assert.AreEqual(DateTime.MinValue, $"{DateTime.MinValue:yyyy-MM-dd HH:mm:ss}".ToDateTime());
        }

        [TestMethod]
        public void Test4()
        {
            Assert.AreEqual(DateTime.MaxValue, $"{DateTime.MaxValue:yyyyMMddHHmmssfffffff}".ToDateTime());
        }

        [TestMethod]
        public void Test5()
        {
            Assert.AreEqual(DateTime.MaxValue, $"{DateTime.MaxValue:yyyy-MM-dd HH:mm:ss.fffffff}".ToDateTime());
        }

        [TestMethod]
        public void Test6()
        {
            DateTime now = DateTime.Now;
            Assert.AreEqual(now, $"{now:yyyy-MM-dd HH:mm:ss.fffffff}".ToDateTime());
        }

        [TestMethod]
        public void Test7()
        {
            DateTime now = DateTime.Now;
            Assert.AreEqual(now, $"{now:yyyyMMddHHmmssfffffff}".ToDateTime());
        }

        [TestMethod]
        public void Test8()
        {
            DateTime today = DateTime.Today;
            Assert.AreEqual(today, $"{today:yyyy-MM-dd HH:mm:ss}".ToDateTime());
        }

        [TestMethod]
        public void Test9()
        {
            DateTime today = DateTime.Today;
            Assert.AreEqual(today, $"{today:yyyyMMddHHmmss}".ToDateTime());
        }

        [TestMethod]
        public void Test10()
        {
            DateTime today = DateTime.Today;
            Assert.AreEqual(today, $"{today:yyyy-MM-dd}".ToDateTime());
        }

        [TestMethod]
        public void Test11()
        {
            DateTime today = DateTime.Today;
            Assert.AreEqual(today, $"{today:yyyyMMdd}".ToDateTime());
        }
    }
}
