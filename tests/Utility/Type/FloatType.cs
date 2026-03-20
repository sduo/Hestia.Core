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
            Assert.AreEqual(typeof(float), Core.Utility.BuildTypeDescriptorByExpression("float").Type);
        }
        [TestMethod]
        public void Test2()
        {
            Assert.AreEqual(float.MinValue, (float)Core.Utility.BuildTypeDescriptorByExpression("float").ToObject($"{float.MinValue}"));
        }

        [TestMethod]
        public void Test3()
        {
            Assert.AreEqual(float.MaxValue, (float)Core.Utility.BuildTypeDescriptorByExpression("float").ToObject($"{float.MaxValue}"));
        }

        [TestMethod]
        public void Test4()
        {
            Assert.AreEqual(float.NaN, (float)Core.Utility.BuildTypeDescriptorByExpression("float").ToObject($"{float.NaN}"));
        }

        [TestMethod]
        public void Test5()
        {
            Assert.AreEqual(float.PositiveInfinity, (float)Core.Utility.BuildTypeDescriptorByExpression("float").ToObject($"{float.PositiveInfinity}"));
        }
        [TestMethod]
        public void Test6()
        {
            Assert.AreEqual(float.NegativeInfinity, (float)Core.Utility.BuildTypeDescriptorByExpression("float").ToObject($"{float.NegativeInfinity}"));
        }
        [TestMethod]
        public void Test7()
        {
            Assert.AreEqual(float.Epsilon, (float)Core.Utility.BuildTypeDescriptorByExpression("float").ToObject($"{float.Epsilon}"));
        }
    }
}
