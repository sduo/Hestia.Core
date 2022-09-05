using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Hestia.Core.Tests.Extensions.GenericExtensions
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
            Assert.AreEqual(Source, Source.Transform(decoder).Transform(encoder));
        }

        [TestMethod]
        public void Test2()
        {
            Assert.AreEqual(string.Empty, string.Empty.Transform(decoder).Transform(encoder));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Test3()
        {
            string source = null;
            source.Transform(decoder);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Test4()
        {
            byte[] source = null;
            source.Transform(encoder);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Test5()
        {
            Source.Transform<string, string>(null);
        }
    }
}
