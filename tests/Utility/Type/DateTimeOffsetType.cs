using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics.CodeAnalysis;

namespace Hestia.Core.Tests.Utility.Type
{
    [TestClass]
    [ExcludeFromCodeCoverage]
    public sealed class DateTimeOffsetType
    {
        [TestMethod]
        public void Test1()
        {
            Assert.AreEqual(Core.Utility.BuildTypeDescriptorByExpression("DateTimeOffset").Type, typeof(DateTimeOffset));
        }
        [TestMethod]
        public void Test2()
        {
            Assert.AreEqual((DateTimeOffset)Core.Utility.BuildTypeDescriptorByExpression("DateTimeOffset").ToObject($"{DateTimeOffset.MinValue.ToLocalTime():yyyy-MM-dd HH:mm:ss.fffffff}"), DateTimeOffset.MinValue.ToLocalTime());
        }

        [TestMethod]
        public void Test3()
        {
            Assert.AreEqual((DateTimeOffset)Core.Utility.BuildTypeDescriptorByExpression("DateTimeOffset").ToObject($"{DateTimeOffset.MaxValue.ToLocalTime():yyyy-MM-dd HH:mm:ss.fffffff}"), DateTimeOffset.MaxValue.ToLocalTime());
        }
        [TestMethod]
        public void Test4()
        {
            Assert.AreEqual((DateTimeOffset)Core.Utility.BuildTypeDescriptorByExpression("DateTimeOffset").ToObject($"{DateTimeOffset.UnixEpoch.ToLocalTime():yyyy-MM-dd HH:mm:ss.fffffff}"), DateTimeOffset.UnixEpoch.ToLocalTime());
        }
    }
}
