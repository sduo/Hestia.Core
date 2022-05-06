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
            TimeSpan? ts = null;
            Assert.AreEqual($"{{\"{nameof(ts)}\":null}}", Core.Utility.ToJson(new { ts }));
        }

        [TestMethod]
        public void Test2()
        {
            TimeSpan? ts = null;
            Assert.AreEqual($"[null]", Core.Utility.ToJson(new TimeSpan?[] { ts }));
        }

        [TestMethod]
        public void Test3()
        {
            TimeSpan? ts = null;
            Assert.AreEqual($"[null]", Core.Utility.ToJson(new List<TimeSpan?> { ts }));
        }

        [TestMethod]
        public void Test4()
        {
            TimeSpan? ts = TimeSpan.MinValue;
            Assert.AreEqual($"{{\"{nameof(ts)}\":\"{ts:G}\"}}", Core.Utility.ToJson(new { ts }));
        }

        [TestMethod]
        public void Test5()
        {
            TimeSpan? ts = TimeSpan.MinValue;
            Assert.AreEqual($"[\"{ts:G}\"]", Core.Utility.ToJson(new TimeSpan?[] { ts }));
        }

        [TestMethod]
        public void Test6()
        {
            TimeSpan? ts = TimeSpan.MinValue;
            Assert.AreEqual($"[\"{ts:G}\"]", Core.Utility.ToJson(new List<TimeSpan?> { ts }));
        }

        [TestMethod]
        public void Test7()
        {
            TimeSpan? ts = TimeSpan.MaxValue;
            Assert.AreEqual($"{{\"{nameof(ts)}\":\"{ts:G}\"}}", Core.Utility.ToJson(new { ts }));
        }

        [TestMethod]
        public void Test8()
        {
            TimeSpan? ts = TimeSpan.MaxValue;
            Assert.AreEqual($"[\"{ts:G}\"]", Core.Utility.ToJson(new TimeSpan?[] { ts }));
        }

        [TestMethod]
        public void Test9()
        {
            TimeSpan? ts = TimeSpan.MaxValue;
            Assert.AreEqual($"[\"{ts:G}\"]", Core.Utility.ToJson(new List<TimeSpan?> { ts }));
        }
    }
}
