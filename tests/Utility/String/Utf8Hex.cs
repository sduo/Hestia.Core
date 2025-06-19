using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics.CodeAnalysis;

namespace Hestia.Core.Tests.Utility.String
{
    [TestClass]
    [ExcludeFromCodeCoverage]
    public sealed class Utf8Hex
    {
        const string Source = "Hestia.Core";
        const string Hex = "4865737469612E436F7265";

        [TestMethod]
        public void Test1()
        {
            Assert.AreEqual(Hex, Core.Utility.Utf8HexEncode(Source));
        }

        [TestMethod]
        public void Test2()
        {
            Assert.AreEqual(string.Empty, Core.Utility.Utf8HexEncode(string.Empty));
        }

        [TestMethod]
        public void Test3()
        {
            Assert.AreEqual(null, Core.Utility.Utf8HexEncode(null));
        }

        [TestMethod]
        public void Test4()
        {
            Assert.AreEqual(Source, Core.Utility.Utf8HexDecode(Hex));
        }

        [TestMethod]
        public void Test5()
        {
            Assert.AreEqual(string.Empty, Core.Utility.Utf8HexDecode(string.Empty));
        }

        [TestMethod]
        public void Test6()
        {
            Assert.AreEqual(null, Core.Utility.Utf8HexDecode(null));
        }
    }
}
