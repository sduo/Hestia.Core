using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics.CodeAnalysis;

namespace Hestia.Core.Tests.Extensions.StringExtensions
{
    [TestClass]
    [ExcludeFromCodeCoverage]
    public sealed class ToDecimal
    {
        [TestMethod]
        public void Test1()
        {
            Assert.AreEqual(null, string.Empty.ToDecimal());
        }

        [TestMethod]
        public void Test2()
        {
            Assert.AreEqual(decimal.Zero, $"{decimal.Zero}".ToDecimal());
        }

        [TestMethod]
        public void Test3()
        {            
            Assert.AreEqual(decimal.MinValue, $"{decimal.MinValue}".ToDecimal());
        }

        [TestMethod]
        public void Test4()
        {
            Assert.AreEqual(decimal.MaxValue, $"{decimal.MaxValue}".ToDecimal());
        }

        [TestMethod]
        public void Test5()
        {
            Assert.AreEqual(decimal.One, $"{decimal.One}".ToDecimal());
        }

        [TestMethod]
        public void Test6()
        {
            Assert.AreEqual(decimal.MinusOne, $"{decimal.MinusOne}".ToDecimal());
        }

        [TestMethod]
        public void Test7()
        {
            Assert.AreEqual(decimal.MinValue, $"{decimal.MinValue:N}".ToDecimal());
        }        

        [TestMethod]
        public void Test8()
        {
            Assert.AreEqual(decimal.MaxValue, $"{decimal.MaxValue:N}".ToDecimal());
        }

        [TestMethod]
        public void Test9()
        {
            Assert.AreEqual(decimal.MinValue, $"{decimal.MinValue:E28}".ToDecimal());
        }

        [TestMethod]
        public void Test10()
        {
            Assert.AreEqual(decimal.MaxValue, $"{decimal.MaxValue:E28}".ToDecimal());
        }
    }
}
