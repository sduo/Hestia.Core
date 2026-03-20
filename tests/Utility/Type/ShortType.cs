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
            Assert.AreEqual(typeof(ushort), Core.Utility.BuildTypeDescriptorByExpression("ushort").Type);
        }
        [TestMethod]
        public void Test2()
        {
            Assert.AreEqual(typeof(short), Core.Utility.BuildTypeDescriptorByExpression("short").Type);
        }
        [TestMethod]
        public void Test3()
        {
            Assert.AreEqual(ushort.MinValue, (ushort)Core.Utility.BuildTypeDescriptorByExpression("ushort").ToObject($"{ushort.MinValue}"));
        }

        [TestMethod]
        public void Test4()
        {
            Assert.AreEqual(ushort.MaxValue, (ushort)Core.Utility.BuildTypeDescriptorByExpression("ushort").ToObject($"{ushort.MaxValue}"));
        }

        [TestMethod]
        public void Test5()
        {
            Assert.AreEqual(short.MinValue, (short)Core.Utility.BuildTypeDescriptorByExpression("short").ToObject($"{short.MinValue}"));
        }

        [TestMethod]
        public void Test6()
        {
            Assert.AreEqual(short.MaxValue, (short)Core.Utility.BuildTypeDescriptorByExpression("short").ToObject($"{short.MaxValue}"));
        }
    }
}
