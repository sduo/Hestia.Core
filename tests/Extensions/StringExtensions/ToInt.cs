using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Hestia.Core.Tests.Extensions.StringExtensions
{
    [TestClass]
    public sealed class ToInt
    {
        [TestMethod]
        public void Test1()
        {
            Assert.AreEqual(null, string.Empty.ToInt());
        }

        [TestMethod]
        public void Test2()
        {
            Assert.AreEqual(int.MinValue, $"{int.MinValue}".ToInt());
        }

        [TestMethod]
        public void Test3()
        {
            Assert.AreEqual(int.MaxValue, $"{int.MaxValue}".ToInt());
        }

        [TestMethod]
        public void Test4()
        {
            Assert.AreEqual(int.MinValue, $"{int.MinValue:N0}".ToInt());
        }

        [TestMethod]
        public void Test5()
        {
            Assert.AreEqual(int.MaxValue, $"{int.MaxValue:N0}".ToInt());
        }

        [TestMethod]
        public void Test6()
        {
            Assert.AreEqual(int.MinValue, $"{int.MinValue:E9}".ToInt());
        }

        [TestMethod]
        public void Test7()
        {
            Assert.AreEqual(int.MaxValue, $"{int.MaxValue:E9}".ToInt());
        }
    }
}
