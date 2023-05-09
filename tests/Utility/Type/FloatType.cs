using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics.CodeAnalysis;

namespace Hestia.Core.Tests.Utility.Type
{
    [TestClass]
    [ExcludeFromCodeCoverage]
    public sealed class FloatType
    {
        [TestMethod]
        public void Test1()
        {
            Assert.AreEqual(Core.Utility.BuildTypeDescriptorByExpression("float").Type, typeof(float));
        }
        [TestMethod]
        public void Test2()
        {
            Assert.AreEqual((float)Core.Utility.BuildTypeDescriptorByExpression("float").ToObject($"{float.MinValue}"), float.MinValue);
        }

        [TestMethod]
        public void Test3()
        {
            Assert.AreEqual((float)Core.Utility.BuildTypeDescriptorByExpression("float").ToObject($"{float.MaxValue}"), float.MaxValue);
        }

        [TestMethod]
        public void Test4()
        {
            Assert.AreEqual((float)Core.Utility.BuildTypeDescriptorByExpression("float").ToObject($"{float.NaN}"), float.NaN);
        }

        [TestMethod]
        public void Test5()
        {
            Assert.AreEqual((float)Core.Utility.BuildTypeDescriptorByExpression("float").ToObject($"{float.PositiveInfinity}"), float.PositiveInfinity);
        }
        [TestMethod]
        public void Test6()
        {
            Assert.AreEqual((float)Core.Utility.BuildTypeDescriptorByExpression("float").ToObject($"{float.NegativeInfinity}"), float.NegativeInfinity);
        }
        [TestMethod]
        public void Test7()
        {
            Assert.AreEqual((float)Core.Utility.BuildTypeDescriptorByExpression("float").ToObject($"{float.Epsilon}"), float.Epsilon);
        }
    }
}
