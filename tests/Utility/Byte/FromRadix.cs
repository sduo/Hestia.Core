using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics.CodeAnalysis;

namespace Hestia.Core.Tests.Utility
{
    [TestClass]
    [ExcludeFromCodeCoverage]
    public class FromRadix
    {

        private static readonly string RadixCharsetL1 = new('0', 1);
        private static readonly string RadixCharsetL257 = new('0', 257);

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Test1()
        {
            Core.Utility.FromRadix(null, null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Test2()
        {
            Core.Utility.FromRadix(string.Empty, null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Test3()
        {
            Core.Utility.FromRadix(string.Empty, string.Empty);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Test4()
        {
            Core.Utility.FromRadix(string.Empty, RadixCharsetL1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Test5()
        {            
            Core.Utility.FromRadix(string.Empty, RadixCharsetL257);
        }

        [TestMethod]        
        public void Test6()
        {
            Assert.AreEqual("00",Convert.ToHexString(Core.Utility.FromRadix("0", Core.Utility.RadixCharsetBin)));
        }

        [TestMethod]
        public void Test7()
        {
            Assert.AreEqual("FF", Convert.ToHexString(Core.Utility.FromRadix("11111111", Core.Utility.RadixCharsetBin)));
        }

        [TestMethod]
        public void Test8()
        {
            Assert.AreEqual("FF", Convert.ToHexString(Core.Utility.FromRadix("377", Core.Utility.RadixCharsetOct)));
        }


        [TestMethod]
        public void Test9()
        {
            Assert.AreEqual("FF", Convert.ToHexString(Core.Utility.FromRadix("255", Core.Utility.RadixCharsetDec)));
        }


        [TestMethod]
        public void Test10()
        {
            Assert.AreEqual("FF", Convert.ToHexString(Core.Utility.FromRadix("FF", Core.Utility.RadixCharsetHex)));
        }

        [TestMethod]
        public void Test11()
        {
            Assert.AreEqual("FFFFFFFF", Convert.ToHexString(Core.Utility.FromRadix("11111111111111111111111111111111", Core.Utility.RadixCharsetBin)));
        }

        [TestMethod]
        public void Test12()
        {
            Assert.AreEqual("FFFFFFFF", Convert.ToHexString(Core.Utility.FromRadix("37777777777", Core.Utility.RadixCharsetOct)));
        }


        [TestMethod]
        public void Test13()
        {
            Assert.AreEqual("FFFFFFFF", Convert.ToHexString(Core.Utility.FromRadix("4294967295", Core.Utility.RadixCharsetDec)));
        }

        [TestMethod]
        public void Test14()
        {
            Assert.AreEqual("FFFFFFFF", Convert.ToHexString(Core.Utility.FromRadix("FFFFFFFF", Core.Utility.RadixCharsetHex)));
        }

        [TestMethod]
        public void Test15()
        {
            Assert.AreEqual("FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF", Convert.ToHexString(Core.Utility.FromRadix("618NKnRomf56GFGFPsuU90u", "0123456789ABCDEFGHJKLMNPQRTUWXYacdefhijkmnoprstuwxyz")));
        }
    }
}
