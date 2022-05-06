using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace Hestia.Core.Tests.Utility.Json
{
    [TestClass]
    public sealed class IntFromJson
    {
        public record Model
        {
            public int? Number { get; set; }
        }

        [TestMethod]
        public void Test1()
        {
            Model model = Core.Utility.FromJson<Model>($"{{\"{nameof(Model.Number)}\":null}}");
            Assert.AreEqual(null, model.Number);
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
            int? number = 123;
            Model model = Core.Utility.FromJson<Model>($"{{\"{nameof(Model.Number)}\":{number}}}");
            Assert.AreEqual(number, model.Number);
        }

        [TestMethod]
        public void Test5()
        {
            int? number = 123;
            int?[] array = Core.Utility.FromJson<int?[]>($"[{number}]");
            Assert.IsTrue(array.All(x => x == number));
        }

        [TestMethod]
        public void Test6()
        {
            int? number = 123;
            List<int?> list = Core.Utility.FromJson<List<int?>>($"[{number}]");
            Assert.IsTrue(list.All(x => x == number));
        }

        [TestMethod]
        public void Test7()
        {
            int? number = int.MinValue;
            Model model = Core.Utility.FromJson<Model>($"{{\"{nameof(Model.Number)}\":{number}}}");
            Assert.AreEqual(number, model.Number);
        }

        [TestMethod]
        public void Test8()
        {
            int? number = int.MinValue;
            int?[] array = Core.Utility.FromJson<int?[]>($"[{number}]");
            Assert.IsTrue(array.All(x => x == number));
        }

        [TestMethod]
        public void Test9()
        {
            int? number = int.MinValue;
            List<int?> list = Core.Utility.FromJson<List<int?>>($"[{number}]");
            Assert.IsTrue(list.All(x => x == number));
        }

        [TestMethod]
        public void Test10()
        {
            int? number = int.MaxValue;
            Model model = Core.Utility.FromJson<Model>($"{{\"{nameof(Model.Number)}\":{number}}}");
            Assert.AreEqual(number, model.Number);
        }

        [TestMethod]
        public void Test11()
        {
            int? number = int.MaxValue;
            int?[] array = Core.Utility.FromJson<int?[]>($"[{number}]");
            Assert.IsTrue(array.All(x => x == number));
        }

        [TestMethod]
        public void Test12()
        {
            int? number = int.MaxValue;
            List<int?> list = Core.Utility.FromJson<List<int?>>($"[{number}]");
            Assert.IsTrue(list.All(x => x == number));
        }
    }
}
