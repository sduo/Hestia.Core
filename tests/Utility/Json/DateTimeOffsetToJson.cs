using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Hestia.Core.Tests.Utility.Json
{
    [TestClass]
    public sealed class DateTimeOffsetToJson
    {
        [TestMethod]
        public void Test1()
        {
            DateTimeOffset? dt = null;
            Assert.AreEqual($"{{\"{nameof(dt)}\":null}}", Core.Utility.ToJson(new { dt }));
        }

        [TestMethod]
        public void Test2()
        {
            DateTimeOffset? dt = null;
            Assert.AreEqual($"[null]", Core.Utility.ToJson(new DateTimeOffset?[] { dt }));
        }

        [TestMethod]
        public void Test3()
        {
            DateTimeOffset? dt = null;
            Assert.AreEqual($"[null]", Core.Utility.ToJson(new List<DateTimeOffset?> { dt }));
        }

        [TestMethod]
        public void Test4()
        {
            DateTimeOffset? dt = DateTimeOffset.Now;
            Assert.AreEqual($"{{\"{nameof(dt)}\":\"{dt:yyyy-MM-dd HH:mm:ss}\"}}", Core.Utility.ToJson(new { dt }));
        }

        [TestMethod]
        public void Test5()
        {
            DateTimeOffset? dt = DateTimeOffset.Now;
            Assert.AreEqual($"[\"{dt:yyyy-MM-dd HH:mm:ss}\"]", Core.Utility.ToJson(new DateTimeOffset?[] { dt }));
        }

        [TestMethod]
        public void Test6()
        {
            DateTimeOffset? dt = DateTimeOffset.Now;
            Assert.AreEqual($"[\"{dt:yyyy-MM-dd HH:mm:ss}\"]", Core.Utility.ToJson(new List<DateTimeOffset?> { dt }));
        }

        [TestMethod]
        public void Test7()
        {
            DateTimeOffset? dt = DateTimeOffset.MinValue;
            Assert.AreEqual($"{{\"{nameof(dt)}\":\"{dt:yyyy-MM-dd HH:mm:ss}\"}}", Core.Utility.ToJson(new { dt }));
        }

        [TestMethod]
        public void Test8()
        {
            DateTimeOffset? dt = DateTimeOffset.MinValue;
            Assert.AreEqual($"[\"{dt:yyyy-MM-dd HH:mm:ss}\"]", Core.Utility.ToJson(new DateTimeOffset?[] { dt }));
        }

        [TestMethod]
        public void Test9()
        {
            DateTimeOffset? dt = DateTimeOffset.MinValue;
            Assert.AreEqual($"[\"{dt:yyyy-MM-dd HH:mm:ss}\"]", Core.Utility.ToJson(new List<DateTimeOffset?> { dt }));
        }

        [TestMethod]
        public void Test10()
        {
            DateTimeOffset? dt = DateTimeOffset.MaxValue;
            Assert.AreEqual($"{{\"{nameof(dt)}\":\"{dt:yyyy-MM-dd HH:mm:ss}\"}}", Core.Utility.ToJson(new { dt }));
        }

        [TestMethod]
        public void Test11()
        {
            DateTimeOffset? dt = DateTimeOffset.MaxValue;
            Assert.AreEqual($"[\"{dt:yyyy-MM-dd HH:mm:ss}\"]", Core.Utility.ToJson(new DateTimeOffset?[] { dt }));
        }

        [TestMethod]
        public void Test12()
        {
            DateTimeOffset? dt = DateTimeOffset.MaxValue;
            Assert.AreEqual($"[\"{dt:yyyy-MM-dd HH:mm:ss}\"]", Core.Utility.ToJson(new List<DateTimeOffset?> { dt }));
        }
    }
}
