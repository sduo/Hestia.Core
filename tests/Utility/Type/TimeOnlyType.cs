using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics.CodeAnalysis;

namespace Hestia.Core.Tests.Utility.Type
{
    [TestClass]
    [ExcludeFromCodeCoverage]
    public sealed class TimeOnlyType
    {
        [TestMethod]
        public void Test1()
        {
            Assert.AreEqual(typeof(TimeOnly), Core.Utility.BuildTypeDescriptorByExpression("TimeOnly").Type);
        }
        [TestMethod]
        public void Test2()
        {
            Assert.AreEqual(TimeOnly.MinValue, (TimeOnly)Core.Utility.BuildTypeDescriptorByExpression("TimeOnly").ToObject($"{TimeOnly.MinValue:HH:mm:ss.fffffff}"));
        }

        [TestMethod]
        public void Test3()
        {
            Assert.AreEqual(TimeOnly.MaxValue, (TimeOnly)Core.Utility.BuildTypeDescriptorByExpression("TimeOnly").ToObject($"{TimeOnly.MaxValue:HH:mm:ss.fffffff}"));
        }
    }
}
