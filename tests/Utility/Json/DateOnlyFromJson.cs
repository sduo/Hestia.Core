using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace Hestia.Core.Tests.Utility.Json
{
    [TestClass]
    [ExcludeFromCodeCoverage]
    public sealed class DateOnlyFromJson
    {
        public record Model
        {
            public DateOnly? Value { get; set; }
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
            DateOnly?[] array = Core.Utility.FromJson<DateOnly?[]>($"[null]");
            Assert.IsTrue(array.All(x => x == null));
        }

        [TestMethod]
        public void Test3()
        {
            List<DateOnly?> list = Core.Utility.FromJson<List<DateOnly?>>($"[null]");
            Assert.IsTrue(list.All(x => x == null));
        }

        [TestMethod]
        public void Test4()
        {
            DateOnly value = DateOnly.MinValue;
            Model model = Core.Utility.FromJson<Model>($"{{\"{nameof(Model.Value)}\":\"{value:yyyy-MM-dd}\"}}");
            Assert.AreEqual(value, model.Value);
        }

        [TestMethod]
        public void Test5()
        {
            DateOnly value = DateOnly.MinValue;
            DateOnly[] array = Core.Utility.FromJson<DateOnly[]>($"[\"{value:yyyy-MM-dd}\"]");
            Assert.IsTrue(array.All(x => x == value));
        }

        [TestMethod]
        public void Test6()
        {
            DateOnly value = DateOnly.MinValue;
            List<DateOnly> list = Core.Utility.FromJson<List<DateOnly>>($"[\"{value:yyyy-MM-dd}\"]");
            Assert.IsTrue(list.All(x => x == value));
        }

        [TestMethod]
        public void Test7()
        {
            DateOnly value = DateOnly.MaxValue;
            Model model = Core.Utility.FromJson<Model>($"{{\"{nameof(Model.Value)}\":\"{value:yyyy-MM-dd}\"}}");
            Assert.AreEqual(value, model.Value);
        }

        [TestMethod]
        public void Test8()
        {
            DateOnly value = DateOnly.MaxValue;
            DateOnly[] array = Core.Utility.FromJson<DateOnly[]>($"[\"{value:yyyy-MM-dd}\"]");
            Assert.IsTrue(array.All(x => x == value));
        }

        [TestMethod]
        public void Test9()
        {
            DateOnly value = DateOnly.MaxValue;
            List<DateOnly> list = Core.Utility.FromJson<List<DateOnly>>($"[\"{value:yyyy-MM-dd}\"]");
            Assert.IsTrue(list.All(x => x == value));
        }
    }
}
