using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics.CodeAnalysis;

namespace Hestia.Core.Tests.Extensions.StringExtensions
{
    [TestClass]
    [ExcludeFromCodeCoverage]
    public sealed class ToUnsignedInt
    {
        [TestMethod]
        public void Test1()
        {
            Assert.AreEqual(null, string.Empty.ToUnsignedInt());
        }

        [TestMethod]
        public void Test2()
        {
            Assert.AreEqual(uint.MinValue, $"{uint.MinValue}".ToUnsignedInt());
        }

        [TestMethod]
        public void Test3()
        {
            Assert.AreEqual(uint.MaxValue, $"{uint.MaxValue}".ToUnsignedInt());
        }
        [TestMethod]
        public void Test4()
        {
            Assert.AreEqual(uint.MinValue, $"{uint.MinValue:N0}".ToUnsignedInt());
        }

        [TestMethod]
        public void Test5()
        {
            Assert.AreEqual(uint.MaxValue, $"{uint.MaxValue:N0}".ToUnsignedInt());
        }

        [TestMethod]
        public void Test6()
        {
            Assert.AreEqual(uint.MinValue, $"{uint.MinValue:E9}".ToUnsignedInt());
        }

        [TestMethod]
        public void Test7()
        {
            Assert.AreEqual(uint.MaxValue, $"{uint.MaxValue:E9}".ToUnsignedInt());
        }
    }
}
