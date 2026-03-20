using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics.CodeAnalysis;

namespace Hestia.Core.Tests.Utility.Type
{
    [TestClass]
    [ExcludeFromCodeCoverage]
    public sealed class ByteType
    {
        [TestMethod]
        public void Test1()
        {
            Assert.AreEqual(typeof(byte), Core.Utility.BuildTypeDescriptorByExpression("byte").Type);
        }
        [TestMethod]
        public void Test2()
        {
            Assert.AreEqual(typeof(sbyte), Core.Utility.BuildTypeDescriptorByExpression("sbyte").Type);
        }

        [TestMethod]
        public void Test3()
        {
            Assert.AreEqual(byte.MinValue, (byte)Core.Utility.BuildTypeDescriptorByExpression("byte").ToObject($"{byte.MinValue}"));
        }

        [TestMethod]
        public void Test4()
        {
            Assert.AreEqual(byte.MaxValue, (byte)Core.Utility.BuildTypeDescriptorByExpression("byte").ToObject($"{byte.MaxValue}"));
        }

        [TestMethod]
        public void Test5()
        {
            Assert.AreEqual(sbyte.MinValue,(sbyte)Core.Utility.BuildTypeDescriptorByExpression("sbyte").ToObject($"{sbyte.MinValue}"));
        }

        [TestMethod]
        public void Test6()
        {
            Assert.AreEqual(sbyte.MaxValue, (sbyte)Core.Utility.BuildTypeDescriptorByExpression("sbyte").ToObject($"{sbyte.MaxValue}"));
        }
    }
}
