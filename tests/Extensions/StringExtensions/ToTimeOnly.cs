using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics.CodeAnalysis;

namespace Hestia.Core.Tests.Extensions.StringExtensions
{
    [TestClass]
    [ExcludeFromCodeCoverage]
    public sealed class ToTimeOnly
    {
        [TestMethod]
        public void Test1()
        {
            Assert.AreEqual(null, string.Empty.ToTimeOnly());
        }

        [TestMethod]
        public void Test2()
        {
            Assert.AreEqual(TimeOnly.MinValue, $"{TimeOnly.MinValue:HHmmss}".ToTimeOnly());
        }

        [TestMethod]
        public void Test3()
        {
            Assert.AreEqual(TimeOnly.MinValue, $"{TimeOnly.MinValue:HH:mm:ss}".ToTimeOnly());
        }

        [TestMethod]
        public void Test4()
        {
            Assert.AreEqual(TimeOnly.MaxValue, $"{TimeOnly.MaxValue:HHmmssfffffff}".ToTimeOnly());
        }

        [TestMethod]
        public void Test5()
        {
            Assert.AreEqual(TimeOnly.MaxValue, $"{TimeOnly.MaxValue:HH:mm:ss.fffffff}".ToTimeOnly());
        }
    }
}
