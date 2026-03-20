using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics.CodeAnalysis;

namespace Hestia.Core.Tests.Utility.Type
{
    [TestClass]
    [ExcludeFromCodeCoverage]
    public sealed class ObjectType
    {
        public const string Hestia = "Hestia";

        [TestMethod]
        public void Test1()
        {
            Assert.AreEqual(typeof(object), Core.Utility.BuildTypeDescriptorByExpression("object").Type);
        }
    }
}
