using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Hestia.Core.Tests.Utility.Json
{
    [TestClass]
    public sealed class IntToJson
    {
        [TestMethod]
        public void Test1()
        {
            int? number = null;
            Assert.AreEqual($"{{\"{nameof(number)}\":null}}", Core.Utility.ToJson(new { number }));
        }        

        [TestMethod]
        public void Test2()
        {
            int? number = null;
            Assert.AreEqual($"[null]", Core.Utility.ToJson(new int?[] { number }));
        }

        [TestMethod]
        public void Test3()
        {
            int? number = null;
            Assert.AreEqual($"[null]", Core.Utility.ToJson(new List<int?> { number }));
        }

        [TestMethod]
        public void Test4()
        {
            int? number = 123;
            Assert.AreEqual($"{{\"{nameof(number)}\":{number}}}", Core.Utility.ToJson(new { number }));
        }

        [TestMethod]
        public void Test5()
        {
            int? number = 123;
            Assert.AreEqual($"[{number}]", Core.Utility.ToJson(new int?[] { number }));
        }

        [TestMethod]
        public void Test6()
        {
            int? number = 123;
            Assert.AreEqual($"[{number}]", Core.Utility.ToJson(new List<int?> { number }));
        }

        [TestMethod]
        public void Test7()
        {
            int? number = int.MinValue;
            Assert.AreEqual($"{{\"{nameof(number)}\":{number}}}", Core.Utility.ToJson(new { number }));
        }

        [TestMethod]
        public void Test8()
        {
            int? number = int.MinValue;
            Assert.AreEqual($"[{number}]", Core.Utility.ToJson(new int?[] { number }));
        }

        [TestMethod]
        public void Test9()
        {
            int? number = int.MinValue;
            Assert.AreEqual($"[{number}]", Core.Utility.ToJson(new List<int?> { number }));
        }

        [TestMethod]
        public void Test10()
        {
            int? number = int.MaxValue;
            Assert.AreEqual($"{{\"{nameof(number)}\":{number}}}", Core.Utility.ToJson(new { number }));
        }

        [TestMethod]
        public void Test11()
        {
            int? number = int.MaxValue;
            Assert.AreEqual($"[{number}]", Core.Utility.ToJson(new int?[] { number }));
        }

        [TestMethod]
        public void Test12()
        {
            int? number = int.MaxValue;
            Assert.AreEqual($"[{number}]", Core.Utility.ToJson(new List<int?> { number }));
        }
    }
}
