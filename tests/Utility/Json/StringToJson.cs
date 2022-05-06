using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Hestia.Core.Tests.Utility.Json
{
    [TestClass]
    [ExcludeFromCodeCoverage]
    public sealed class StringToJson
    {
        [TestMethod]
        public void Test1()
        {
            string value = null;
            Assert.AreEqual($"{{\"{nameof(value)}\":null}}", Core.Utility.ToJson(new { value }));
        }
        [TestMethod]
        public void Test2()
        {
            string value = null;
            Assert.AreEqual($"[null]", Core.Utility.ToJson(new string[] { value }));
        }
        [TestMethod]
        public void Test3()
        {
            string value = null;
            Assert.AreEqual($"[null]", Core.Utility.ToJson(new List<string> { value }));
        }
        [TestMethod]
        public void Test4()
        {
            string value = string.Empty;
            Assert.AreEqual($"{{\"{nameof(value)}\":\"{value}\"}}", Core.Utility.ToJson(new { value }));
        }
        [TestMethod]
        public void Test5()
        {
            string value = string.Empty;
            Assert.AreEqual($"[\"{value}\"]", Core.Utility.ToJson(new string[] { value }));
        }
        [TestMethod]
        public void Test6()
        {
            string value = string.Empty;
            Assert.AreEqual($"[\"{value}\"]", Core.Utility.ToJson(new List<string> { value }));
        }
        [TestMethod]
        public void Test7()
        {
            string value = "中文";
            Assert.AreEqual($"{{\"{nameof(value)}\":\"{value}\"}}", Core.Utility.ToJson(new { value }));
        }
        [TestMethod]
        public void Test8()
        {
            string value = "中文";
            Assert.AreEqual($"[\"{value}\"]", Core.Utility.ToJson(new string[] { value }));
        }
        [TestMethod]
        public void Test9()
        {
            string value = "中文";
            Assert.AreEqual($"[\"{value}\"]", Core.Utility.ToJson(new List<string> { value }));
        }
        [TestMethod]
        public void Test10()
        {
            string value = "ABC";
            Assert.AreEqual($"{{\"{nameof(value)}\":\"{value}\"}}", Core.Utility.ToJson(new { value }));
        }
        [TestMethod]
        public void Test11()
        {
            string value = "ABC";
            Assert.AreEqual($"[\"{value}\"]", Core.Utility.ToJson(new string[] { value }));
        }
        [TestMethod]
        public void Test12()
        {
            string value = "ABC";
            Assert.AreEqual($"[\"{value}\"]", Core.Utility.ToJson(new List<string> { value }));
        }
    }
}
