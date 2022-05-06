using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Hestia.Core.Tests.Utility
{
    [TestClass]
    [ExcludeFromCodeCoverage]
    public sealed class GetEncoding
    {
        [TestMethod]
        public void Test1()
        {
            Assert.AreEqual(Encoding.Default.CodePage, Core.Utility.GetEncoding(0).CodePage);
        }

        [TestMethod]
        public void Test2()
        {
            Assert.AreEqual(Encoding.UTF8.CodePage, Core.Utility.GetEncoding(Encoding.UTF8.CodePage).CodePage);
        }

        [TestMethod]
        public void Test3()
        {
            Assert.AreEqual(Encoding.UTF8.CodePage, Core.Utility.GetEncoding(Encoding.UTF8.WebName).CodePage);
        }

        [TestMethod]
        public void Test4()
        {
            Assert.AreEqual(null, Core.Utility.GetEncoding(null));
        }

        [TestMethod]
        public void Test5()
        {
            Assert.AreEqual(Encoding.UTF8.CodePage, Core.Utility.GetEncoding(string.Empty,Encoding.UTF8).CodePage);
        }

        [TestMethod]
        public void Test6()
        {
            Assert.AreEqual(null, Core.Utility.GetEncoding("abc"));
        }

        [TestMethod]
        public void Test7()
        {
            Assert.AreEqual(null, Core.Utility.GetEncoding(65535));
        }

        [TestMethod]
        public void Test8()
        {
            Assert.AreEqual(null, Core.Utility.GetEncoding(int.MinValue));
        }

        [TestMethod]
        public void Test9()
        {
            Assert.AreEqual(null, Core.Utility.GetEncoding(int.MaxValue));
        }

        
    }
}
