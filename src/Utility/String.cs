using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hestia.Core
{
    public static partial class Utility
    {        
        public static string Utf8HexEncode(string source)=> string.IsNullOrEmpty(source) ? source : source.Transform(Encoding.UTF8.GetBytes).Transform(Convert.ToHexString);

        public static string Utf8HexDecode(string source) => string.IsNullOrEmpty(source) ? source : source.Transform(Convert.FromHexString).Transform(Encoding.UTF8.GetString);

        public static string Utf8Base64Encode(string source) => string.IsNullOrEmpty(source) ? source : source.Transform(Encoding.UTF8.GetBytes).Transform(Convert.ToBase64String);

        public static string Utf8Base64Decode(string source) => string.IsNullOrEmpty(source) ? source : source.Transform(Convert.FromBase64String).Transform(Encoding.UTF8.GetString);
    }
}
