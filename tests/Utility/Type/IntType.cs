using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics.CodeAnalysis;

namespace Hestia.Core.Tests.Utility.Type
{
    [TestClass]
    [ExcludeFromCodeCoverage]
    public sealed class IntType
    {
        [TestMethod]
        public void Test1()
        {
            Assert.AreEqual(Core.Utility.BuildTypeDescriptorByExpression("uint").Type, typeof(uint));
        }
        [TestMethod]
        public void Test2()
        {
            Assert.AreEqual(Core.Utility.BuildTypeDescriptorByExpression("int").Type, typeof(int));
        }

        [TestMethod]
        public void Test3()
        {
            Assert.AreEqual((uint)Core.Utility.BuildTypeDescriptorByExpression("uint").ToObject($"{uint.MinValue}"), uint.MinValue);
        }

        [TestMethod]
        public void Test4()
        {
            Assert.AreEqual((uint)Core.Utility.BuildTypeDescriptorByExpression("uint").ToObject($"{uint.MaxValue}"), uint.MaxValue);
        }       

        [TestMethod]
        public void Test5()
        {
            Assert.AreEqual((int)Core.Utility.BuildTypeDescriptorByExpression("int").ToObject($"{int.MinValue}"), int.MinValue);
        }

        [TestMethod]
        public void Test6()
        {
            Assert.AreEqual((int)Core.Utility.BuildTypeDescriptorByExpression("int").ToObject($"{int.MaxValue}"), int.MaxValue);
        }
    }
}
