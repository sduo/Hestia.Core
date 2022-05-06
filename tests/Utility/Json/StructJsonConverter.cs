using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;

namespace Hestia.Core.Tests.Utility.Json
{
    [TestClass]
    [ExcludeFromCodeCoverage]
    public sealed class StructJsonConverter
    {
        private static readonly JsonSerializerOptions NullOptions;
        private static readonly JsonSerializerOptions InvalidCastOptions;
        private static readonly Core.Json.Converters.StructJsonConverter<DateTime> DateTimeJsonConverter = new(null, null);
        private static readonly Core.Json.Converters.StructJsonConverter<DateTimeOffset> DateTimeOffsetJsonConverter = new(null, null);
        private static readonly Core.Json.Converters.StructJsonConverter<DateOnly> DateOnlyJsonConverter = new(null, null);
        private static readonly Core.Json.Converters.StructJsonConverter<TimeOnly> TimeOnlyJsonConverter = new(null, null);
        private static readonly Core.Json.Converters.StructJsonConverter<TimeSpan> TimeSpanJsonConverter = new(null, null);
        private static readonly Core.Json.Converters.StructJsonConverter<DateTime> InvalidCastJsonConverter = new(x => null, x => null);



        static StructJsonConverter()
        {
            NullOptions = new JsonSerializerOptions();
            NullOptions.Converters.Add(DateTimeJsonConverter);
            NullOptions.Converters.Add(DateTimeOffsetJsonConverter);
            NullOptions.Converters.Add(DateOnlyJsonConverter);
            NullOptions.Converters.Add(TimeOnlyJsonConverter);
            NullOptions.Converters.Add(TimeSpanJsonConverter);
            InvalidCastOptions = new JsonSerializerOptions();
            InvalidCastOptions.Converters.Add(InvalidCastJsonConverter);

        }

        [TestMethod]
        public void Test1()
        {
            Assert.ThrowsException<NotImplementedException>(() =>
            {
                DateTime value = DateTime.Now;
                string json = Core.Utility.ToJson(new DateTime[] { value }, NullOptions);
            });
        }

        [TestMethod]
        public void Test2()
        {
            Assert.ThrowsException<NotImplementedException>(() =>
            {
                DateTime value = DateTime.Now;
                DateTime[] array = Core.Utility.FromJson<DateTime[]>($"[\"{value:yyyy-MM-dd HH:mm:ss.fffffff}\"]", NullOptions);
            });
        }

        [TestMethod]
        public void Test3()
        {
            Assert.ThrowsException<NotImplementedException>(() =>
            {
                DateTimeOffset value = DateTimeOffset.Now.ToLocalTime();
                string json = Core.Utility.ToJson(new DateTimeOffset[] { value }, NullOptions);
            });
        }

        [TestMethod]
        public void Test4()
        {
            Assert.ThrowsException<NotImplementedException>(() =>
            {
                DateTimeOffset value = DateTimeOffset.Now.ToLocalTime();
                DateTimeOffset[] array = Core.Utility.FromJson<DateTimeOffset[]>($"[\"{value:yyyy-MM-dd HH:mm:ss.fffffff}\"]", NullOptions);
            });
        }

        [TestMethod]
        public void Test5()
        {
            Assert.ThrowsException<NotImplementedException>(() =>
            {
                DateOnly value = DateOnly.MaxValue;
                string json = Core.Utility.ToJson(new DateOnly[] { value }, NullOptions);
            });
        }

        [TestMethod]
        public void Test6()
        {
            Assert.ThrowsException<NotImplementedException>(() =>
            {
                DateOnly value = DateOnly.MaxValue;
                DateOnly[] array = Core.Utility.FromJson<DateOnly[]>($"[\"{value:yyyy-MM-dd}\"]", NullOptions);
            });
        }

        [TestMethod]
        public void Test7()
        {
            Assert.ThrowsException<NotImplementedException>(() =>
            {
                TimeOnly value = TimeOnly.MaxValue;
                string json = Core.Utility.ToJson(new TimeOnly[] { value }, NullOptions);
            });
        }

        [TestMethod]
        public void Test8()
        {
            Assert.ThrowsException<NotImplementedException>(() =>
            {
                TimeOnly value = TimeOnly.MaxValue;
                TimeOnly[] array = Core.Utility.FromJson<TimeOnly[]>($"[\"{value:HH:mm:ss.fffffff}\"]", NullOptions);
            });
        }

        [TestMethod]
        public void Test9()
        {
            Assert.ThrowsException<NotImplementedException>(() =>
            {
                TimeSpan value = TimeSpan.MaxValue;
                string json = Core.Utility.ToJson(new TimeSpan[] { value }, NullOptions);
            });
        }

        [TestMethod]
        public void Test10()
        {
            Assert.ThrowsException<NotImplementedException>(() =>
            {
                TimeSpan value = TimeSpan.MaxValue;
                TimeSpan[] array = Core.Utility.FromJson<TimeSpan[]>($"[\"{value:G}\"]", NullOptions);
            });
        }

        [TestMethod]
        public void Test11()
        {
            Assert.ThrowsException<InvalidCastException>(() =>
            {
                DateTime value = DateTime.Now;
                string json = Core.Utility.ToJson(new DateTime[] { value }, InvalidCastOptions);
            });
        }

        [TestMethod]
        public void Test12()
        {
            Assert.ThrowsException<InvalidCastException>(() =>
            {
                DateTime value = DateTime.Now;
                DateTime[] array = Core.Utility.FromJson<DateTime[]>($"[\"{value:yyyy-MM-dd HH:mm:ss.fffffff}\"]", InvalidCastOptions);
            });
        }
    }
}
