using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Hestia.Core.Tests.Utility.Json
{
    [TestClass]
    public sealed class DateOnlyToJson
    {
        [TestMethod]
        public void Test1()
        {
            DateOnly? dt = null;
            Assert.AreEqual($"{{\"{nameof(dt)}\":null}}", Core.Utility.ToJson(new { dt }));
        }

        [TestMethod]
        public void Test2()
        {
            DateOnly? dt = null;
            Assert.AreEqual($"[null]", Core.Utility.ToJson(new DateOnly?[] { dt }));
        }

        [TestMethod]
        public void Test3()
        {
            DateOnly? dt = null;
            Assert.AreEqual($"[null]", Core.Utility.ToJson(new List<DateOnly?> { dt }));
        }

        [TestMethod]
        public void Test4()
        {
            DateOnly? dt = DateOnly.MinValue;
            Assert.AreEqual($"{{\"{nameof(dt)}\":\"{dt:yyyy-MM-dd}\"}}", Core.Utility.ToJson(new { dt }));
        }

        [TestMethod]
        public void Test5()
        {
            DateOnly? dt = DateOnly.MinValue;
            Assert.AreEqual($"[\"{dt:yyyy-MM-dd}\"]", Core.Utility.ToJson(new DateOnly?[] { dt }));
        }

        [TestMethod]
        public void Test6()
        {
            DateOnly? dt = DateOnly.MinValue;
            Assert.AreEqual($"[\"{dt:yyyy-MM-dd}\"]", Core.Utility.ToJson(new List<DateOnly?> { dt }));
        }

        [TestMethod]
        public void Test7()
        {
            DateOnly? dt = DateOnly.MaxValue;
            Assert.AreEqual($"{{\"{nameof(dt)}\":\"{dt:yyyy-MM-dd}\"}}", Core.Utility.ToJson(new { dt }));
        }

        [TestMethod]
        public void Test8()
        {
            DateOnly? dt = DateOnly.MaxValue;
            Assert.AreEqual($"[\"{dt:yyyy-MM-dd}\"]", Core.Utility.ToJson(new DateOnly?[] { dt }));
        }

        [TestMethod]
        public void Test9()
        {
            DateOnly? dt = DateOnly.MaxValue;
            Assert.AreEqual($"[\"{dt:yyyy-MM-dd}\"]", Core.Utility.ToJson(new List<DateOnly?> { dt }));
        }
    }
}
