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
            DateOnly? value = null;
            Assert.AreEqual($"{{\"{nameof(value)}\":null}}", Core.Utility.ToJson(new { value }));
        }

        [TestMethod]
        public void Test2()
        {
            DateOnly? value = null;
            Assert.AreEqual($"[null]", Core.Utility.ToJson(new DateOnly?[] { value }));
        }

        [TestMethod]
        public void Test3()
        {
            DateOnly? value = null;
            Assert.AreEqual($"[null]", Core.Utility.ToJson(new List<DateOnly?> { value }));
        }

        [TestMethod]
        public void Test4()
        {
            DateOnly? value = DateOnly.MinValue;
            Assert.AreEqual($"{{\"{nameof(value)}\":\"{value:yyyy-MM-dd}\"}}", Core.Utility.ToJson(new { value }));
        }

        [TestMethod]
        public void Test5()
        {
            DateOnly? value = DateOnly.MinValue;
            Assert.AreEqual($"[\"{value:yyyy-MM-dd}\"]", Core.Utility.ToJson(new DateOnly?[] { value }));
        }

        [TestMethod]
        public void Test6()
        {
            DateOnly? value = DateOnly.MinValue;
            Assert.AreEqual($"[\"{value:yyyy-MM-dd}\"]", Core.Utility.ToJson(new List<DateOnly?> { value }));
        }

        [TestMethod]
        public void Test7()
        {
            DateOnly? value = DateOnly.MaxValue;
            Assert.AreEqual($"{{\"{nameof(value)}\":\"{value:yyyy-MM-dd}\"}}", Core.Utility.ToJson(new { value }));
        }

        [TestMethod]
        public void Test8()
        {
            DateOnly? value = DateOnly.MaxValue;
            Assert.AreEqual($"[\"{value:yyyy-MM-dd}\"]", Core.Utility.ToJson(new DateOnly?[] { value }));
        }

        [TestMethod]
        public void Test9()
        {
            DateOnly? value = DateOnly.MaxValue;
            Assert.AreEqual($"[\"{value:yyyy-MM-dd}\"]", Core.Utility.ToJson(new List<DateOnly?> { value }));
        }
    }
}
