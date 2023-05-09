using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Hestia.Core.Tests.Utility.Type
{
    [TestClass]
    [ExcludeFromCodeCoverage]
    public sealed class ListType
    {
        [TestMethod]
        public void Test1()
        {
            var source = Core.Utility.BuildTypeDescriptorByExpression("list:object").Type;
            var target = typeof(List<>).MakeGenericType(typeof(object));
            Assert.AreEqual(source, target);
        }

        [TestMethod]
        public void Test2()
        {
            var source = Core.Utility.BuildTypeDescriptorByExpression("list:long").Type;
            var target = typeof(List<>).MakeGenericType(typeof(long));
            Assert.AreEqual(source, target);
        }

        [TestMethod]
        public void Test3()
        {
            var source = Core.Utility.BuildTypeDescriptorByExpression("list:string").Type;
            var target = typeof(List<>).MakeGenericType(typeof(string));
            Assert.AreEqual(source, target);
        }

        [TestMethod]
        public void Test4()
        {
            var json = "[1]";
            var list = (List<int>)Core.Utility.BuildTypeDescriptorByExpression("list:int").ToObject(json);
            Assert.AreEqual(Core.Utility.ToJson( list), json);
        }

        [TestMethod]
        public void Test5()
        {
            var json = "[1]";
            var list = (List<long>)Core.Utility.BuildTypeDescriptorByExpression("list:long").ToObject(json);
            Assert.AreEqual(Core.Utility.ToJson(list), json);
        }
    }
}
