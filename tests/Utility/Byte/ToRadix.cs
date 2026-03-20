using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics.CodeAnalysis;

namespace Hestia.Core.Tests.Utility
{
    [TestClass]
    [ExcludeFromCodeCoverage]
    public class ToRadix
    {

        private static readonly char[] RadixCharsetL1 = new string('0', 1).ToCharArray();
        private static readonly char[] RadixCharsetL257 = new string('0', 257).ToCharArray();

        [TestMethod]
        public void Test1()
        {
            Assert.ThrowsExactly<ArgumentNullException>(() =>
            {
                Core.Utility.ToRadix(null, Array.Empty<char>());
            });
        }

        [TestMethod]
        public void Test2()
        {
            Assert.ThrowsExactly<ArgumentNullException>(() =>
            {
                Core.Utility.ToRadix(Array.Empty<byte>(), (char[])null);
            });
        }

        [TestMethod]
        public void Test3()
        {
            Assert.ThrowsExactly<ArgumentOutOfRangeException>(() =>
            {
                Core.Utility.ToRadix(Array.Empty<byte>(), string.Empty);
            });

        }

        [TestMethod]
        public void Test4()
        {
            Assert.ThrowsExactly<ArgumentOutOfRangeException>(() =>
            {
                Core.Utility.ToRadix(Array.Empty<byte>(), RadixCharsetL1);
            });
        }

        [TestMethod]
        public void Test5()
        {
            Assert.ThrowsExactly<ArgumentOutOfRangeException>(() =>
            {
                Core.Utility.ToRadix(Array.Empty<byte>(), RadixCharsetL257);
            });
        }

        [TestMethod]
        public void Test6()
        {
            Assert.AreEqual("0", Core.Utility.ToRadix(new byte[] { byte.MinValue }, Core.Utility.RadixCharsetBin));
        }

        [TestMethod]
        public void Test7()
        {
            Assert.AreEqual("11111111", Core.Utility.ToRadix(new byte[] { byte.MaxValue }, Core.Utility.RadixCharsetBin));
        }

        [TestMethod]
        public void Test8()
        {
            Assert.AreEqual("0", Core.Utility.ToRadix(new byte[] { byte.MinValue }, Core.Utility.RadixCharsetOct));
        }

        [TestMethod]
        public void Test9()
        {
            Assert.AreEqual("377", Core.Utility.ToRadix(new byte[] { byte.MaxValue }, Core.Utility.RadixCharsetOct));
        }


        [TestMethod]
        public void Test10()
        {
            Assert.AreEqual("0", Core.Utility.ToRadix(new byte[] { byte.MinValue }, Core.Utility.RadixCharsetDec));
        }

        [TestMethod]
        public void Test11()
        {
            Assert.AreEqual("255", Core.Utility.ToRadix(new byte[] { byte.MaxValue }, Core.Utility.RadixCharsetDec));
        }

        [TestMethod]
        public void Test12()
        {
            Assert.AreEqual("0", Core.Utility.ToRadix(new byte[] { byte.MinValue }, Core.Utility.RadixCharsetHex));
        }

        [TestMethod]
        public void Test13()
        {
            Assert.AreEqual("FF", Core.Utility.ToRadix(new byte[] { byte.MaxValue }, Core.Utility.RadixCharsetHex));
        }

        [TestMethod]
        public void Test14()
        {
            Assert.AreEqual("0", Core.Utility.ToRadix(BitConverter.GetBytes(uint.MinValue), Core.Utility.RadixCharsetBin));
        }

        [TestMethod]
        public void Test15()
        {
            Assert.AreEqual("11111111111111111111111111111111", Core.Utility.ToRadix(BitConverter.GetBytes(uint.MaxValue), Core.Utility.RadixCharsetBin));
        }

        [TestMethod]
        public void Test16()
        {
            Assert.AreEqual("0", Core.Utility.ToRadix(BitConverter.GetBytes(uint.MinValue), Core.Utility.RadixCharsetOct));
        }

        [TestMethod]
        public void Test17()
        {
            Assert.AreEqual("37777777777", Core.Utility.ToRadix(BitConverter.GetBytes(uint.MaxValue), Core.Utility.RadixCharsetOct));
        }


        [TestMethod]
        public void Test18()
        {
            Assert.AreEqual("0", Core.Utility.ToRadix(BitConverter.GetBytes(uint.MinValue), Core.Utility.RadixCharsetDec));
        }

        [TestMethod]
        public void Test19()
        {
            Assert.AreEqual("4294967295", Core.Utility.ToRadix(BitConverter.GetBytes(uint.MaxValue), Core.Utility.RadixCharsetDec));
        }

        [TestMethod]
        public void Test20()
        {
            Assert.AreEqual("0", Core.Utility.ToRadix(BitConverter.GetBytes(uint.MinValue), Core.Utility.RadixCharsetHex));
        }

        [TestMethod]
        public void Test21()
        {
            Assert.AreEqual("FFFFFFFF", Core.Utility.ToRadix(BitConverter.GetBytes(uint.MaxValue), Core.Utility.RadixCharsetHex));
        }

        [TestMethod]
        public void Test22()
        {
            Assert.AreEqual("618NKnRomf56GFGFPsuU90u", Core.Utility.ToRadix(new byte[] { 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF }, "0123456789ABCDEFGHJKLMNPQRTUWXYacdefhijkmnoprstuwxyz".ToCharArray()));
        }
    }
}
