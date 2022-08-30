using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Hestia.Core.Tests.Utility.String
{
    [TestClass]
    [ExcludeFromCodeCoverage]
    public sealed class Transform
    {
        const string Source = "Hestia.Core";
        static readonly Func<string, byte[]> decoder = Encoding.UTF8.GetBytes;
        static readonly Func<byte[], string> encoder = Encoding.UTF8.GetString;


        [TestMethod]
        public void Test1()
        {
            Assert.AreEqual(Source, Core.Utility.Transform(Source, decoder, encoder));
        }

        [TestMethod]
        public void Test2()
        {
            Assert.AreEqual(string.Empty, Core.Utility.Transform(string.Empty, decoder, encoder));
        }

        [TestMethod]
        public void Test3()
        {
            Assert.AreEqual(null, Core.Utility.Transform(null, decoder, encoder));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Test4()
        {
            Core.Utility.Transform(Source, null, encoder);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Test5()
        {
            Core.Utility.Transform(Source, decoder, null);
        }
    }
}
