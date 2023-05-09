using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics.CodeAnalysis;

namespace Hestia.Core.Tests.Utility.Type
{
    [TestClass]
    [ExcludeFromCodeCoverage]
    public sealed class LongType
    {
        [TestMethod]
        public void Test1()
        {
            Assert.AreEqual(Core.Utility.BuildTypeDescriptorByExpression("ulong").Type, typeof(ulong));
        }
        [TestMethod]
        public void Test2()
        {
            Assert.AreEqual(Core.Utility.BuildTypeDescriptorByExpression("long").Type, typeof(long));
        }

        [TestMethod]
        public void Test3()
        {
            Assert.AreEqual((ulong)Core.Utility.BuildTypeDescriptorByExpression("ulong").ToObject($"{ulong.MinValue}"), ulong.MinValue);
        }

        [TestMethod]
        public void Test4()
        {
            Assert.AreEqual((ulong)Core.Utility.BuildTypeDescriptorByExpression("ulong").ToObject($"{ulong.MaxValue}"), ulong.MaxValue);
        }

        [TestMethod]
        public void Test5()
        {
            Assert.AreEqual((long)Core.Utility.BuildTypeDescriptorByExpression("long").ToObject($"{long.MinValue}"), long.MinValue);
        }

        [TestMethod]
        public void Test6()
        {
            Assert.AreEqual((long)Core.Utility.BuildTypeDescriptorByExpression("long").ToObject($"{long.MaxValue}"), long.MaxValue);
        }
    }
}
