using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Hestia.Core.Tests.Utility.Json
{
    [TestClass]
    [ExcludeFromCodeCoverage]
    public sealed class IntToJson
    {
        [TestMethod]
        public void Test1()
        {
            int? value = null;
            Assert.AreEqual($"{{\"{nameof(value)}\":null}}", Core.Utility.ToJson(new { value }));
        }        

        [TestMethod]
        public void Test2()
        {
            int? value = null;
            Assert.AreEqual($"[null]", Core.Utility.ToJson(new int?[] { value }));
        }

        [TestMethod]
        public void Test3()
        {
            int? value = null;
            Assert.AreEqual($"[null]", Core.Utility.ToJson(new List<int?> { value }));
        }

        [TestMethod]
        public void Test4()
        {
            int? value = 123;
            Assert.AreEqual($"{{\"{nameof(value)}\":{value}}}", Core.Utility.ToJson(new { value }));
        }

        [TestMethod]
        public void Test5()
        {
            int? value = 123;
            Assert.AreEqual($"[{value}]", Core.Utility.ToJson(new int?[] { value }));
        }

        [TestMethod]
        public void Test6()
        {
            int? value = 123;
            Assert.AreEqual($"[{value}]", Core.Utility.ToJson(new List<int?> { value }));
        }

        [TestMethod]
        public void Test7()
        {
            int? value = int.MinValue;
            Assert.AreEqual($"{{\"{nameof(value)}\":{value}}}", Core.Utility.ToJson(new { value }));
        }

        [TestMethod]
        public void Test8()
        {
            int? value = int.MinValue;
            Assert.AreEqual($"[{value}]", Core.Utility.ToJson(new int?[] { value }));
        }

        [TestMethod]
        public void Test9()
        {
            int? value = int.MinValue;
            Assert.AreEqual($"[{value}]", Core.Utility.ToJson(new List<int?> { value }));
        }

        [TestMethod]
        public void Test10()
        {
            int? value = int.MaxValue;
            Assert.AreEqual($"{{\"{nameof(value)}\":{value}}}", Core.Utility.ToJson(new { value }));
        }

        [TestMethod]
        public void Test11()
        {
            int? value = int.MaxValue;
            Assert.AreEqual($"[{value}]", Core.Utility.ToJson(new int?[] { value }));
        }

        [TestMethod]
        public void Test12()
        {
            int? value = int.MaxValue;
            Assert.AreEqual($"[{value}]", Core.Utility.ToJson(new List<int?> { value }));
        }
    }
}
