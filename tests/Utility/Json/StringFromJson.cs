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
            public string Text { get; set; }
        }

        [TestMethod]
        public void Test1()
        {
            Model model = Core.Utility.FromJson<Model>($"{{\"{nameof(Model.Text)}\":null}}");
            Assert.AreEqual(null, model.Text);
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
            string text = string.Empty;
            Model model = Core.Utility.FromJson<Model>($"{{\"{nameof(Model.Text)}\":\"{text}\"}}");
            Assert.AreEqual(text, model.Text);
        }
        [TestMethod]
        public void Test5()
        {
            string text = string.Empty;
            string[] array = Core.Utility.FromJson<string[]>($"[\"{text}\"]");
            Assert.IsTrue(array.All(x => x == text));
        }
        [TestMethod]
        public void Test6()
        {
            string text = string.Empty;
            List<string> list = Core.Utility.FromJson<List<string>>($"[\"{text}\"]");
            Assert.IsTrue(list.All(x => x == text));
        }
        [TestMethod]
        public void Test7()
        {
            string text = "中文";
            Model model = Core.Utility.FromJson<Model>($"{{\"{nameof(Model.Text)}\":\"{text}\"}}");
            Assert.AreEqual(text, model.Text);
        }
        [TestMethod]
        public void Test8()
        {
            string text = "中文";
            string[] array = Core.Utility.FromJson<string[]>($"[\"{text}\"]");
            Assert.IsTrue(array.All(x => x == text));
        }
        [TestMethod]
        public void Test9()
        {
            string text = "中文";
            List<string> list = Core.Utility.FromJson<List<string>>($"[\"{text}\"]");
            Assert.IsTrue(list.All(x => x == text));
        }
        [TestMethod]
        public void Test10()
        {
            string text = "ABC";
            Model model = Core.Utility.FromJson<Model>($"{{\"{nameof(Model.Text)}\":\"{text}\"}}");
            Assert.AreEqual(text, model.Text);
        }
        [TestMethod]
        public void Test11()
        {
            string text = "ABC";
            string[] array = Core.Utility.FromJson<string[]>($"[\"{text}\"]");
            Assert.IsTrue(array.All(x => x == text));
        }
        [TestMethod]
        public void Test12()
        {
            string text = "ABC";
            List<string> list = Core.Utility.FromJson<List<string>>($"[\"{text}\"]");
            Assert.IsTrue(list.All(x => x == text));
        }
    }
}
