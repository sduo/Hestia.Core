using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Hestia.Core.Tests.Extensions.StringExtensions
{
    [TestClass]
    public sealed class ToBoolean
    {
        [TestMethod]
        public void Test1()
        {
            Assert.AreEqual(null, string.Empty.ToBoolean());
        }

        [TestMethod]
        public void Test2()
        {
            Assert.AreEqual(true, "True".ToBoolean());
        }

        [TestMethod]
        public void Test3()
        {
            Assert.AreEqual(true, "true".ToBoolean());
        }

        [TestMethod]
        public void Test4()
        {
            Assert.AreEqual(true, "TRUE".ToBoolean());
        }

        [TestMethod]
        public void Test5()
        {
            Assert.AreEqual(false, "False".ToBoolean());
        }

        [TestMethod]
        public void Test6()
        {
            Assert.AreEqual(false, "false".ToBoolean());
        }

        [TestMethod]
        public void Test7()
        {
            Assert.AreEqual(false, "FALSE".ToBoolean());
        }
    }
}