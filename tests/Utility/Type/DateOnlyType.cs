using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics.CodeAnalysis;

namespace Hestia.Core.Tests.Utility.Type
{
    [TestClass]
    [ExcludeFromCodeCoverage]
    public sealed class DateOnlyType
    {
        [TestMethod]
        public void Test1()
        {
            Assert.AreEqual(typeof(DateOnly), Core.Utility.BuildTypeDescriptorByExpression("DateOnly").Type);
        }
        [TestMethod]
        public void Test2()
        {
            Assert.AreEqual(DateOnly.MinValue, (DateOnly)Core.Utility.BuildTypeDescriptorByExpression("DateOnly").ToObject($"{DateOnly.MinValue:yyyy-MM-dd}"));
        }

        [TestMethod]
        public void Test3()
        {
            Assert.AreEqual(DateOnly.MaxValue, (DateOnly)Core.Utility.BuildTypeDescriptorByExpression("DateOnly").ToObject($"{DateOnly.MaxValue:yyyy-MM-dd}"));
        }
    }
}
