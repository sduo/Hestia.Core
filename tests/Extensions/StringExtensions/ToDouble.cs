using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Hestia.Core.Tests.Extensions.StringExtensions
{
    [TestClass]
    public sealed class ToDouble
    {
        [TestMethod]
        public void Test1()
        {
            Assert.AreEqual(null, string.Empty.ToDouble());
        }

        [TestMethod]
        public void Test2()
        {
            Assert.AreEqual(double.NaN, $"{double.NaN}".ToDouble());
        }

        [TestMethod]
        public void Test3()
        {
            Assert.AreEqual(double.NegativeInfinity, $"{double.NegativeInfinity}".ToDouble());
        }

        [TestMethod]
        public void Test4()
        {
            Assert.AreEqual(double.PositiveInfinity, $"{double.PositiveInfinity}".ToDouble());
        }

        [TestMethod]
        public void Test5()
        {
            Assert.AreEqual(double.Epsilon, $"{double.Epsilon}".ToDouble());
        }

        [TestMethod]
        public void Test6()
        {
            Assert.AreEqual(double.MinValue, $"{double.MinValue}".ToDouble());
        }
        [TestMethod]
        public void Test7()
        {
            Assert.AreEqual(double.MaxValue, $"{double.MaxValue}".ToDouble());
        }

        [TestMethod]
        public void Test8()
        {
            Assert.AreEqual(double.MinValue, $"{double.MinValue:N}".ToDouble());
        }
        [TestMethod]
        public void Test9()
        {
            Assert.AreEqual(double.MaxValue, $"{double.MaxValue:N}".ToDouble());
        }

        [TestMethod]
        public void Test10()
        {
            Assert.AreEqual(double.MinValue, $"{double.MinValue:E308}".ToDouble());
        }
        [TestMethod]
        public void Test11()
        {
            Assert.AreEqual(double.MaxValue, $"{double.MaxValue:E308}".ToDouble());
        }
    }
}
