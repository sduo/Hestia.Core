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
            Assert.AreEqual(Core.Utility.BuildTypeDescriptorByExpression("TimeOnly").Type, typeof(TimeOnly));
        }
        [TestMethod]
        public void Test2()
        {
            Assert.AreEqual((TimeOnly)Core.Utility.BuildTypeDescriptorByExpression("TimeOnly").ToObject($"{TimeOnly.MinValue:HH:mm:ss.fffffff}"), TimeOnly.MinValue);
        }

        [TestMethod]
        public void Test3()
        {
            Assert.AreEqual((TimeOnly)Core.Utility.BuildTypeDescriptorByExpression("TimeOnly").ToObject($"{TimeOnly.MaxValue:HH:mm:ss.fffffff}"), TimeOnly.MaxValue);
        }
    }
}
