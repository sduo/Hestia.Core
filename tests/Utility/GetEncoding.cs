using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text;

namespace Hestia.Core.Tests.Utility
{
    [TestClass]
    public sealed class GetEncoding
    {
        [TestMethod]
        public void Test1()
        {
            Assert.AreEqual(Encoding.UTF8.CodePage, Core.Utility.GetEncoding(Encoding.UTF8.CodePage).CodePage);
        }

        [TestMethod]
        public void Test2()
        {
            Assert.AreEqual(Encoding.UTF8.CodePage, Core.Utility.GetEncoding(Encoding.UTF8.WebName).CodePage);
        }

        [TestMethod]
        public void Test3()
        {
            Assert.AreEqual(null,Core.Utility.GetEncoding("gb"));
        }        

        [TestMethod]
        public void Test4()
        {
            Assert.AreEqual(null, Core.Utility.GetEncoding(int.MinValue));
        }

        [TestMethod]
        public void Test5()
        {
            Assert.AreEqual(null, Core.Utility.GetEncoding(int.MaxValue));
        }

        [TestMethod]
        public void Test6()
        {
            Assert.AreEqual(null, Core.Utility.GetEncoding(65535));
        }
    }
}
