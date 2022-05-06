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
            DateTimeOffset? value = null;
            Assert.AreEqual($"{{\"{nameof(value)}\":null}}", Core.Utility.ToJson(new { value }));
        }

        [TestMethod]
        public void Test2()
        {
            DateTimeOffset? value = null;
            Assert.AreEqual($"[null]", Core.Utility.ToJson(new DateTimeOffset?[] { value }));
        }

        [TestMethod]
        public void Test3()
        {
            DateTimeOffset? value = null;
            Assert.AreEqual($"[null]", Core.Utility.ToJson(new List<DateTimeOffset?> { value }));
        }

        [TestMethod]
        public void Test4()
        {
            DateTimeOffset? value = DateTimeOffset.Now;
            Assert.AreEqual($"{{\"{nameof(value)}\":\"{value:yyyy-MM-dd HH:mm:ss}\"}}", Core.Utility.ToJson(new { value }));
        }

        [TestMethod]
        public void Test5()
        {
            DateTimeOffset? value = DateTimeOffset.Now;
            Assert.AreEqual($"[\"{value:yyyy-MM-dd HH:mm:ss}\"]", Core.Utility.ToJson(new DateTimeOffset?[] { value }));
        }

        [TestMethod]
        public void Test6()
        {
            DateTimeOffset? value = DateTimeOffset.Now;
            Assert.AreEqual($"[\"{value:yyyy-MM-dd HH:mm:ss}\"]", Core.Utility.ToJson(new List<DateTimeOffset?> { value }));
        }

        [TestMethod]
        public void Test7()
        {
            DateTimeOffset? value = DateTimeOffset.MinValue;
            Assert.AreEqual($"{{\"{nameof(value)}\":\"{value:yyyy-MM-dd HH:mm:ss}\"}}", Core.Utility.ToJson(new { value }));
        }

        [TestMethod]
        public void Test8()
        {
            DateTimeOffset? value = DateTimeOffset.MinValue;
            Assert.AreEqual($"[\"{value:yyyy-MM-dd HH:mm:ss}\"]", Core.Utility.ToJson(new DateTimeOffset?[] { value }));
        }

        [TestMethod]
        public void Test9()
        {
            DateTimeOffset? value = DateTimeOffset.MinValue;
            Assert.AreEqual($"[\"{value:yyyy-MM-dd HH:mm:ss}\"]", Core.Utility.ToJson(new List<DateTimeOffset?> { value }));
        }

        [TestMethod]
        public void Test10()
        {
            DateTimeOffset? value = DateTimeOffset.MaxValue;
            Assert.AreEqual($"{{\"{nameof(value)}\":\"{value:yyyy-MM-dd HH:mm:ss}\"}}", Core.Utility.ToJson(new { value }));
        }

        [TestMethod]
        public void Test11()
        {
            DateTimeOffset? value = DateTimeOffset.MaxValue;
            Assert.AreEqual($"[\"{value:yyyy-MM-dd HH:mm:ss}\"]", Core.Utility.ToJson(new DateTimeOffset?[] { value }));
        }

        [TestMethod]
        public void Test12()
        {
            DateTimeOffset? value = DateTimeOffset.MaxValue;
            Assert.AreEqual($"[\"{value:yyyy-MM-dd HH:mm:ss}\"]", Core.Utility.ToJson(new List<DateTimeOffset?> { value }));
        }
    }
}
