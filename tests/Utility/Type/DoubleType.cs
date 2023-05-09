using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics.CodeAnalysis;

namespace Hestia.Core.Tests.Utility.Type
{
    [TestClass]
    [ExcludeFromCodeCoverage]
    public sealed class DoubleType
    {
        [TestMethod]
        public void Test1()
        {
            Assert.AreEqual(Core.Utility.BuildTypeDescriptorByExpression("double").Type, typeof(double));
        }

        [TestMethod]
        public void Test2()
        {
            Assert.AreEqual((double)Core.Utility.BuildTypeDescriptorByExpression("double").ToObject($"{double.MinValue}"), double.MinValue);
        }

        [TestMethod]
        public void Test3()
        {
            Assert.AreEqual((double)Core.Utility.BuildTypeDescriptorByExpression("double").ToObject($"{double.MaxValue}"), double.MaxValue);
        }
        [TestMethod]
        public void Test4()
        {
            Assert.AreEqual((double)Core.Utility.BuildTypeDescriptorByExpression("double").ToObject($"{double.NaN}"), double.NaN);
        }

        [TestMethod]
        public void Test5()
        {
            Assert.AreEqual((double)Core.Utility.BuildTypeDescriptorByExpression("double").ToObject($"{double.PositiveInfinity}"), double.PositiveInfinity);
        }
        [TestMethod]
        public void Test6()
        {
            Assert.AreEqual((double)Core.Utility.BuildTypeDescriptorByExpression("double").ToObject($"{double.NegativeInfinity}"), double.NegativeInfinity);
        }
        [TestMethod]
        public void Test7()
        {
            Assert.AreEqual((double)Core.Utility.BuildTypeDescriptorByExpression("double").ToObject($"{double.Epsilon}"), double.Epsilon);
        }
    }
}
