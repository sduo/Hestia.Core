using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Nodes;
using HCU = Hestia.Core.Utility;

namespace Hestia.Core.Tests.Utility.Json
{
    [TestClass]
    [ExcludeFromCodeCoverage]
    public sealed class GetJsonNode
    {
        internal JsonObject jo = JsonNode.Parse("{ \"string\": \"text\", \"number\":0, \"bool\":true, \"null\":null, \"array\":[], \"object\": {} }").AsObject();
        [TestMethod]
        public void Test1()
        {
            Assert.AreEqual(null, HCU.GetJsonNode(null, null));
        }

        [TestMethod]
        public void Test2()
        {
            Assert.AreEqual(null, HCU.GetJsonNode(jo, null));
        }

        [TestMethod]
        public void Test3()
        {
            Assert.AreEqual(null, HCU.GetJsonNode(jo, "undefined"));
        }

        [TestMethod]
        public void Test4()
        {
            Assert.AreEqual("text", HCU.GetJsonNode(jo, "string")?.GetValue<string>());
        }

        [TestMethod]
        public void Test5()
        {
            Assert.AreEqual(0, HCU.GetJsonNode(jo, "number")?.GetValue<int>());
        }

        [TestMethod]
        public void Test6()
        {
            Assert.AreEqual(true, HCU.GetJsonNode(jo, "bool")?.GetValue<bool>());
        }

        [TestMethod]
        public void Test7()
        {
            Assert.AreEqual(null, HCU.GetJsonNode(jo, "null")?.GetValue<object>());
        }

        [TestMethod]
        public void Test8()
        {
            Assert.AreEqual(true, HCU.GetJsonNode(jo, "object") is JsonObject);
        }

        [TestMethod]
        public void Test9()
        {
            Assert.AreEqual(true, HCU.GetJsonNode(jo, "array") is JsonArray);
        }

    }
}
