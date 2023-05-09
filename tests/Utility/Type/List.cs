using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hestia.Core.Tests.Utility.Type
{
    [TestClass]
    [ExcludeFromCodeCoverage]
    public sealed class List
    {
        [TestMethod]
        public void Test1()
        {
            var source = Core.Utility.BuildTypeByExpression("list:object");
            var target = typeof(List<>).MakeGenericType(typeof(object));
            Assert.AreEqual(source, target);
        }

        [TestMethod]
        public void Test2()
        {
            var source = Core.Utility.BuildTypeByExpression("list:long");
            var target = typeof(List<>).MakeGenericType(typeof(long));
            Assert.AreEqual(source, target);
        }

        [TestMethod]
        public void Test3()
        {
            var source = Core.Utility.BuildTypeByExpression("list:string");
            var target = typeof(List<>).MakeGenericType(typeof(string));
            Assert.AreEqual(source, target);
        }
    }
}
