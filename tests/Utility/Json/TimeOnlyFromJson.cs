using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace Hestia.Core.Tests.Utility.Json
{
    [TestClass]
    [ExcludeFromCodeCoverage]
    public sealed class TimeOnlyFromJson
    {
        public record Model
        {
            public TimeOnly? Value { get; set; }
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
            TimeOnly?[] array = Core.Utility.FromJson<TimeOnly?[]>($"[null]");
            Assert.IsTrue(array.All(x => x == null));
        }

        [TestMethod]
        public void Test3()
        {
            List<TimeOnly?> list = Core.Utility.FromJson<List<TimeOnly?>>($"[null]");
            Assert.IsTrue(list.All(x => x == null));
        }

        [TestMethod]
        public void Test4()
        {
            TimeOnly value = TimeOnly.MinValue;
            Model model = Core.Utility.FromJson<Model>($"{{\"{nameof(Model.Value)}\":\"{value:HH:mm:ss.fffffff}\"}}");
            Assert.AreEqual(value, model.Value);
        }

        [TestMethod]
        public void Test5()
        {
            TimeOnly value = TimeOnly.MinValue;
            TimeOnly[] array = Core.Utility.FromJson<TimeOnly[]>($"[\"{value:HH:mm:ss.fffffff}\"]");
            Assert.IsTrue(array.All(x => x == value));
        }

        [TestMethod]
        public void Test6()
        {
            TimeOnly value = TimeOnly.MinValue;
            List<TimeOnly> list = Core.Utility.FromJson<List<TimeOnly>>($"[\"{value:HH:mm:ss.fffffff}\"]");
            Assert.IsTrue(list.All(x => x == value));
        }

        [TestMethod]
        public void Test7()
        {
            TimeOnly value = TimeOnly.MaxValue;
            Model model = Core.Utility.FromJson<Model>($"{{\"{nameof(Model.Value)}\":\"{value:HH:mm:ss.fffffff}\"}}");
            Assert.AreEqual(value, model.Value);
        }

        [TestMethod]
        public void Test8()
        {
            TimeOnly value = TimeOnly.MaxValue;
            TimeOnly[] array = Core.Utility.FromJson<TimeOnly[]>($"[\"{value:HH:mm:ss.fffffff}\"]");
            Assert.IsTrue(array.All(x => x == value));
        }

        [TestMethod]
        public void Test9()
        {
            TimeOnly value = TimeOnly.MaxValue;
            List<TimeOnly> list = Core.Utility.FromJson<List<TimeOnly>>($"[\"{value:HH:mm:ss.fffffff}\"]");
            Assert.IsTrue(list.All(x => x == value));
        }
    }
}
