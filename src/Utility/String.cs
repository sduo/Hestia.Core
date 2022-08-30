using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hestia.Core
{
    public static partial class Utility
    {
        public static string Transform(string source, Func<string, byte[]> decoder, Func<byte[], string> encoder)
        {
            if(decoder == null) { throw new ArgumentNullException(nameof(decoder)); }
            if(encoder == null) { throw new ArgumentNullException(nameof(encoder)); }
            if (string.IsNullOrEmpty(source)) { return source; }
            return encoder.Invoke(decoder.Invoke(source));
        }

        public static string Utf8HexEncode(string source)=> Transform(source, Encoding.UTF8.GetBytes, Convert.ToHexString);

        public static string Utf8HexDecode(string source) => Transform(source, Convert.FromHexString, Encoding.UTF8.GetString);

        public static string Utf8Base64Encode(string source) => Transform(source, Encoding.UTF8.GetBytes, Convert.ToBase64String);

        public static string Utf8Base64Decode(string source) => Transform(source, Convert.FromBase64String,Encoding.UTF8.GetString);
    }
}
