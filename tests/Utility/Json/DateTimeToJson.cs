using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Hestia.Core.Tests.Utility.Json
{
    [TestClass]
    public sealed class DateTimeToJson
    {
        [TestMethod]
        public void Test1()
        {
            DateTime? dt = null;
            Assert.AreEqual($"{{\"{nameof(dt)}\":null}}", Core.Utility.ToJson(new { dt }));
        }

        [TestMethod]
        public void Test2()
        {
            DateTime? dt = null;
            Assert.AreEqual($"[null]", Core.Utility.ToJson(new DateTime?[] { dt }));
        }

        [TestMethod]
        public void Test3()
        {
            DateTime? dt = null;
            Assert.AreEqual($"[null]", Core.Utility.ToJson(new List<DateTime?> { dt }));
        }

        [TestMethod]
        public void Test4()
        {
            DateTime? dt = DateTime.Now;
            Assert.AreEqual($"{{\"{nameof(dt)}\":\"{dt:yyyy-MM-dd HH:mm:ss}\"}}", Core.Utility.ToJson(new { dt }));
        }

        [TestMethod]
        public void Test5()
        {
            DateTime? dt = DateTime.Now;
            Assert.AreEqual($"[\"{dt:yyyy-MM-dd HH:mm:ss}\"]", Core.Utility.ToJson(new DateTime?[] { dt }));
        }

        [TestMethod]
        public void Test6()
        {
            DateTime? dt = DateTime.Now;
            Assert.AreEqual($"[\"{dt:yyyy-MM-dd HH:mm:ss}\"]", Core.Utility.ToJson(new List<DateTime?> { dt }));
        }

        [TestMethod]
        public void Test7()
        {
            DateTime? dt = DateTime.MinValue;
            Assert.AreEqual($"{{\"{nameof(dt)}\":\"{dt:yyyy-MM-dd HH:mm:ss}\"}}", Core.Utility.ToJson(new { dt }));
        }

        [TestMethod]
        public void Test8()
        {
            DateTime? dt = DateTime.MinValue;
            Assert.AreEqual($"[\"{dt:yyyy-MM-dd HH:mm:ss}\"]", Core.Utility.ToJson(new DateTime?[] { dt }));
        }

        [TestMethod]
        public void Test9()
        {
            DateTime? dt = DateTime.MinValue;
            Assert.AreEqual($"[\"{dt:yyyy-MM-dd HH:mm:ss}\"]", Core.Utility.ToJson(new List<DateTime?> { dt }));
        }

        [TestMethod]
        public void Test10()
        {
            DateTime? dt = DateTime.MaxValue;
            Assert.AreEqual($"{{\"{nameof(dt)}\":\"{dt:yyyy-MM-dd HH:mm:ss}\"}}", Core.Utility.ToJson(new { dt }));
        }

        [TestMethod]
        public void Test11()
        {
            DateTime? dt = DateTime.MaxValue;
            Assert.AreEqual($"[\"{dt:yyyy-MM-dd HH:mm:ss}\"]", Core.Utility.ToJson(new DateTime?[] { dt }));
        }

        [TestMethod]
        public void Test12()
        {
            DateTime? dt = DateTime.MaxValue;
            Assert.AreEqual($"[\"{dt:yyyy-MM-dd HH:mm:ss}\"]", Core.Utility.ToJson(new List<DateTime?> { dt }));
        }
    }
}
