using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics.CodeAnalysis;

namespace Hestia.Core.Tests.Utility
{
    [TestClass]
    [ExcludeFromCodeCoverage]
    public class FromRadix
    {

        private static readonly char[] RadixCharsetL1 = new string('0', 1).ToCharArray();
        private static readonly char[] RadixCharsetL257 = new string('0', 257).ToCharArray();

        [TestMethod]
        public void Test1()
        {
            Assert.ThrowsExactly<ArgumentNullException>(() =>
            {
                Core.Utility.FromRadix(null, Array.Empty<char>());
            });
        }

        [TestMethod]
        public void Test2()
        {
            Assert.ThrowsExactly<ArgumentNullException>(() =>
            {
                Core.Utility.FromRadix(string.Empty, (char[])null);
            });

        }

        [TestMethod]
        public void Test3()
        {
            Assert.ThrowsExactly<ArgumentOutOfRangeException>(() =>
            {
                Core.Utility.FromRadix(string.Empty, string.Empty.ToCharArray());
            });
        }

        [TestMethod]
        public void Test4()
        {
            Assert.ThrowsExactly<ArgumentOutOfRangeException>(() =>
            {
                Core.Utility.FromRadix(string.Empty, RadixCharsetL1);
            });
        }

        [TestMethod]
        public void Test5()
        {
            Assert.ThrowsExactly<ArgumentOutOfRangeException>(() =>
            {
                Core.Utility.FromRadix(string.Empty, RadixCharsetL257);
            });
        }

        [TestMethod]
        public void Test6()
        {
            Assert.AreEqual("00", Convert.ToHexString(Core.Utility.FromRadix("0", Core.Utility.RadixCharsetBin)));
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
            Assert.AreEqual("FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF", Convert.ToHexString(Core.Utility.FromRadix("618NKnRomf56GFGFPsuU90u", "0123456789ABCDEFGHJKLMNPQRTUWXYacdefhijkmnoprstuwxyz".ToCharArray())));
        }
    }
}
