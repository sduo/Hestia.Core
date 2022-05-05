using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Hestia.Core.Tests.Extensions.StringExtensions
{
    [TestClass]
    public sealed class ToDateOnly
    {
        [TestMethod]
        public void Test1()
        {
            Assert.AreEqual(null, string.Empty.ToDateOnly());
        }

        [TestMethod]
        public void Test2()
        {
            Assert.AreEqual(DateOnly.MinValue, $"{DateOnly.MinValue:yyyyMMdd}".ToDateOnly());
        }

        [TestMethod]
        public void Test3()
        {
            Assert.AreEqual(DateOnly.MinValue, $"{DateOnly.MinValue:yyyy-MM-dd}".ToDateOnly());
        }

        [TestMethod]
        public void Test4()
        {
            Assert.AreEqual(DateOnly.MaxValue, $"{DateOnly.MaxValue:yyyyMMdd}".ToDateOnly());
        }        

        [TestMethod]
        public void Test5()
        {
            Assert.AreEqual(DateOnly.MaxValue, $"{DateOnly.MaxValue:yyyy-MM-dd}".ToDateOnly());
        }
    }
}
