using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Hestia.Core.Tests.Utility.Json
{
    [TestClass]
    [ExcludeFromCodeCoverage]
    public sealed class DateTimeToJson
    {
        [TestMethod]
        public void Test1()
        {
            DateTime? value = null;
            Assert.AreEqual($"{{\"{nameof(value)}\":null}}", Core.Utility.ToJson(new { value }));
        }

        [TestMethod]
        public void Test2()
        {
            DateTime? value = null;
            Assert.AreEqual($"[null]", Core.Utility.ToJson(new DateTime?[] { value }));
        }

        [TestMethod]
        public void Test3()
        {
            DateTime? value = null;
            Assert.AreEqual($"[null]", Core.Utility.ToJson(new List<DateTime?> { value }));
        }

        [TestMethod]
        public void Test4()
        {
            DateTime? value = DateTime.Now;
            Assert.AreEqual($"{{\"{nameof(value)}\":\"{value:yyyy-MM-dd HH:mm:ss}\"}}", Core.Utility.ToJson(new { value }));
        }

        [TestMethod]
        public void Test5()
        {
            DateTime? value = DateTime.Now;
            Assert.AreEqual($"[\"{value:yyyy-MM-dd HH:mm:ss}\"]", Core.Utility.ToJson(new DateTime?[] { value }));
        }

        [TestMethod]
        public void Test6()
        {
            DateTime? value = DateTime.Now;
            Assert.AreEqual($"[\"{value:yyyy-MM-dd HH:mm:ss}\"]", Core.Utility.ToJson(new List<DateTime?> { value }));
        }

        [TestMethod]
        public void Test7()
        {
            DateTime? value = DateTime.MinValue;
            Assert.AreEqual($"{{\"{nameof(value)}\":\"{value:yyyy-MM-dd HH:mm:ss}\"}}", Core.Utility.ToJson(new { value }));
        }

        [TestMethod]
        public void Test8()
        {
            DateTime? value = DateTime.MinValue;
            Assert.AreEqual($"[\"{value:yyyy-MM-dd HH:mm:ss}\"]", Core.Utility.ToJson(new DateTime?[] { value }));
        }

        [TestMethod]
        public void Test9()
        {
            DateTime? value = DateTime.MinValue;
            Assert.AreEqual($"[\"{value:yyyy-MM-dd HH:mm:ss}\"]", Core.Utility.ToJson(new List<DateTime?> { value }));
        }

        [TestMethod]
        public void Test10()
        {
            DateTime? value = DateTime.MaxValue;
            Assert.AreEqual($"{{\"{nameof(value)}\":\"{value:yyyy-MM-dd HH:mm:ss}\"}}", Core.Utility.ToJson(new { value }));
        }

        [TestMethod]
        public void Test11()
        {
            DateTime? value = DateTime.MaxValue;
            Assert.AreEqual($"[\"{value:yyyy-MM-dd HH:mm:ss}\"]", Core.Utility.ToJson(new DateTime?[] { value }));
        }

        [TestMethod]
        public void Test12()
        {
            DateTime? value = DateTime.MaxValue;
            Assert.AreEqual($"[\"{value:yyyy-MM-dd HH:mm:ss}\"]", Core.Utility.ToJson(new List<DateTime?> { value }));
        }
    }
}
