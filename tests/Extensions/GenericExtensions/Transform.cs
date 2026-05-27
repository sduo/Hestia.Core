using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics.CodeAnalysis;

namespace Hestia.Core.Tests.Extensions.GenericExtensions
{
    [TestClass]
    [ExcludeFromCodeCoverage]
    public sealed class Transform
    {
        const string Source = "Hestia.Core";

        [TestMethod]
        public void Test1()
        {
            Assert.IsNull((null as string)?.Transform<string, string>(null));
        }

        [TestMethod]
        public void Test2()
        {
            Assert.IsNull((null as int?)?.Transform<int,string>(null));
        }

        [TestMethod]
        public void Test3()
        {
            Assert.IsNull(Source.Transform<string, string>(null));
        }

        [TestMethod]
        public void Test4()
        {
            Assert.IsNull(Source.Length.Transform<int, string>(null));
        }

        [TestMethod]
        public void Test5()
        {
            Assert.AreEqual(Source,Source.Transform(x=>x));
        }

        [TestMethod]
        public void Test6()
        {
            Assert.AreEqual(Source.Length.ToString(), Source.Length.Transform(x=>x.ToString()));
        }

        [TestMethod]
        public void Test7()
        {
            Assert.IsNull(Source.Transform<string, string>(x => null));
        }

        [TestMethod]
        public void Test8()
        {
            Assert.IsNull(Source.Length.Transform<int, string>(x => null));
        }

        [TestMethod]
        public void Test9()
        {
            Assert.IsNull((null as string)?.Transform<string, int>(null));
        }

        [TestMethod]
        public void Test10()
        {
            Assert.IsNull((null as int?)?.Transform<int, int>(null));
        }

        [TestMethod]
        public void Test11()
        {
            Assert.IsNull(Source.Transform<string, int>(null));
        }

        [TestMethod]
        public void Test12()
        {
            Assert.IsNull(Source.Length.Transform<int, int>(null));
        }

        [TestMethod]
        public void Test13()
        {
            Assert.AreEqual(Source.Length, Source.Transform<string, int>(x => x.Length));
        }

        [TestMethod]
        public void Test14()
        {
            Assert.AreEqual(Source.Length, Source.Length.Transform<int, int>(x => x));
        }

        [TestMethod]
        public void Test15()
        {
            Assert.IsNull(Source.Transform<string, int>(x => null));
        }

        [TestMethod]
        public void Test16()
        {
            Assert.IsNull(Source.Length.Transform<int, int>(x => null));
        }
    }
}
