using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Hestia.Core.Tests.Extensions.StringExtensions
{
    [TestClass]
    public sealed class ToTimeSpan
    {
        [TestMethod]
        public void Test1()
        {
            Assert.AreEqual(null, string.Empty.ToTimeSpan());
        }

        [TestMethod]
        public void Test2()
        {
            Assert.AreEqual(TimeSpan.Zero, $"{TimeSpan.Zero}".ToTimeSpan());
        }

        [TestMethod]
        public void Test3()
        {
            Assert.AreEqual(TimeSpan.MinValue, $"{TimeSpan.MinValue}".ToTimeSpan());
        }

        [TestMethod]
        public void Test4()
        {
            Assert.AreEqual(TimeSpan.MaxValue, $"{TimeSpan.MaxValue}".ToTimeSpan());
        }
    }
}
