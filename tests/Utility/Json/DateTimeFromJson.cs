using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Hestia.Core.Tests.Utility.Json
{
    [TestClass]
    public sealed class DateTimeFromJson
    {
        public record Model
        {
            public DateTime? Value { get; set; }
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
            DateTime?[] array = Core.Utility.FromJson<DateTime?[]>($"[null]");
            Assert.IsTrue(array.All(x => x == null));
        }

        [TestMethod]
        public void Test3()
        {
            List<DateTime?> list = Core.Utility.FromJson<List<DateTime?>>($"[null]");
            Assert.IsTrue(list.All(x => x == null));
        }

        [TestMethod]
        public void Test4()
        {
            DateTime? value = DateTime.Now;
            Model model = Core.Utility.FromJson<Model>($"{{\"{nameof(Model.Value)}\":\"{value:yyyy-MM-dd HH:mm:ss.fffffff}\"}}");
            Assert.AreEqual(value, model.Value);
        }

        [TestMethod]
        public void Test5()
        {
            DateTime? value = DateTime.Now;
            DateTime?[] array = Core.Utility.FromJson<DateTime?[]>($"[\"{value:yyyy-MM-dd HH:mm:ss.fffffff}\"]");
            Assert.IsTrue(array.All(x => x == value));
        }

        [TestMethod]
        public void Test6()
        {
            DateTime? value = DateTime.Now;
            List<DateTime?> list = Core.Utility.FromJson<List<DateTime?>>($"[\"{value:yyyy-MM-dd HH:mm:ss.fffffff}\"]");
            Assert.IsTrue(list.All(x => x == value));
        }

        [TestMethod]
        public void Test7()
        {
            DateTime? value = DateTime.MinValue;
            Model model = Core.Utility.FromJson<Model>($"{{\"{nameof(Model.Value)}\":\"{value:yyyy-MM-dd HH:mm:ss.fffffff}\"}}");
            Assert.AreEqual(value, model.Value);
        }

        [TestMethod]
        public void Test8()
        {
            DateTime? value = DateTime.MinValue;
            DateTime?[] array = Core.Utility.FromJson<DateTime?[]>($"[\"{value:yyyy-MM-dd HH:mm:ss.fffffff}\"]");
            Assert.IsTrue(array.All(x => x == value));
        }

        [TestMethod]
        public void Test9()
        {
            DateTime? value = DateTime.MinValue;
            List<DateTime?> list = Core.Utility.FromJson<List<DateTime?>>($"[\"{value:yyyy-MM-dd HH:mm:ss.fffffff}\"]");
            Assert.IsTrue(list.All(x => x == value));
        }

        [TestMethod]
        public void Test10()
        {
            DateTime? value = DateTime.MaxValue;
            Model model = Core.Utility.FromJson<Model>($"{{\"{nameof(Model.Value)}\":\"{value:yyyy-MM-dd HH:mm:ss.fffffff}\"}}");
            Assert.AreEqual(value, model.Value);
        }

        [TestMethod]
        public void Test11()
        {
            DateTime? value = DateTime.MaxValue;
            DateTime?[] array = Core.Utility.FromJson<DateTime?[]>($"[\"{value:yyyy-MM-dd HH:mm:ss.fffffff}\"]");
            Assert.IsTrue(array.All(x => x == value));
        }

        [TestMethod]
        public void Test12()
        {
            DateTime? value = DateTime.MaxValue;
            List<DateTime?> list = Core.Utility.FromJson<List<DateTime?>>($"[\"{value:yyyy-MM-dd HH:mm:ss.fffffff}\"]");
            Assert.IsTrue(list.All(x => x == value));
        }
    }
}
