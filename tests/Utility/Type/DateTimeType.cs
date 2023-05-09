using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics.CodeAnalysis;

namespace Hestia.Core.Tests.Utility.Type
{
    [TestClass]
    [ExcludeFromCodeCoverage]
    public sealed class DateTimeType
    {
        [TestMethod]
        public void Test1()
        {
            Assert.AreEqual(Core.Utility.BuildTypeDescriptorByExpression("DateTime").Type, typeof(DateTime));
        }
        [TestMethod]
        public void Test2()
        {
            Assert.AreEqual((DateTime)Core.Utility.BuildTypeDescriptorByExpression("DateTime").ToObject($"{DateTime.MinValue:yyyy-MM-dd HH:mm:ss.fffffff}"), DateTime.MinValue);
        }

        [TestMethod]
        public void Test3()
        {
            Assert.AreEqual((DateTime)Core.Utility.BuildTypeDescriptorByExpression("DateTime").ToObject($"{DateTime.MaxValue:yyyy-MM-dd HH:mm:ss.fffffff}"), DateTime.MaxValue);
        }
        [TestMethod]
        public void Test4()
        {
            Assert.AreEqual((DateTime)Core.Utility.BuildTypeDescriptorByExpression("DateTime").ToObject($"{DateTime.UnixEpoch:yyyy-MM-dd HH:mm:ss.fffffff}"), DateTime.UnixEpoch);
        }
    }
}
