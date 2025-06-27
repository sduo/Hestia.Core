using System;
using System.Collections.Generic;
using System.Linq;

namespace Hestia.Core
{
    public static partial class Utility
    {
        public static readonly string RadixCharsetBin = "01";
        public static readonly string RadixCharsetOct = "01234567";
        public static readonly string RadixCharsetDec = "0123456789";
        public static readonly string RadixCharsetHex = "0123456789ABCDEF";

        public static string ToRadix(byte[] array, string charset)
        {
            if (array == null) { throw new ArgumentNullException(nameof(array)); }
            if (charset == null) { throw new ArgumentNullException(nameof(charset)); }

            int radix = charset.Length;
            if (radix < 2 || radix > 256 ) {  throw new ArgumentOutOfRangeException(nameof(charset)); }
            
            if (array.Length == 0 || array.All(x=> x==0x00)) { return charset[0].ToString(); }                

            var current = new List<byte>(array);
            var result = new Stack<char>();

            while (!current.All(x=> x == 0x00))
            {
                current = Divide(current, radix, out int remainder);
                result.Push(charset[remainder]);
            }
            
            return new string(result.ToArray());
        }       

        private static List<byte> Divide(IEnumerable<byte> number, int radix, out int remainder)
        {
            var quotient = new List<byte>();
            int carry = 0;
            bool zero = true;

            foreach (byte current in number)
            {
                int x = carry * 256 + current;
                int q = x / radix;
                carry = x % radix;

                // 跳过前导零
                if (zero && q == 0) { continue; }

                quotient.Add((byte)q);
                zero = false;
            }

            // 处理全零结果
            if (quotient.Count == 0) {quotient.Add(0);}

            remainder = carry;
            return quotient;
        }

        public static byte[] FromRadix(string text,  string charset)
        {
            if (text == null) { throw new ArgumentNullException(nameof(text)); }
            if (charset == null) { throw new ArgumentNullException(nameof(charset)); }

            int radix = charset.Length;
            if (radix < 2 || radix > 256) {  throw new ArgumentOutOfRangeException(nameof(charset));}

            if (string.Empty.Equals(text)) { return new byte[] { 0 }; }

            var map = new Dictionary<char, int>();
            for (int index = 0; index < charset.Length; index++)
            {
                if (map.ContainsKey(charset[index])) { throw new ArgumentException(nameof(charset)); }                    
                map.Add(charset[index],index);
            }

            var digits = new List<int>(text.Select(x=>map.TryGetValue(x,out var digit) ? digit : throw new ArgumentOutOfRangeException(nameof(text))));

            var result = new List<byte>() { 0 };

            foreach (int digit in digits)
            {
                int carry = 0;
                for (int index = 0; index < result.Count; index++)
                {
                    int x = result[index] * radix + carry;
                    result[index] = (byte)(x & 0xFF); 
                    carry = x >> 8;
                }

                while (carry > 0)
                {
                    result.Add((byte)(carry & 0xFF));
                    carry >>= 8;
                }

                carry = digit;
                for (int index = 0; index < result.Count && carry > 0; index++)
                {
                    int x = result[index] + carry;
                    result[index] = (byte)(x & 0xFF);
                    carry = x >> 8;
                }

                if (carry > 0)
                {
                    result.Add((byte)carry);
                }
            }

            result.Reverse();

            return result.Count ==1 ? result.ToArray() : result.SkipWhile(x=>x == 0x00).ToArray();
        }
    }
}
