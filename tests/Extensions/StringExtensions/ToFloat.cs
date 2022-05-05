using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Hestia.Core.Tests.Extensions.StringExtensions
{
    [TestClass]
    public sealed class ToFloat
    {
        [TestMethod]
        public void Test1()
        {
            Assert.AreEqual(null, string.Empty.ToFloat());
        }

        [TestMethod]
        public void Test2()
        {
            Assert.AreEqual(float.NaN, $"{float.NaN}".ToFloat());
        }

        [TestMethod]
        public void Test3()
        {
            Assert.AreEqual(float.NegativeInfinity, $"{float.NegativeInfinity}".ToFloat());
        }

        [TestMethod]
        public void Test4()
        {
            Assert.AreEqual(float.PositiveInfinity, $"{float.PositiveInfinity}".ToFloat());
        }

        [TestMethod]
        public void Test5()
        {
            Assert.AreEqual(float.Epsilon, $"{float.Epsilon}".ToFloat());
        }

        [TestMethod]
        public void Test6()
        {
            Assert.AreEqual(float.MinValue, $"{float.MinValue}".ToFloat());
        }
        [TestMethod]
        public void Test7()
        {
            Assert.AreEqual(float.MaxValue, $"{float.MaxValue}".ToFloat());
        }

        [TestMethod]
        public void Test8()
        {
            Assert.AreEqual(float.MinValue, $"{float.MinValue:N}".ToFloat());
        }
        [TestMethod]
        public void Test9()
        {
            Assert.AreEqual(float.MaxValue, $"{float.MaxValue:N}".ToFloat());
        }

        [TestMethod]
        public void Test10()
        {
            Assert.AreEqual(float.MinValue, $"{float.MinValue:E38}".ToFloat());
        }
        [TestMethod]
        public void Test11()
        {
            Assert.AreEqual(float.MaxValue, $"{float.MaxValue:E38}".ToFloat());
        }
    }
}
