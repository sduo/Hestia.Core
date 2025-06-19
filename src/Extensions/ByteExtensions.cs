using System;

namespace Hestia.Core
{
    public static class ByteExtensions
    {
        private static readonly byte[] LEADING_1_BITS_MAP = new byte[] { 0b0111_1111, 0b1011_1111, 0b1101_1111, 0b1110_1111, 0b1111_0111, 0b1111_1011, 0b1111_1101, 0b1111_1110, 0b1111_1111 };

        public static int GetLeadingOneBits(this byte value)
        {
            return Array.FindIndex(LEADING_1_BITS_MAP, x => value < x);
        }
    }
}
