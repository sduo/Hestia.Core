using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics.CodeAnalysis;

namespace Hestia.Core.Tests.Extensions.StringExtensions
{
    [TestClass]
    [ExcludeFromCodeCoverage]
    public sealed class ToUnsignedLong
    {
        [TestMethod]
        public void Test1()
        {
            Assert.AreEqual(null, string.Empty.ToUnsignedLong());
        }

        [TestMethod]
        public void Test2()
        {
            Assert.AreEqual(ulong.MinValue, $"{ulong.MinValue}".ToUnsignedLong());
        }

        [TestMethod]
        public void Test3()
        {
            Assert.AreEqual(ulong.MaxValue, $"{ulong.MaxValue}".ToUnsignedLong());
        }

        [TestMethod]
        public void Test4()
        {
            Assert.AreEqual(ulong.MinValue, $"{ulong.MinValue:N0}".ToUnsignedLong());
        }

        [TestMethod]
        public void Test5()
        {
            Assert.AreEqual(ulong.MaxValue, $"{ulong.MaxValue:N0}".ToUnsignedLong());
        }

        [TestMethod]
        public void Test6()
        {
            Assert.AreEqual(ulong.MinValue, $"{ulong.MinValue:E19}".ToUnsignedLong());
        }

        [TestMethod]
        public void Test7()
        {
            Assert.AreEqual(ulong.MaxValue, $"{ulong.MaxValue:E19}".ToUnsignedLong());
        }
    }
}
