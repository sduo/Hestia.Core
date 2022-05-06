using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hestia.Core
{
    public static class Utility
    {
        public static void RegisterProvider()
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
        }

        public static Encoding GetEncoding(int codepage = 0)
        {
            try
            {
                return Encoding.GetEncoding(codepage);
            }
            catch (NotSupportedException)
            {
                return null;
            }
            catch (ArgumentException)
            {
                return null;
            }
        }

        public static Encoding GetEncoding(string name = null)
        {
            if (string.IsNullOrEmpty(name)) { return Encoding.Default; }
            try
            {
                return Encoding.GetEncoding(name);
            }
            catch (ArgumentException)
            {
                return null;
            }
        }
    }
}
