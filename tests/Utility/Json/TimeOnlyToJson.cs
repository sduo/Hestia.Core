using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Hestia.Core.Tests.Utility.Json
{
    [TestClass]
    [ExcludeFromCodeCoverage]
    public sealed class TimeOnlyToJson
    {
        [TestMethod]
        public void Test1()
        {
            TimeOnly? value = null;
            Assert.AreEqual($"{{\"{nameof(value)}\":null}}", Core.Utility.ToJson(new { value }));
        }

        [TestMethod]
        public void Test2()
        {
            TimeOnly? value = null;
            Assert.AreEqual($"[null]", Core.Utility.ToJson(new TimeOnly?[] { value }));
        }

        [TestMethod]
        public void Test3()
        {
            TimeOnly? value = null;
            Assert.AreEqual($"[null]", Core.Utility.ToJson(new List<TimeOnly?> { value }));
        }

        [TestMethod]
        public void Test4()
        {
            TimeOnly? value = TimeOnly.MinValue;
            Assert.AreEqual($"{{\"{nameof(value)}\":\"{value:HH:mm:ss}\"}}", Core.Utility.ToJson(new { value }));
        }

        [TestMethod]
        public void Test5()
        {
            TimeOnly? value = TimeOnly.MinValue;
            Assert.AreEqual($"[\"{value:HH:mm:ss}\"]", Core.Utility.ToJson(new TimeOnly?[] { value }));
        }

        [TestMethod]
        public void Test6()
        {
            TimeOnly? value = TimeOnly.MinValue;
            Assert.AreEqual($"[\"{value:HH:mm:ss}\"]", Core.Utility.ToJson(new List<TimeOnly?> { value }));
        }

        [TestMethod]
        public void Test7()
        {
            TimeOnly? value = TimeOnly.MaxValue;
            Assert.AreEqual($"{{\"{nameof(value)}\":\"{value:HH:mm:ss}\"}}", Core.Utility.ToJson(new { value }));
        }

        [TestMethod]
        public void Test8()
        {
            TimeOnly? value = TimeOnly.MaxValue;
            Assert.AreEqual($"[\"{value:HH:mm:ss}\"]", Core.Utility.ToJson(new TimeOnly?[] { value }));
        }

        [TestMethod]
        public void Test9()
        {
            TimeOnly? value = TimeOnly.MaxValue;
            Assert.AreEqual($"[\"{value:HH:mm:ss}\"]", Core.Utility.ToJson(new List<TimeOnly?> { value }));
        }
    }
}
