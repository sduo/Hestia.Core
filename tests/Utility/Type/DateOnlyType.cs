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
            Assert.AreEqual(Core.Utility.BuildTypeDescriptorByExpression("DateOnly").Type, typeof(DateOnly));
        }
        [TestMethod]
        public void Test2()
        {
            Assert.AreEqual((DateOnly)Core.Utility.BuildTypeDescriptorByExpression("DateOnly").ToObject($"{DateOnly.MinValue:yyyy-MM-dd}"), DateOnly.MinValue);
        }

        [TestMethod]
        public void Test3()
        {
            Assert.AreEqual((DateOnly)Core.Utility.BuildTypeDescriptorByExpression("DateOnly").ToObject($"{DateOnly.MaxValue:yyyy-MM-dd}"), DateOnly.MaxValue);
        }
    }
}
