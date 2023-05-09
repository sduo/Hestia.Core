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
            Assert.AreEqual(Core.Utility.BuildTypeDescriptorByExpression("byte").Type, typeof(byte));
        }
        [TestMethod]
        public void Test2()
        {
            Assert.AreEqual(Core.Utility.BuildTypeDescriptorByExpression("sbyte").Type, typeof(sbyte));
        }

        [TestMethod]
        public void Test3()
        {
            Assert.AreEqual((byte)Core.Utility.BuildTypeDescriptorByExpression("byte").ToObject($"{byte.MinValue}"), byte.MinValue);
        }

        [TestMethod]
        public void Test4()
        {
            Assert.AreEqual((byte)Core.Utility.BuildTypeDescriptorByExpression("byte").ToObject($"{byte.MaxValue}"), byte.MaxValue);
        }

        [TestMethod]
        public void Test5()
        {
            Assert.AreEqual((sbyte)Core.Utility.BuildTypeDescriptorByExpression("sbyte").ToObject($"{sbyte.MinValue}"), sbyte.MinValue);
        }

        [TestMethod]
        public void Test6()
        {
            Assert.AreEqual((sbyte)Core.Utility.BuildTypeDescriptorByExpression("sbyte").ToObject($"{sbyte.MaxValue}"), sbyte.MaxValue);
        }
    }
}
