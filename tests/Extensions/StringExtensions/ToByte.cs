using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics.CodeAnalysis;

namespace Hestia.Core.Tests.Extensions.StringExtensions
{
    [TestClass]
    [ExcludeFromCodeCoverage]
    public sealed class ToByte
    {
        [TestMethod]
        public void Test1()
        {
            Assert.AreEqual(null, string.Empty.ToByte());
        }

        [TestMethod]
        public void Test2()
        {
            Assert.AreEqual(byte.MinValue, $"{byte.MinValue}".ToByte());
        }

        [TestMethod]
        public void Test3()
        {
            Assert.AreEqual(byte.MaxValue, $"{byte.MaxValue}".ToByte());
        }

        [TestMethod]
        public void Test4()
        {
            Assert.AreEqual(byte.MinValue, $"{byte.MinValue:x2}".ToByte(hex:true));
        }

        [TestMethod]
        public void Test5()
        {
            Assert.AreEqual(byte.MinValue, $"{byte.MinValue:X2}".ToByte(hex: true));
        }

        [TestMethod]
        public void Test6()
        {
            Assert.AreEqual(byte.MaxValue, $"{byte.MaxValue:x2}".ToByte(hex: true));
        }

        [TestMethod]
        public void Test7()
        {
            Assert.AreEqual(byte.MaxValue, $"{byte.MaxValue:X2}".ToByte(hex: true));
        }
    }
}