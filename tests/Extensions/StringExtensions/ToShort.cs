using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Hestia.Core.Tests.Extensions.StringExtensions
{
    [TestClass]
    public sealed class ToShort
    {
        [TestMethod]
        public void Test1()
        {
            Assert.AreEqual(null, string.Empty.ToShort());
        }

        [TestMethod]
        public void Test2()
        {
            Assert.AreEqual(short.MinValue, $"{short.MinValue}".ToShort());
        }

        [TestMethod]
        public void Test3()
        {
            Assert.AreEqual(short.MaxValue, $"{short.MaxValue}".ToShort());
        }

        [TestMethod]
        public void Test4()
        {
            Assert.AreEqual(short.MinValue, $"{short.MinValue:N0}".ToShort());
        }

        [TestMethod]
        public void Test5()
        {
            Assert.AreEqual(short.MaxValue, $"{short.MaxValue:N0}".ToShort());
        }

        [TestMethod]
        public void Test6()
        {
            Assert.AreEqual(short.MinValue, $"{short.MinValue:E4}".ToShort());
        }

        [TestMethod]
        public void Test7()
        {
            Assert.AreEqual(short.MaxValue, $"{short.MaxValue:E4}".ToShort());
        }
    }
}
