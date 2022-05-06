using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace Hestia.Core.Tests.Utility.Json
{
    [TestClass]
    public sealed class StringFromJson
    {
        public record Model
        {
            public string Value { get; set; }
        }

        [TestMethod]
        public void Test1()
        {
            Model model = Core.Utility.FromJson<Model>($"{{\"{nameof(Model.Value)}\":null}}");
            Assert.AreEqual(null, model.Value);
        }

        [TestMethod]
        public void Test2()
        {
            string[] array = Core.Utility.FromJson<string[]>($"[null]");
            Assert.IsTrue(array.All(x => x == null));
        }
        [TestMethod]
        public void Test3()
        {
            List<string> list = Core.Utility.FromJson<List<string>>($"[null]");
            Assert.IsTrue(list.All(x => x == null));
        }
        [TestMethod]
        public void Test4()
        {
            string value = string.Empty;
            Model model = Core.Utility.FromJson<Model>($"{{\"{nameof(Model.Value)}\":\"{value}\"}}");
            Assert.AreEqual(value, model.Value);
        }
        [TestMethod]
        public void Test5()
        {
            string value = string.Empty;
            string[] array = Core.Utility.FromJson<string[]>($"[\"{value}\"]");
            Assert.IsTrue(array.All(x => x == value));
        }
        [TestMethod]
        public void Test6()
        {
            string value = string.Empty;
            List<string> list = Core.Utility.FromJson<List<string>>($"[\"{value}\"]");
            Assert.IsTrue(list.All(x => x == value));
        }
        [TestMethod]
        public void Test7()
        {
            string value = "中文";
            Model model = Core.Utility.FromJson<Model>($"{{\"{nameof(Model.Value)}\":\"{value}\"}}");
            Assert.AreEqual(value, model.Value);
        }
        [TestMethod]
        public void Test8()
        {
            string value = "中文";
            string[] array = Core.Utility.FromJson<string[]>($"[\"{value}\"]");
            Assert.IsTrue(array.All(x => x == value));
        }
        [TestMethod]
        public void Test9()
        {
            string value = "中文";
            List<string> list = Core.Utility.FromJson<List<string>>($"[\"{value}\"]");
            Assert.IsTrue(list.All(x => x == value));
        }
        [TestMethod]
        public void Test10()
        {
            string value = "ABC";
            Model model = Core.Utility.FromJson<Model>($"{{\"{nameof(Model.Value)}\":\"{value}\"}}");
            Assert.AreEqual(value, model.Value);
        }
        [TestMethod]
        public void Test11()
        {
            string value = "ABC";
            string[] array = Core.Utility.FromJson<string[]>($"[\"{value}\"]");
            Assert.IsTrue(array.All(x => x == value));
        }
        [TestMethod]
        public void Test12()
        {
            string value = "ABC";
            List<string> list = Core.Utility.FromJson<List<string>>($"[\"{value}\"]");
            Assert.IsTrue(list.All(x => x == value));
        }
    }
}
