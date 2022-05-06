using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Hestia.Core.Tests.Utility.Json
{
    [TestClass]
    public sealed class TimeSpanToJson
    {
        [TestMethod]
        public void Test1()
        {
            TimeSpan? value = null;
            Assert.AreEqual($"{{\"{nameof(value)}\":null}}", Core.Utility.ToJson(new { value }));
        }

        [TestMethod]
        public void Test2()
        {
            TimeSpan? value = null;
            Assert.AreEqual($"[null]", Core.Utility.ToJson(new TimeSpan?[] { value }));
        }

        [TestMethod]
        public void Test3()
        {
            TimeSpan? value = null;
            Assert.AreEqual($"[null]", Core.Utility.ToJson(new List<TimeSpan?> { value }));
        }

        [TestMethod]
        public void Test4()
        {
            TimeSpan? value = TimeSpan.MinValue;
            Assert.AreEqual($"{{\"{nameof(value)}\":\"{value:G}\"}}", Core.Utility.ToJson(new { value }));
        }

        [TestMethod]
        public void Test5()
        {
            TimeSpan? value = TimeSpan.MinValue;
            Assert.AreEqual($"[\"{value:G}\"]", Core.Utility.ToJson(new TimeSpan?[] { value }));
        }

        [TestMethod]
        public void Test6()
        {
            TimeSpan? value = TimeSpan.MinValue;
            Assert.AreEqual($"[\"{value:G}\"]", Core.Utility.ToJson(new List<TimeSpan?> { value }));
        }

        [TestMethod]
        public void Test7()
        {
            TimeSpan? value = TimeSpan.MaxValue;
            Assert.AreEqual($"{{\"{nameof(value)}\":\"{value:G}\"}}", Core.Utility.ToJson(new { value }));
        }

        [TestMethod]
        public void Test8()
        {
            TimeSpan? value = TimeSpan.MaxValue;
            Assert.AreEqual($"[\"{value:G}\"]", Core.Utility.ToJson(new TimeSpan?[] { value }));
        }

        [TestMethod]
        public void Test9()
        {
            TimeSpan? value = TimeSpan.MaxValue;
            Assert.AreEqual($"[\"{value:G}\"]", Core.Utility.ToJson(new List<TimeSpan?> { value }));
        }
    }
}
