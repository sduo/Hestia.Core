using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics.CodeAnalysis;

namespace Hestia.Core.Tests.Utility.Type
{
    [TestClass]
    [ExcludeFromCodeCoverage]
    public sealed class Basic
    {
        [TestMethod]
        public void Test1()
        {   
            Assert.AreEqual(Core.Utility.BuildTypeByExpression("bool"), typeof(bool));
        }
        [TestMethod]
        public void Test2()
        {
            Assert.AreEqual(Core.Utility.BuildTypeByExpression("byte"), typeof(byte));
        }
        [TestMethod]
        public void Test3()
        {
            Assert.AreEqual(Core.Utility.BuildTypeByExpression("sbyte"), typeof(sbyte));
        }
        [TestMethod]
        public void Test4()
        {
            Assert.AreEqual(Core.Utility.BuildTypeByExpression("ushort"), typeof(ushort));
        }
        [TestMethod]
        public void Test5()
        {
            Assert.AreEqual(Core.Utility.BuildTypeByExpression("short"), typeof(short));
        }
        [TestMethod]
        public void Test6()
        {
            Assert.AreEqual(Core.Utility.BuildTypeByExpression("uint"), typeof(uint));
        }
        [TestMethod]
        public void Test7()
        {
            Assert.AreEqual(Core.Utility.BuildTypeByExpression("int"), typeof(int));
        }
        [TestMethod]
        public void Test8()
        {
            Assert.AreEqual(Core.Utility.BuildTypeByExpression("ulong"), typeof(ulong));
        }
        [TestMethod]
        public void Test9()
        {
            Assert.AreEqual(Core.Utility.BuildTypeByExpression("long"), typeof(long));
        }
        [TestMethod]
        public void Test10()
        {
            Assert.AreEqual(Core.Utility.BuildTypeByExpression("float"), typeof(float));
        }
        [TestMethod]
        public void Test11()
        {
            Assert.AreEqual(Core.Utility.BuildTypeByExpression("DateTime"), typeof(DateTime));
        }
        [TestMethod]
        public void Test12()
        {
            Assert.AreEqual(Core.Utility.BuildTypeByExpression("DateOnly"), typeof(DateOnly));
        }
        [TestMethod]
        public void Test13()
        {
            Assert.AreEqual(Core.Utility.BuildTypeByExpression("TimeOnly"), typeof(TimeOnly));
        }
        [TestMethod]
        public void Test14()
        {
            Assert.AreEqual(Core.Utility.BuildTypeByExpression("DateTimeOffset"), typeof(DateTimeOffset));
        }
        [TestMethod]
        public void Test15()
        {
            Assert.AreEqual(Core.Utility.BuildTypeByExpression("TimeSpan"), typeof(TimeSpan));
        }
        [TestMethod]
        public void Test16()
        {
            Assert.AreEqual(Core.Utility.BuildTypeByExpression("string"), typeof(string));
        }
        [TestMethod]
        public void Test17()
        {
            Assert.AreEqual(Core.Utility.BuildTypeByExpression("object"), typeof(object));
        }
    }
}
