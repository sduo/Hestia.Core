using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics.CodeAnalysis;

namespace Hestia.Core.Tests.Extensions.GenericExtensions
{
    [TestClass]
    [ExcludeFromCodeCoverage]
    public sealed class Union
    {        
        [TestMethod]
        public void Test1()
        {
            Assert.AreSame([], (null as string[]).Union([]));
        }

        [TestMethod]
        public void Test2()
        {
            Assert.AreSame([], (null as int[]).Union([]));
        }

        [TestMethod]
        public void Test3()
        {
            Assert.AreSame([], (null as int?[]).Union([]));
        }

        [TestMethod]
        public void Test4()
        {
            Assert.AreSame([], (Array.Empty<string>()).Union([]));
        }

        [TestMethod]
        public void Test5()
        {
            Assert.AreSame([], (Array.Empty<int>()).Union([]));
        }

        [TestMethod]
        public void Test6()
        {
            Assert.AreSame([], (Array.Empty<int?>()).Union([]));
        }

        [TestMethod]
        public void Test7()
        {
            Assert.IsNull((null as string[]).Union(null));
        }

        [TestMethod]
        public void Test8()
        {
            Assert.IsNull((null as int[]).Union(null));
        }

        [TestMethod]
        public void Test9()
        {
            Assert.IsNull((null as int?[]).Union(null));
        }

        [TestMethod]
        public void Test10()
        {
            Assert.AreSame([], (Array.Empty<string>()).Union(null));
        }

        [TestMethod]
        public void Test11()
        {
            Assert.AreSame([], (Array.Empty<int>()).Union(null));
        }

        [TestMethod]
        public void Test12()
        {
            Assert.AreSame([], (Array.Empty<int?>()).Union(null));
        }
    }
}
