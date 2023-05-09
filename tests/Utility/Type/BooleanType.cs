using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics.CodeAnalysis;

namespace Hestia.Core.Tests.Utility.Type
{
    [TestClass]
    [ExcludeFromCodeCoverage]
    public sealed class BooleanType
    {
        [TestMethod]
        public void Test1()
        {
            Assert.AreEqual(Core.Utility.BuildTypeDescriptorByExpression("bool").Type, typeof(bool));
        }        

        [TestMethod]
        public void Test2()
        {
            Assert.AreEqual((bool)Core.Utility.BuildTypeDescriptorByExpression("bool").ToObject(bool.TrueString), true);
        }

        [TestMethod]
        public void Test3()
        {
            Assert.AreEqual((bool)Core.Utility.BuildTypeDescriptorByExpression("bool").ToObject(bool.FalseString), false);
        }
    }
}
