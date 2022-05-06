using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace Hestia.Core.Tests.Utility.Json
{
    [TestClass]
    [ExcludeFromCodeCoverage]
    public sealed class IntFromJson
    {
        public record Model
        {
            public int? Value { get; set; }
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
            int?[] array = Core.Utility.FromJson<int?[]>($"[null]");
            Assert.IsTrue(array.All(x => x == null));
        }

        [TestMethod]
        public void Test3()
        {
            List<int?> list = Core.Utility.FromJson<List<int?>>($"[null]");
            Assert.IsTrue(list.All(x => x == null));
        }

        [TestMethod]
        public void Test4()
        {
            int value = 123;
            Model model = Core.Utility.FromJson<Model>($"{{\"{nameof(Model.Value)}\":{value}}}");
            Assert.AreEqual(value, model.Value);
        }

        [TestMethod]
        public void Test5()
        {
            int value = 123;
            int[] array = Core.Utility.FromJson<int[]>($"[{value}]");
            Assert.IsTrue(array.All(x => x == value));
        }

        [TestMethod]
        public void Test6()
        {
            int value = 123;
            List<int> list = Core.Utility.FromJson<List<int>>($"[{value}]");
            Assert.IsTrue(list.All(x => x == value));
        }

        [TestMethod]
        public void Test7()
        {
            int value = int.MinValue;
            Model model = Core.Utility.FromJson<Model>($"{{\"{nameof(Model.Value)}\":{value}}}");
            Assert.AreEqual(value, model.Value);
        }

        [TestMethod]
        public void Test8()
        {
            int value = int.MinValue;
            int[] array = Core.Utility.FromJson<int[]>($"[{value}]");
            Assert.IsTrue(array.All(x => x == value));
        }

        [TestMethod]
        public void Test9()
        {
            int value = int.MinValue;
            List<int> list = Core.Utility.FromJson<List<int>>($"[{value}]");
            Assert.IsTrue(list.All(x => x == value));
        }

        [TestMethod]
        public void Test10()
        {
            int value = int.MaxValue;
            Model model = Core.Utility.FromJson<Model>($"{{\"{nameof(Model.Value)}\":{value}}}");
            Assert.AreEqual(value, model.Value);
        }

        [TestMethod]
        public void Test11()
        {
            int value = int.MaxValue;
            int[] array = Core.Utility.FromJson<int[]>($"[{value}]");
            Assert.IsTrue(array.All(x => x == value));
        }

        [TestMethod]
        public void Test12()
        {
            int value = int.MaxValue;
            List<int> list = Core.Utility.FromJson<List<int>>($"[{value}]");
            Assert.IsTrue(list.All(x => x == value));
        }
    }
}
