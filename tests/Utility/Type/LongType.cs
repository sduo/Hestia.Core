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
            Assert.AreEqual(typeof(ulong), Core.Utility.BuildTypeDescriptorByExpression("ulong").Type);
        }
        [TestMethod]
        public void Test2()
        {
            Assert.AreEqual(typeof(long), Core.Utility.BuildTypeDescriptorByExpression("long").Type);
        }

        [TestMethod]
        public void Test3()
        {
            Assert.AreEqual(ulong.MinValue, (ulong)Core.Utility.BuildTypeDescriptorByExpression("ulong").ToObject($"{ulong.MinValue}"));
        }

        [TestMethod]
        public void Test4()
        {
            Assert.AreEqual(ulong.MaxValue, (ulong)Core.Utility.BuildTypeDescriptorByExpression("ulong").ToObject($"{ulong.MaxValue}"));
        }

        [TestMethod]
        public void Test5()
        {
            Assert.AreEqual(long.MinValue, (long)Core.Utility.BuildTypeDescriptorByExpression("long").ToObject($"{long.MinValue}"));
        }

        [TestMethod]
        public void Test6()
        {
            Assert.AreEqual(long.MaxValue, (long)Core.Utility.BuildTypeDescriptorByExpression("long").ToObject($"{long.MaxValue}"));
        }
    }
}
