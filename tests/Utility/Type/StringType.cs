using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics.CodeAnalysis;

namespace Hestia.Core.Tests.Utility.Type
{
    [TestClass]
    [ExcludeFromCodeCoverage]
    public sealed class StringType
    {
        public const string Hestia = "Hestia";

        [TestMethod]
        public void Test1()
        {
            Assert.AreEqual(Core.Utility.BuildTypeDescriptorByExpression("string").Type, typeof(string));
        }        

        [TestMethod]
        public void Test2()
        {
            Assert.AreEqual((string)Core.Utility.BuildTypeDescriptorByExpression("string").ToObject(string.Empty), string.Empty);
        }

        [TestMethod]
        public void Test3()
        {
            Assert.AreEqual((string)Core.Utility.BuildTypeDescriptorByExpression("string").ToObject(Hestia), Hestia);
        }

    }
}
