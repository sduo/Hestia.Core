using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics.CodeAnalysis;

namespace Hestia.Core.Tests.Utility.Type
{
    [TestClass]
    [ExcludeFromCodeCoverage]
    public sealed class ShortType
    {
        [TestMethod]
        public void Test1()
        {
            Assert.AreEqual(Core.Utility.BuildTypeDescriptorByExpression("ushort").Type, typeof(ushort));
        }
        [TestMethod]
        public void Test2()
        {
            Assert.AreEqual(Core.Utility.BuildTypeDescriptorByExpression("short").Type, typeof(short));
        }
        [TestMethod]
        public void Test3()
        {
            Assert.AreEqual((ushort)Core.Utility.BuildTypeDescriptorByExpression("ushort").ToObject($"{ushort.MinValue}"), ushort.MinValue);
        }

        [TestMethod]
        public void Test4()
        {
            Assert.AreEqual((ushort)Core.Utility.BuildTypeDescriptorByExpression("ushort").ToObject($"{ushort.MaxValue}"), ushort.MaxValue);
        }

        [TestMethod]
        public void Test5()
        {
            Assert.AreEqual((short)Core.Utility.BuildTypeDescriptorByExpression("short").ToObject($"{short.MinValue}"), short.MinValue);
        }

        [TestMethod]
        public void Test6()
        {
            Assert.AreEqual((short)Core.Utility.BuildTypeDescriptorByExpression("short").ToObject($"{short.MaxValue}"), short.MaxValue);
        }
    }
}
