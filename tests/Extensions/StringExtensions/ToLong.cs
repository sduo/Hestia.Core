using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Hestia.Core.Tests.Extensions.StringExtensions
{
    [TestClass]
    public sealed class ToLong
    {
        [TestMethod]
        public void Test1()
        {
            Assert.AreEqual(null, string.Empty.ToLong());
        }

        [TestMethod]
        public void Test2()
        {
            Assert.AreEqual(long.MinValue, $"{long.MinValue}".ToLong());
        }

        [TestMethod]
        public void Test3()
        {
            Assert.AreEqual(long.MaxValue, $"{long.MaxValue}".ToLong());
        }

        [TestMethod]
        public void Test4()
        {
            Assert.AreEqual(long.MinValue, $"{long.MinValue:N0}".ToLong());
        }

        [TestMethod]
        public void Test5()
        {
            Assert.AreEqual(long.MaxValue, $"{long.MaxValue:N0}".ToLong());
        }

        [TestMethod]
        public void Test6()
        {
            Assert.AreEqual(long.MinValue, $"{long.MinValue:E19}".ToLong());
        }

        [TestMethod]
        public void Test7()
        {
            Assert.AreEqual(long.MaxValue, $"{long.MaxValue:E19}".ToLong());
        }
    }
}
