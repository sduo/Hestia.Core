using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using HCU = Hestia.Core.Utility;

namespace Hestia.Core.Tests.Utility.Json
{
    [TestClass]
    [ExcludeFromCodeCoverage]
    public sealed class GetJsonElement
    {
        internal JsonDocument jdoc = JsonDocument.Parse("{ \"string\": \"text\", \"number\":0, \"bool\":true, \"null\":null, \"array\":[], \"object\": {} }");

        [TestMethod]
        public void Test1()
        {
            Assert.AreEqual(null, HCU.GetJsonElement(null,null, null));
        }

        [TestMethod]
        public void Test2()
        {
            Assert.AreEqual(null, HCU.GetJsonElement(jdoc.RootElement, null, null));
        }

        [TestMethod]
        public void Test3()
        {
            Assert.AreEqual(null, HCU.GetJsonElement(jdoc.RootElement, "undefined", null));
        }

        [TestMethod]
        public void Test4()
        {
            Assert.AreEqual(null, HCU.GetJsonElement(jdoc.RootElement, "string", JsonValueKind.Object));
        }

        [TestMethod]
        public void Test5()
        {
            Assert.AreEqual("text", HCU.GetJsonElement(jdoc.RootElement, "string", JsonValueKind.String)?.GetString());
        }

        [TestMethod]
        public void Test6()
        {
            Assert.AreEqual(0, HCU.GetJsonElement(jdoc.RootElement, "number", JsonValueKind.Number)?.GetInt32());
        }

        [TestMethod]
        public void Test7()
        {
            Assert.AreEqual(true, HCU.GetJsonElement(jdoc.RootElement, "bool", JsonValueKind.True)?.GetBoolean());
        }

        [TestMethod]
        public void Test8()
        {
            Assert.AreEqual(null, HCU.GetJsonElement(jdoc.RootElement, "bool", JsonValueKind.False)?.GetBoolean());
        }

        [TestMethod]
        public void Test9()
        {
            Assert.AreEqual(JsonValueKind.Null, HCU.GetJsonElement(jdoc.RootElement, "null", JsonValueKind.Null)?.ValueKind);
        }

        [TestMethod]
        public void Test10()
        {
            Assert.AreEqual(JsonValueKind.Object, HCU.GetJsonElement(jdoc.RootElement, "object", JsonValueKind.Object)?.ValueKind);
        }

        [TestMethod]
        public void Test11()
        {
            Assert.AreEqual(JsonValueKind.Array, HCU.GetJsonElement(jdoc.RootElement, "array", JsonValueKind.Array)?.ValueKind);
        }
    }
}
