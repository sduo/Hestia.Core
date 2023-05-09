using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics.CodeAnalysis;

namespace Hestia.Core.Tests.Utility.Type
{
    [TestClass]
    [ExcludeFromCodeCoverage]
    public sealed class TimeSpanType
    {
        [TestMethod]
        public void Test1()
        {
            Assert.AreEqual(Core.Utility.BuildTypeDescriptorByExpression("TimeSpan").Type, typeof(TimeSpan));
        }
        [TestMethod]
        public void Test2()
        {
            Assert.AreEqual((TimeSpan)Core.Utility.BuildTypeDescriptorByExpression("TimeSpan").ToObject($"{TimeSpan.MinValue}"), TimeSpan.MinValue);
        }
        [TestMethod]
        public void Test3()
        {
            
            Assert.AreEqual((TimeSpan)Core.Utility.BuildTypeDescriptorByExpression("TimeSpan").ToObject($"{TimeSpan.MaxValue}"), TimeSpan.MaxValue);
        }
        [TestMethod]
        public void Test4()
        {
            
            Assert.AreEqual((TimeSpan)Core.Utility.BuildTypeDescriptorByExpression("TimeSpan").ToObject($"{TimeSpan.Zero}"), TimeSpan.Zero);
        }
    }
}
