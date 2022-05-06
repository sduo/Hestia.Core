using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Hestia.Core.Tests.Utility
{
    [TestClass]
    [ExcludeFromCodeCoverage]
    public sealed class RegisterProvider
    {
        static RegisterProvider()
        {
            Core.Utility.RegisterProvider();
        }

        [TestMethod]
        public void Test1()
        {            
            Assert.AreEqual(936, Encoding.GetEncoding(936).CodePage);
        }

        [TestMethod]
        public void Test2()
        {
            Assert.AreEqual(932, Encoding.GetEncoding(932).CodePage);
        }
    }
}
