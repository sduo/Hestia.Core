using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Hestia.Core.Tests.Extensions.StringExtensions
{
    [TestClass]
    public sealed class ToDateTimeOffset
    {
        [TestMethod]
        public void Test1()
        {
            Assert.AreEqual(null, string.Empty.ToDateTimeOffset());
        }

        [TestMethod]
        public void Test2()
        {
            Assert.AreEqual(DateTimeOffset.MinValue.ToLocalTime(), $"{DateTimeOffset.MinValue.ToLocalTime():yyyyMMddHHmmss}".ToDateTimeOffset());
        }

        [TestMethod]
        public void Test3()
        {
            Assert.AreEqual(DateTimeOffset.MinValue.ToLocalTime(), $"{DateTimeOffset.MinValue.ToLocalTime():yyyy-MM-dd HH:mm:ss}".ToDateTimeOffset());
        }

        [TestMethod]
        public void Test4()
        {
            Assert.AreEqual(DateTimeOffset.MaxValue.ToLocalTime(), $"{DateTimeOffset.MaxValue.ToLocalTime():yyyyMMddHHmmssfffffff}".ToDateTimeOffset());
        }

        [TestMethod]
        public void Test5()
        {
            Assert.AreEqual(DateTimeOffset.MaxValue.ToLocalTime(), $"{DateTimeOffset.MaxValue.ToLocalTime():yyyy-MM-dd HH:mm:ss.fffffff}".ToDateTimeOffset());
        }

        [TestMethod]
        public void Test6()
        {
            DateTimeOffset now = DateTimeOffset.Now;            
            Assert.AreEqual(now, $"{now:yyyy-MM-dd HH:mm:ss.fffffff}".ToDateTimeOffset());
        }

        [TestMethod]
        public void Test7()
        {
            DateTimeOffset now = DateTimeOffset.Now;
            Assert.AreEqual(now, $"{now:yyyyMMddHHmmssfffffff}".ToDateTimeOffset());
        }        
    }
}
