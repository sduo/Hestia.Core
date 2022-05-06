using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics.CodeAnalysis;

namespace Hestia.Core.Tests.Extensions.StringExtensions
{
    [TestClass]
    [ExcludeFromCodeCoverage]
    public sealed class ToUnsignedShort
    {
        [TestMethod]
        public void Test1()
        {
            Assert.AreEqual(null, string.Empty.ToUnsignedShort());
        }

        [TestMethod]
        public void Test2()
        {
            Assert.AreEqual(ushort.MinValue, $"{ushort.MinValue}".ToUnsignedShort());
        }

        [TestMethod]
        public void Test3()
        {            
            Assert.AreEqual(ushort.MaxValue, $"{ushort.MaxValue}".ToUnsignedShort());
        }

        [TestMethod]
        public void Test4()
        {
            Assert.AreEqual(ushort.MinValue, $"{ushort.MinValue:N0}".ToUnsignedShort());
        }

        [TestMethod]
        public void Test5()
        {
            Assert.AreEqual(ushort.MaxValue, $"{ushort.MaxValue:N0}".ToUnsignedShort());
        }

        [TestMethod]
        public void Test6()
        {
            Assert.AreEqual(ushort.MinValue, $"{ushort.MinValue:E4}".ToUnsignedShort());
        }

        [TestMethod]
        public void Test7()
        {
            Assert.AreEqual(ushort.MaxValue, $"{ushort.MaxValue:E4}".ToUnsignedShort());
        }
    }
}
