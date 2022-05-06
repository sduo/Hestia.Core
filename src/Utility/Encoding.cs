using System;
using System.Text;

namespace Hestia.Core
{
    public static partial class Utility
    {
        public static void RegisterProvider()
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
        }

        public static Encoding GetEncoding(int codepage = 0,Encoding @default = null)
        {
            try
            {
                return Encoding.GetEncoding(codepage);
            }
            catch (NotSupportedException)
            {
                return @default;
            }
            catch (ArgumentException)
            {
                return @default;
            }
        }

        public static Encoding GetEncoding(string name,Encoding @default = null)
        {
            if (string.IsNullOrEmpty(name)) { return @default; }
            try
            {
                return Encoding.GetEncoding(name);
            }
            catch (ArgumentException)
            {
                return @default;
            }
        }


    }
}
