using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics.CodeAnalysis;

namespace Hestia.Core.Tests.Extensions.StringExtensions
{
    [TestClass]
    [ExcludeFromCodeCoverage]
    public sealed class ToSignedByte
    {
        [TestMethod]
        public void Test1()
        {
            Assert.AreEqual(null, string.Empty.ToSignedByte());
        }

        [TestMethod]
        public void Test2()
        {
            Assert.AreEqual(sbyte.MinValue, $"{sbyte.MinValue}".ToSignedByte());
        }

        [TestMethod]
        public void Test3()
        {
            Assert.AreEqual(sbyte.MaxValue, $"{sbyte.MaxValue}".ToSignedByte());
        }
    }
}
