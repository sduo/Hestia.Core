using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Hestia.Core.Tests.Extensions.StringExtensions
{
    [TestClass]
    public sealed class ToEnum
    {
        internal enum Test:int
        {
            Zero=0
        }

        [TestMethod]
        public void Test1()
        {
            Assert.AreEqual(null, string.Empty.ToEnum<Test>());
        }

        [TestMethod]
        public void Test2()
        {
            Assert.AreEqual(Test.Zero, $"{Test.Zero}".ToEnum<Test>());
        }

        [TestMethod]
        public void Test3()
        {
            Assert.AreEqual(Test.Zero, $"{Test.Zero}".ToEnum<Test>());
        }

        [TestMethod]
        public void Test4()
        {
            Assert.AreEqual(Test.Zero, $"{Test.Zero}".ToUpper().ToEnum<Test>());
        }

        [TestMethod]
        public void Test5()
        {
            Assert.AreEqual(Test.Zero, $"{Test.Zero}".ToLower().ToEnum<Test>());
        }

        [TestMethod]
        public void Test6()
        {
            Assert.AreEqual(null, $"{Test.Zero}".ToUpper().ToEnum<Test>(ignoreCase:false));
        }

        [TestMethod]
        public void Test7()
        {
            Assert.AreEqual(null, $"{Test.Zero}".ToLower().ToEnum<Test>(ignoreCase: false));
        }

        [TestMethod]
        public void Test8()
        {
            Assert.AreEqual(null, $"1".ToEnum<Test>());
        }

        [TestMethod]
        public void Test9()
        {
            Assert.AreEqual((Test)1, $"1".ToEnum<Test>(isDefined:false));
        }
    }
}
