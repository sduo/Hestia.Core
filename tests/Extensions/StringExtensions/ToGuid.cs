using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Hestia.Core.Tests.Extensions.StringExtensions
{
    [TestClass]
    public sealed class ToGuid
    {
        [TestMethod]
        public void Test1()
        {
            Assert.AreEqual(null, string.Empty.ToGuid());
        }

        [TestMethod]
        public void Test2()
        {
            Assert.AreEqual(Guid.Empty, $"{Guid.Empty:N}".ToGuid());
        }

        [TestMethod]
        public void Test3()
        {
            Assert.AreEqual(Guid.Empty, $"{Guid.Empty:D}".ToGuid());
        }

        [TestMethod]
        public void Test4()
        {
            Assert.AreEqual(Guid.Empty, $"{Guid.Empty:B}".ToGuid());
        }

        [TestMethod]
        public void Test5()
        {
            Assert.AreEqual(Guid.Empty, $"{Guid.Empty:P}".ToGuid());
        }

        [TestMethod]
        public void Test6()
        {
            Guid guid = Guid.NewGuid();
            Assert.AreEqual(guid, $"{guid:N}".ToGuid());
        }

        [TestMethod]
        public void Test7()
        {
            Guid guid = Guid.NewGuid();
            Assert.AreEqual(guid, $"{guid:D}".ToGuid());
        }

        [TestMethod]
        public void Test8()
        {
            Guid guid = Guid.NewGuid();
            Assert.AreEqual(guid, $"{guid:B}".ToGuid());
        }

        [TestMethod]
        public void Test9()
        {
            Guid guid = Guid.NewGuid();
            Assert.AreEqual(guid, $"{guid:P}".ToGuid());
        }
    }
}
