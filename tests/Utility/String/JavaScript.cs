using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics.CodeAnalysis;

namespace Hestia.Core.Tests.Utility.String
{
    [TestClass]
    [ExcludeFromCodeCoverage]
    public sealed class JavaScript
    {       

        [TestMethod]
        public void Test1()
        {
            Assert.IsNull(Core.Utility.JavaScriptEscape(null));
        }

        [TestMethod]
        public void Test2()
        {
            Assert.AreEqual("@*_+-./", Core.Utility.JavaScriptEscape("@*_+-./"));
        }

        [TestMethod]
        public void Test3()
        {
            Assert.AreEqual("abc123", Core.Utility.JavaScriptEscape("abc123"));
        }

        [TestMethod]
        public void Test4()
        {
            Assert.AreEqual("%E4%F6%FC", Core.Utility.JavaScriptEscape("äöü"));
        }

        [TestMethod]
        public void Test5()
        {
            Assert.AreEqual("%u0107", Core.Utility.JavaScriptEscape("ć"));
        }


        [TestMethod]
        public void Test6()
        {
            Assert.AreEqual("abc123", Core.Utility.JavaScriptUnescape("abc123"));
        }

        [TestMethod]
        public void Test7()
        {
            Assert.AreEqual("äöü", Core.Utility.JavaScriptUnescape("%E4%F6%FC"));
        }

        [TestMethod]
        public void Test8()
        {
            Assert.AreEqual("ć", Core.Utility.JavaScriptUnescape("%u0107"));
        }

        [TestMethod]
        public void Test9()
        {            
            Assert.AreEqual("%F0%90%8F%BF", Core.Utility.JavaScriptEncodeURI("\uD800\uDFFF"));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test10()
        {
            Core.Utility.JavaScriptEncodeURI("\uD800");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test11()
        {
            Core.Utility.JavaScriptEncodeURI("\uDFFF");
        }

        [TestMethod]
        public void Test12()
        {
            Assert.AreEqual("%5B%5D", Core.Utility.JavaScriptEncodeURI("[]"));
        }        

        [TestMethod]
        public void Test13()
        {
            Assert.AreEqual("https://developer.mozilla.org/ru/docs/JavaScript_шеллы", Core.Utility.JavaScriptDecodeURI("https://developer.mozilla.org/ru/docs/JavaScript_%D1%88%D0%B5%D0%BB%D0%BB%D1%8B"));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test14()
        {
            Core.Utility.JavaScriptDecodeURI("%E0%A4%A");
        }

        [TestMethod]
        public void Test15()
        {
            Assert.AreEqual(";,/?:@&=+$", Core.Utility.JavaScriptEncodeURI(";,/?:@&=+$"));
        }

        [TestMethod]
        public void Test16()
        {
            Assert.AreEqual("-_.!~*'()", Core.Utility.JavaScriptEncodeURI("-_.!~*'()"));
        }

        [TestMethod]
        public void Test17()
        {
            Assert.AreEqual("#", Core.Utility.JavaScriptEncodeURI("#"));
        }

        [TestMethod]
        public void Test18()
        {
            Assert.AreEqual("ABC%20abc%20123", Core.Utility.JavaScriptEncodeURI("ABC abc 123"));
        }

        [TestMethod]
        public void Test19()
        {
            Assert.AreEqual("%3B%2C%2F%3F%3A%40%26%3D%2B%24", Core.Utility.JavaScriptEncodeURIComponent(";,/?:@&=+$"));
        }

        [TestMethod]
        public void Test20()
        {
            Assert.AreEqual("-_.!~*'()", Core.Utility.JavaScriptEncodeURIComponent("-_.!~*'()"));
        }

        [TestMethod]
        public void Test21()
        {
            Assert.AreEqual("%23", Core.Utility.JavaScriptEncodeURIComponent("#"));
        }

        [TestMethod]
        public void Test22()
        {
            Assert.AreEqual("ABC%20abc%20123", Core.Utility.JavaScriptEncodeURIComponent("ABC abc 123"));
        }

        [TestMethod]
        public void Test23()
        {
            Assert.AreEqual("%F0%90%8F%BF", Core.Utility.JavaScriptEncodeURIComponent("\uD800\uDFFF"));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test24()
        {
            Core.Utility.JavaScriptEncodeURIComponent("\uD800");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test25()
        {
            Core.Utility.JavaScriptEncodeURIComponent("\uDFFF");
        }
        
        [TestMethod]
        public void Test26()
        {
            Assert.AreEqual("JavaScript_шеллы", Core.Utility.JavaScriptDecodeURIComponent("JavaScript_%D1%88%D0%B5%D0%BB%D0%BB%D1%8B"));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test27()
        {
            Core.Utility.JavaScriptDecodeURIComponent("%E0%A4%A");
        }

        [TestMethod]
        public void Test28()
        {
            Assert.AreEqual("https://developer.mozilla.org/docs/JavaScript%3A a_scripting_language", Core.Utility.JavaScriptDecodeURI("https://developer.mozilla.org/docs/JavaScript%3A%20a_scripting_language"));
        }

        [TestMethod]
        public void Test29()
        {
            Assert.AreEqual("https://developer.mozilla.org/docs/JavaScript: a_scripting_language", Core.Utility.JavaScriptDecodeURIComponent("https://developer.mozilla.org/docs/JavaScript%3A%20a_scripting_language"));
        }
    }
}
