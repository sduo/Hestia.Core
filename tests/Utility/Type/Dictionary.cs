using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Hestia.Core.Tests.Utility.Type
{
    [TestClass]
    [ExcludeFromCodeCoverage]
    public sealed class Dictionary
    {
        [TestMethod]
        public void Test1()
        {
            var source = Core.Utility.BuildTypeByExpression("dictionary:int,list:string");
            var target = typeof(Dictionary<,>).MakeGenericType(typeof(int), typeof(List<>).MakeGenericType(typeof(string)));
            Assert.AreEqual(source, target);
        }

        [TestMethod]
        public void Test2()
        {
            var source = Core.Utility.BuildTypeByExpression("dictionary:int,string");
            var target = typeof(Dictionary<,>).MakeGenericType(typeof(int), typeof(string));
            Assert.AreEqual(source, target);
        }
    }
}
