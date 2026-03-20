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
            Assert.AreEqual(typeof(double), Core.Utility.BuildTypeDescriptorByExpression("double").Type);
        }

        [TestMethod]
        public void Test2()
        {
            Assert.AreEqual(double.MinValue, (double)Core.Utility.BuildTypeDescriptorByExpression("double").ToObject($"{double.MinValue}"));
        }

        [TestMethod]
        public void Test3()
        {
            Assert.AreEqual(double.MaxValue, (double)Core.Utility.BuildTypeDescriptorByExpression("double").ToObject($"{double.MaxValue}"));
        }
        [TestMethod]
        public void Test4()
        {
            Assert.AreEqual(double.NaN, (double)Core.Utility.BuildTypeDescriptorByExpression("double").ToObject($"{double.NaN}"));
        }

        [TestMethod]
        public void Test5()
        {
            Assert.AreEqual(double.PositiveInfinity, (double)Core.Utility.BuildTypeDescriptorByExpression("double").ToObject($"{double.PositiveInfinity}"));
        }
        [TestMethod]
        public void Test6()
        {
            Assert.AreEqual(double.NegativeInfinity, (double)Core.Utility.BuildTypeDescriptorByExpression("double").ToObject($"{double.NegativeInfinity}"));
        }
        [TestMethod]
        public void Test7()
        {
            Assert.AreEqual(double.Epsilon, (double)Core.Utility.BuildTypeDescriptorByExpression("double").ToObject($"{double.Epsilon}"));
        }
    }
}
