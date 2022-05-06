using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics.CodeAnalysis;

namespace Hestia.Core.Tests.Extensions.StringExtensions
{
    [TestClass]
    [ExcludeFromCodeCoverage]
    public sealed class ToHalf
    {
        [TestMethod]
        public void Test1()
        {
            Assert.AreEqual(null, string.Empty.ToHalf());
        }

        [TestMethod]
        public void Test2()
        {
            Assert.AreEqual(Half.NaN, $"{Half.NaN}".ToHalf());
        }

        [TestMethod]
        public void Test3()
        {
            Assert.AreEqual(Half.NegativeInfinity, $"{Half.NegativeInfinity}".ToHalf());
        }

        [TestMethod]
        public void Test4()
        {
            Assert.AreEqual(Half.PositiveInfinity, $"{Half.PositiveInfinity}".ToHalf());
        }

        [TestMethod]
        public void Test5()
        {
            Assert.AreEqual(Half.Epsilon, $"{Half.Epsilon}".ToHalf());
        }

        [TestMethod]
        public void Test6()
        {
            Assert.AreEqual(Half.MinValue, $"{Half.MinValue}".ToHalf());
        }
        [TestMethod]
        public void Test7()
        {
            Assert.AreEqual(Half.MaxValue, $"{Half.MaxValue}".ToHalf());
        }

        [TestMethod]
        public void Test8()
        {
            Assert.AreEqual(Half.MinValue, $"{Half.MinValue:N}".ToHalf());
        }
        [TestMethod]
        public void Test9()
        {
            Assert.AreEqual(Half.MaxValue, $"{Half.MaxValue:N}".ToHalf());
        }

        [TestMethod]
        public void Test10()
        {
            Assert.AreEqual(Half.MinValue, $"{Half.MinValue:E4}".ToHalf());
        }
        [TestMethod]
        public void Test11()
        {
            Assert.AreEqual(Half.MaxValue, $"{Half.MaxValue:E4}".ToHalf());
        }
    }
}
