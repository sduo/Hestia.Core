using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Hestia.Core.Tests.Utility.Type
{
    [TestClass]
    [ExcludeFromCodeCoverage]
    public sealed class DictionaryType
    {
        [TestMethod]
        public void Test1()
        {
            var source = Core.Utility.BuildTypeDescriptorByExpression("dictionary:int,list:string").Type;
            var target = typeof(Dictionary<,>).MakeGenericType(typeof(int), typeof(List<>).MakeGenericType(typeof(string)));
            Assert.AreEqual(source, target);
        }

        [TestMethod]
        public void Test2()
        {
            var source = Core.Utility.BuildTypeDescriptorByExpression("dictionary:int,string").Type;
            var target = typeof(Dictionary<,>).MakeGenericType(typeof(int), typeof(string));
            Assert.AreEqual(source, target);
        }
    }
}
