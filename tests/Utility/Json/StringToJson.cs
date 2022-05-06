using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Hestia.Core.Tests.Utility.Json
{
    [TestClass]
    public sealed class StringToJson
    {
        [TestMethod]
        public void Test1()
        {
            string text = null;
            Assert.AreEqual($"{{\"{nameof(text)}\":null}}", Core.Utility.ToJson(new { text }));
        }
        [TestMethod]
        public void Test2()
        {
            string text = null;
            Assert.AreEqual($"[null]", Core.Utility.ToJson(new string[] { text }));
        }
        [TestMethod]
        public void Test3()
        {
            string text = null;
            Assert.AreEqual($"[null]", Core.Utility.ToJson(new List<string> { text }));
        }
        [TestMethod]
        public void Test4()
        {
            string text = string.Empty;
            Assert.AreEqual($"{{\"{nameof(text)}\":\"{text}\"}}", Core.Utility.ToJson(new { text }));
        }
        [TestMethod]
        public void Test5()
        {
            string text = string.Empty;
            Assert.AreEqual($"[\"{text}\"]", Core.Utility.ToJson(new string[] { text }));
        }
        [TestMethod]
        public void Test6()
        {
            string text = string.Empty;
            Assert.AreEqual($"[\"{text}\"]", Core.Utility.ToJson(new List<string> { text }));
        }
        [TestMethod]
        public void Test7()
        {
            string text = "中文";
            Assert.AreEqual($"{{\"{nameof(text)}\":\"{text}\"}}", Core.Utility.ToJson(new { text }));
        }
        [TestMethod]
        public void Test8()
        {
            string text = "中文";
            Assert.AreEqual($"[\"{text}\"]", Core.Utility.ToJson(new string[] { text }));
        }
        [TestMethod]
        public void Test9()
        {
            string text = "中文";
            Assert.AreEqual($"[\"{text}\"]", Core.Utility.ToJson(new List<string> { text }));
        }
        [TestMethod]
        public void Test10()
        {
            string text = "ABC";
            Assert.AreEqual($"{{\"{nameof(text)}\":\"{text}\"}}", Core.Utility.ToJson(new { text }));
        }
        [TestMethod]
        public void Test11()
        {
            string text = "ABC";
            Assert.AreEqual($"[\"{text}\"]", Core.Utility.ToJson(new string[] { text }));
        }
        [TestMethod]
        public void Test12()
        {
            string text = "ABC";
            Assert.AreEqual($"[\"{text}\"]", Core.Utility.ToJson(new List<string> { text }));
        }
    }
}
