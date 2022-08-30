using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hestia.Core.Tests.Utility.String
{
    [TestClass]
    [ExcludeFromCodeCoverage]
    public sealed class Utf8Base64
    {
        const string Source = "Hestia.Core";
        const string Base64 = "SGVzdGlhLkNvcmU=";

        [TestMethod]
        public void Test1()
        {
            Assert.AreEqual(Base64, Core.Utility.Utf8Base64Encode(Source));
        }

        [TestMethod]
        public void Test2()
        {
            Assert.AreEqual(string.Empty, Core.Utility.Utf8Base64Encode(string.Empty));
        }

        [TestMethod]
        public void Test3()
        {
            Assert.AreEqual(null, Core.Utility.Utf8Base64Encode(null));
        }

        [TestMethod]
        public void Test4()
        {
            Assert.AreEqual(Source, Core.Utility.Utf8Base64Decode(Base64));
        }

        [TestMethod]
        public void Test5()
        {
            Assert.AreEqual(string.Empty, Core.Utility.Utf8Base64Decode(string.Empty));
        }

        [TestMethod]
        public void Test6()
        {
            Assert.AreEqual(null, Core.Utility.Utf8Base64Decode(null));
        }
    }
}
