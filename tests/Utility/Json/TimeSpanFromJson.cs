using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Hestia.Core.Tests.Utility.Json
{
    [TestClass]
    public sealed class TimeSpanFromJson
    {
        public record Model
        {
            public TimeSpan? Value { get; set; }
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
            TimeSpan?[] array = Core.Utility.FromJson<TimeSpan?[]>($"[null]");
            Assert.IsTrue(array.All(x => x == null));
        }

        [TestMethod]
        public void Test3()
        {
            List<TimeSpan?> list = Core.Utility.FromJson<List<TimeSpan?>>($"[null]");
            Assert.IsTrue(list.All(x => x == null));
        }

        [TestMethod]
        public void Test4()
        {
            TimeSpan? value = TimeSpan.MinValue;
            Model model = Core.Utility.FromJson<Model>($"{{\"{nameof(Model.Value)}\":\"{value:G}\"}}");
            Assert.AreEqual(value, model.Value);
        }

        [TestMethod]
        public void Test5()
        {
            TimeSpan? value = TimeSpan.MinValue;
            TimeSpan?[] array = Core.Utility.FromJson<TimeSpan?[]>($"[\"{value:G}\"]");
            Assert.IsTrue(array.All(x => x == value));
        }

        [TestMethod]
        public void Test6()
        {
            TimeSpan? value = TimeSpan.MinValue;
            List<TimeSpan?> list = Core.Utility.FromJson<List<TimeSpan?>>($"[\"{value:G}\"]");
            Assert.IsTrue(list.All(x => x == value));
        }

        [TestMethod]
        public void Test7()
        {
            TimeSpan? value = TimeSpan.MaxValue;
            Model model = Core.Utility.FromJson<Model>($"{{\"{nameof(Model.Value)}\":\"{value:G}\"}}");
            Assert.AreEqual(value, model.Value);
        }

        [TestMethod]
        public void Test8()
        {
            TimeSpan? value = TimeSpan.MaxValue;
            TimeSpan?[] array = Core.Utility.FromJson<TimeSpan?[]>($"[\"{value:G}\"]");
            Assert.IsTrue(array.All(x => x == value));
        }

        [TestMethod]
        public void Test9()
        {
            TimeSpan? value = TimeSpan.MaxValue;
            List<TimeSpan?> list = Core.Utility.FromJson<List<TimeSpan?>>($"[\"{value:G}\"]");
            Assert.IsTrue(list.All(x => x == value));
        }
    }
}
