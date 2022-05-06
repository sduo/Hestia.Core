using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Hestia.Core.Tests.Utility.Json
{
    [TestClass]
    public sealed class TimeOnlyToJson
    {
        [TestMethod]
        public void Test1()
        {
            TimeOnly? dt = null;
            Assert.AreEqual($"{{\"{nameof(dt)}\":null}}", Core.Utility.ToJson(new { dt }));
        }

        [TestMethod]
        public void Test2()
        {
            TimeOnly? dt = null;
            Assert.AreEqual($"[null]", Core.Utility.ToJson(new TimeOnly?[] { dt }));
        }

        [TestMethod]
        public void Test3()
        {
            TimeOnly? dt = null;
            Assert.AreEqual($"[null]", Core.Utility.ToJson(new List<TimeOnly?> { dt }));
        }

        [TestMethod]
        public void Test4()
        {
            TimeOnly? dt = TimeOnly.MinValue;
            Assert.AreEqual($"{{\"{nameof(dt)}\":\"{dt:HH:mm:ss}\"}}", Core.Utility.ToJson(new { dt }));
        }

        [TestMethod]
        public void Test5()
        {
            TimeOnly? dt = TimeOnly.MinValue;
            Assert.AreEqual($"[\"{dt:HH:mm:ss}\"]", Core.Utility.ToJson(new TimeOnly?[] { dt }));
        }

        [TestMethod]
        public void Test6()
        {
            TimeOnly? dt = TimeOnly.MinValue;
            Assert.AreEqual($"[\"{dt:HH:mm:ss}\"]", Core.Utility.ToJson(new List<TimeOnly?> { dt }));
        }

        [TestMethod]
        public void Test7()
        {
            TimeOnly? dt = TimeOnly.MaxValue;
            Assert.AreEqual($"{{\"{nameof(dt)}\":\"{dt:HH:mm:ss}\"}}", Core.Utility.ToJson(new { dt }));
        }

        [TestMethod]
        public void Test8()
        {
            TimeOnly? dt = TimeOnly.MaxValue;
            Assert.AreEqual($"[\"{dt:HH:mm:ss}\"]", Core.Utility.ToJson(new TimeOnly?[] { dt }));
        }

        [TestMethod]
        public void Test9()
        {
            TimeOnly? dt = TimeOnly.MaxValue;
            Assert.AreEqual($"[\"{dt:HH:mm:ss}\"]", Core.Utility.ToJson(new List<TimeOnly?> { dt }));
        }
    }
}
