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
            Assert.AreEqual(typeof(TimeSpan), Core.Utility.BuildTypeDescriptorByExpression("TimeSpan").Type );
        }
        [TestMethod]
        public void Test2()
        {
            Assert.AreEqual(TimeSpan.MinValue, (TimeSpan)Core.Utility.BuildTypeDescriptorByExpression("TimeSpan").ToObject($"{TimeSpan.MinValue}"));
        }
        [TestMethod]
        public void Test3()
        {            
            Assert.AreEqual(TimeSpan.MaxValue, (TimeSpan)Core.Utility.BuildTypeDescriptorByExpression("TimeSpan").ToObject($"{TimeSpan.MaxValue}"));
        }
        [TestMethod]
        public void Test4()
        {            
            Assert.AreEqual(TimeSpan.Zero, (TimeSpan)Core.Utility.BuildTypeDescriptorByExpression("TimeSpan").ToObject($"{TimeSpan.Zero}"));
        }
    }
}
