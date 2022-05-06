using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace Hestia.Core.Tests.Utility.Json
{
    [TestClass]
    [ExcludeFromCodeCoverage]
    public sealed class DateTimeOffsetFromJson
    {
        public record Model
        {
            public DateTimeOffset? Value { get; set; }
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
            DateTimeOffset?[] array = Core.Utility.FromJson<DateTimeOffset?[]>($"[null]");
            Assert.IsTrue(array.All(x => x == null));
        }

        [TestMethod]
        public void Test3()
        {
            List<DateTimeOffset?> list = Core.Utility.FromJson<List<DateTimeOffset?>>($"[null]");
            Assert.IsTrue(list.All(x => x == null));
        }

        [TestMethod]
        public void Test4()
        {
            DateTimeOffset value = DateTimeOffset.Now.ToLocalTime();
            Model model = Core.Utility.FromJson<Model>($"{{\"{nameof(Model.Value)}\":\"{value:yyyy-MM-dd HH:mm:ss.fffffff}\"}}");
            Assert.AreEqual(value, model.Value);
        }

        [TestMethod]
        public void Test5()
        {
            DateTimeOffset value = DateTimeOffset.Now.ToLocalTime();
            DateTimeOffset[] array = Core.Utility.FromJson<DateTimeOffset[]>($"[\"{value:yyyy-MM-dd HH:mm:ss.fffffff}\"]");
            Assert.IsTrue(array.All(x => x == value));
        }

        [TestMethod]
        public void Test6()
        {
            DateTimeOffset value = DateTimeOffset.Now.ToLocalTime();
            List<DateTimeOffset> list = Core.Utility.FromJson<List<DateTimeOffset>>($"[\"{value:yyyy-MM-dd HH:mm:ss.fffffff}\"]");
            Assert.IsTrue(list.All(x => x == value));
        }

        [TestMethod]
        public void Test7()
        {
            DateTimeOffset value = DateTimeOffset.MinValue.ToLocalTime();
            Model model = Core.Utility.FromJson<Model>($"{{\"{nameof(Model.Value)}\":\"{value:yyyy-MM-dd HH:mm:ss.fffffff}\"}}");
            Assert.AreEqual(value, model.Value);
        }

        [TestMethod]
        public void Test8()
        {
            DateTimeOffset value = DateTimeOffset.MinValue.ToLocalTime();
            DateTimeOffset[] array = Core.Utility.FromJson<DateTimeOffset[]>($"[\"{value:yyyy-MM-dd HH:mm:ss.fffffff}\"]");
            Assert.IsTrue(array.All(x => x == value));
        }

        [TestMethod]
        public void Test9()
        {
            DateTimeOffset value = DateTimeOffset.MinValue.ToLocalTime();
            List<DateTimeOffset> list = Core.Utility.FromJson<List<DateTimeOffset>>($"[\"{value:yyyy-MM-dd HH:mm:ss.fffffff}\"]");
            Assert.IsTrue(list.All(x => x == value));
        }

        [TestMethod]
        public void Test10()
        {
            DateTimeOffset value = DateTimeOffset.MaxValue.ToLocalTime();
            Model model = Core.Utility.FromJson<Model>($"{{\"{nameof(Model.Value)}\":\"{value:yyyy-MM-dd HH:mm:ss.fffffff}\"}}");
            Assert.AreEqual(value, model.Value);
        }

        [TestMethod]
        public void Test11()
        {
            DateTimeOffset value = DateTimeOffset.MaxValue.ToLocalTime();
            DateTimeOffset[] array = Core.Utility.FromJson<DateTimeOffset[]>($"[\"{value:yyyy-MM-dd HH:mm:ss.fffffff}\"]");
            Assert.IsTrue(array.All(x => x == value));
        }

        [TestMethod]
        public void Test12()
        {
            DateTimeOffset value = DateTimeOffset.MaxValue.ToLocalTime();
            List<DateTimeOffset> list = Core.Utility.FromJson<List<DateTimeOffset>>($"[\"{value:yyyy-MM-dd HH:mm:ss.fffffff}\"]");
            Assert.IsTrue(list.All(x => x == value));
        }
    }
}
