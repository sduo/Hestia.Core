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
            Assert.AreEqual(typeof(uint), Core.Utility.BuildTypeDescriptorByExpression("uint").Type);
        }
        [TestMethod]
        public void Test2()
        {
            Assert.AreEqual(typeof(int), Core.Utility.BuildTypeDescriptorByExpression("int").Type);
        }

        [TestMethod]
        public void Test3()
        {
            Assert.AreEqual(uint.MinValue, (uint)Core.Utility.BuildTypeDescriptorByExpression("uint").ToObject($"{uint.MinValue}"));
        }

        [TestMethod]
        public void Test4()
        {
            Assert.AreEqual(uint.MaxValue, (uint)Core.Utility.BuildTypeDescriptorByExpression("uint").ToObject($"{uint.MaxValue}"));
        }      

        [TestMethod]
        public void Test5()
        {
            Assert.AreEqual(int.MinValue, (int)Core.Utility.BuildTypeDescriptorByExpression("int").ToObject($"{int.MinValue}"));
        }

        [TestMethod]
        public void Test6()
        {
            Assert.AreEqual(int.MaxValue, (int)Core.Utility.BuildTypeDescriptorByExpression("int").ToObject($"{int.MaxValue}"));
        }
    }
}
