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
            Assert.AreEqual(typeof(bool), Core.Utility.BuildTypeDescriptorByExpression("bool").Type);
        }        

        [TestMethod]
        public void Test2()
        {
            Assert.AreEqual(true, (bool)Core.Utility.BuildTypeDescriptorByExpression("bool").ToObject(bool.TrueString));
        }

        [TestMethod]
        public void Test3()
        {
            Assert.AreEqual(false, (bool)Core.Utility.BuildTypeDescriptorByExpression("bool").ToObject(bool.FalseString));
        }
    }
}
