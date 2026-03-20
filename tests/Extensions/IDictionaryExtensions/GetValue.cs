using Hestia.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Hestia.Core.Tests.Extensions.IDictionaryExtensions
{
    [TestClass]
    [ExcludeFromCodeCoverage]
    public sealed class GetValue
    {
        internal Dictionary<string, string> ClassClassDictionary = new() { { "null", null }, { "key", "value" } };
        internal Dictionary<string, int?> ClassNullableStructDictionary = new() { { "null", null }, { "0", 0 } };
        internal Dictionary<string, int> ClassStructDictionary = new() { { "0", 0 } };

        internal Dictionary<int, string> StructClassDictionary = new() { { 0, null }, { 1, "1" } };        
        internal Dictionary<int, int?> StructNullableStructDictionary = new() { { 0, null }, { 1, -1 } };
        internal Dictionary<int, int> StructStructDictionary = new() { { 1, -1 } };

        [TestMethod]
        public void Test1()
        {            
            Assert.AreEqual(null, (null as Dictionary<string, string>).GetValue(null));
        }


        [TestMethod]
        public void Test2()
        {
            Assert.AreEqual(null, new Dictionary<string, string>().GetValue(string.Empty));
        }

        [TestMethod]
        public void Test3()
        {
            Assert.AreEqual(null, ClassClassDictionary.GetValue(null));
        }

        [TestMethod]
        public void Test4()
        {
            Assert.AreEqual(null, ClassClassDictionary.GetValue("null"));
        }

        [TestMethod]
        public void Test5()
        {
            Assert.AreEqual("value", ClassClassDictionary.GetValue("key"));
        }

        [TestMethod]
        public void Test6()
        {
            Assert.AreEqual(null, ClassClassDictionary.GetValue("0"));
        }

        [TestMethod]
        public void Test7()
        {
            Assert.AreEqual(null, (null as Dictionary<string, int?>).GetValue(null));
        }

        [TestMethod]
        public void Test8()
        {
            Assert.AreEqual(null, new Dictionary<string, int?>().GetValue(string.Empty));
        }

        [TestMethod]
        public void Test9()
        {
            Assert.AreEqual(null, ClassNullableStructDictionary.GetValue(null));
        }

        [TestMethod]
        public void Test10()
        {
            Assert.AreEqual(null, ClassNullableStructDictionary.GetValue("null"));
        }

        [TestMethod]
        public void Test11()
        {
            Assert.AreEqual(0, ClassNullableStructDictionary.GetValue("0"));
        }

        [TestMethod]
        public void Test12()
        {
            Assert.AreEqual(null, ClassNullableStructDictionary.GetValue("key"));
        }

        [TestMethod]
        public void Test13()
        {
            Assert.AreEqual(null, (null as Dictionary<string, int>).GetValue(null));
        }

        [TestMethod]
        public void Test14()
        {
            Assert.AreEqual(null, new Dictionary<string, int>().GetValue(string.Empty));
        }

        [TestMethod]
        public void Test15()
        {
            Assert.AreEqual(null, ClassStructDictionary.GetValue(null));
        }

        [TestMethod]
        public void Test16()
        {
            Assert.AreEqual(0, ClassStructDictionary.GetValue("0"));
        }

        [TestMethod]
        public void Test17()
        {
            Assert.AreEqual(null, ClassStructDictionary.GetValue("key"));
        }

        [TestMethod]
        public void Test18()
        {
            Assert.AreEqual(null, (null as Dictionary<int, string>).GetValue(null));
        }

        [TestMethod]
        public void Test19()
        {
            Assert.AreEqual(null, new Dictionary<int, string>().GetValue(0));
        }

        [TestMethod]
        public void Test20()
        {
            Assert.AreEqual(null, StructClassDictionary.GetValue(null));
        }

        [TestMethod]
        public void Test21()
        {
            Assert.AreEqual(null, StructClassDictionary.GetValue(0));
        }

        [TestMethod]
        public void Test22()
        {
            Assert.AreEqual("1", StructClassDictionary.GetValue(1));
        }

        [TestMethod]
        public void Test23()
        {
            Assert.AreEqual(null, StructClassDictionary.GetValue(-1));
        }


        [TestMethod]
        public void Test24()
        {
            Assert.AreEqual(null, (null as Dictionary<int, int?>).GetValue(null));
        }

        [TestMethod]
        public void Test25()
        {
            Assert.AreEqual(null, new Dictionary<int, int?>().GetValue(0));
        }

        [TestMethod]
        public void Test26()
        {
            Assert.AreEqual(null, StructNullableStructDictionary.GetValue(null));
        }

        [TestMethod]
        public void Test27()
        {
            Assert.AreEqual(null, StructNullableStructDictionary.GetValue(0));
        }

        [TestMethod]
        public void Test28()
        {
            Assert.AreEqual(-1, StructNullableStructDictionary.GetValue(1));
        }

        [TestMethod]
        public void Test29()
        {
            Assert.AreEqual(null, StructNullableStructDictionary.GetValue(-1));
        }

        [TestMethod]
        public void Test30()
        {
            Assert.AreEqual(null, (null as Dictionary<int, int>).GetValue(null));
        }

        [TestMethod]
        public void Test31()
        {
            Assert.AreEqual(null, new Dictionary<int, int>().GetValue(0));
        }

        [TestMethod]
        public void Test32()
        {
            Assert.AreEqual(null, StructStructDictionary.GetValue(null));
        }

        [TestMethod]
        public void Test33()
        {
            Assert.AreEqual(null, StructStructDictionary.GetValue(0));
        }

        [TestMethod]
        public void Test34()
        {
            Assert.AreEqual(-1, StructStructDictionary.GetValue(1));
        }

        [TestMethod]
        public void Test35()
        {
            Assert.AreEqual(null, StructStructDictionary.GetValue(-1));
        }
    }
}
