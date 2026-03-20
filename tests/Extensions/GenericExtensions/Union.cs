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
            Assert.AreSame(Array.Empty<string>(), (null as string[]).Union(Array.Empty<string>()));
        }

        [TestMethod]
        public void Test2()
        {
            Assert.AreSame(Array.Empty<int>(), (null as int[]).Union(Array.Empty<int>()));
        }

        [TestMethod]
        public void Test3()
        {
            Assert.AreSame(Array.Empty<int?>(), (null as int?[]).Union(Array.Empty<int?>()));
        }

        [TestMethod]
        public void Test4()
        {
            Assert.AreSame(Array.Empty<string>(), (Array.Empty<string>()).Union(Array.Empty<string>()));
        }

        [TestMethod]
        public void Test5()
        {
            Assert.AreSame(Array.Empty<int>(), (Array.Empty<int>()).Union(Array.Empty<int>()));
        }

        [TestMethod]
        public void Test6()
        {
            Assert.AreSame(Array.Empty<int?>(), (Array.Empty<int?>()).Union(Array.Empty<int?>()));
        }
    }
}
