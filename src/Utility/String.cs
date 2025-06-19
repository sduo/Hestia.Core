using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace Hestia.Core
{
    public static partial class Utility
    {
        private static readonly UTF8Encoding UTF8 = new(encoderShouldEmitUTF8Identifier: false, throwOnInvalidBytes: true);

        public static readonly IReadOnlySet<char> CHAR_SET_DEC_DIGIT = new HashSet<char>() { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

        public static readonly IReadOnlySet<char> CHAR_SET_HEX_DIGIT = new HashSet<char>(CHAR_SET_DEC_DIGIT.Union('A', 'B', 'C', 'D', 'E', 'F', 'a', 'b', 'c', 'd', 'e', 'f'));

        public static readonly IReadOnlySet<char> CHAR_SET_ALPHA = new HashSet<char>(CHAR_SET_HEX_DIGIT.Union(
            'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z',
            'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'
        ));

        public static readonly IReadOnlySet<char> ECMA_CHAR_SET_ASCII = new HashSet<char>(CHAR_SET_ALPHA.Union('_'));

        public static readonly IReadOnlySet<char> ECMA_CHAR_SET_UNESCAPED = new HashSet<char>(ECMA_CHAR_SET_ASCII.Union('@', '*', '+', '-', '.', '/'));

        public static readonly IReadOnlySet<char> ECMA_CHAR_SET_UNESCAPED_ALWAYS = new HashSet<char> (ECMA_CHAR_SET_ASCII.Union( '-', '.',  '!', '~', '*', '\'', '(', ')'));

        public static readonly IReadOnlySet<char> ECMA_CHAR_SET_EXTRA = new HashSet<char> { ';', '/', '?', ':', '@', '&', '=', '+', '$', ',', '#' };

        public static readonly IReadOnlySet<char> ECMA_CHAR_SET_EMPTY = new HashSet<char> { };        

        public static string Utf8HexEncode(string source)=> string.IsNullOrEmpty(source) ? source : source.Transform(Encoding.UTF8.GetBytes).Transform(Convert.ToHexString);

        public static string Utf8HexDecode(string source) => string.IsNullOrEmpty(source) ? source : source.Transform(Convert.FromHexString).Transform(Encoding.UTF8.GetString);

        public static string Utf8Base64Encode(string source) => string.IsNullOrEmpty(source) ? source : source.Transform(Encoding.UTF8.GetBytes).Transform(Convert.ToBase64String);

        public static string Utf8Base64Decode(string source) => string.IsNullOrEmpty(source) ? source : source.Transform(Convert.FromBase64String).Transform(Encoding.UTF8.GetString);

        /// <summary>
        /// JavaScriptEscape
        /// </summary>
        /// <param name="source"></param>
        /// <see cref="https://developer.mozilla.org/docs/Web/JavaScript/Reference/Global_Objects/escape"/>
        /// <seealso cref="https://tc39.es/ecma262/#sec-escape-string"/>
        /// <returns></returns>
        public static string JavaScriptEscape(string source)
        {
            if (string.IsNullOrEmpty(source)){ return source; }

            var target = new StringBuilder();
            var index = 0;

            while (index < source.Length)
            {
                var current = source[index];
                if (ECMA_CHAR_SET_UNESCAPED.Contains(current)) 
                { 
                    target.Append(current);
                }
                else
                {
                    var value = (ushort)current;
                    target.Append('%');
                    if (value < 256u) 
                    {
                        target.Append($"{value:X2}");
                    }
                    else
                    {                        
                        target.Append('u').Append($"{value:X4}");
                    }                        
                }
                index += 1;
            }
            return target.ToString();
        }

        /// <summary>
        /// JavaScriptUnescape
        /// </summary>
        /// <param name="source"></param>
        /// <see cref="https://developer.mozilla.org/docs/Web/JavaScript/Reference/Global_Objects/unescape"/>
        /// <seealso cref="https://tc39.es/ecma262/#sec-unescape-string"/>
        /// <returns></returns>
        public static string JavaScriptUnescape(string source)
        {
            if (string.IsNullOrEmpty(source)) { return source; }

            var target = new StringBuilder();
            var index = 0;
            while (index < source.Length)
            {
                var current = source[index];
                if ('%'.Equals(current))
                {
                    var hex = new char[4];                    
                    var offset = 0;
                    if (index + 5 < source.Length && 'u'.Equals(source[index + 1]))
                    {
                        hex[0] = source[index + 2];
                        hex[1] = source[index + 3];
                        hex[2] = source[index + 4];
                        hex[3] = source[index + 5];
                        offset = 5;
                    }
                    else if (index + 3 <= source.Length)
                    {
                        hex[0] = '0';
                        hex[1] = '0';
                        hex[2] = source[index + 1];
                        hex[3] = source[index + 2];
                        offset = 2;
                    }
                    if (hex.Length == 4 && hex.All(x=>CHAR_SET_HEX_DIGIT.Contains(x)))
                    {
                        var code = Convert.FromHexString(hex);
                        if (BitConverter.IsLittleEndian && code.Length == 2) { Array.Reverse(code); }
                        current = (char)BitConverter.ToUInt16(code);
                        index += offset;
                    }
                }
                target.Append(current);
                index += 1;
            }
            return target.ToString();
        }

        /// <summary>
        /// JavaScriptEncodeURI
        /// </summary>
        /// <param name="source"></param>
        /// <see cref="https://developer.mozilla.org/docs/Web/JavaScript/Reference/Global_Objects/encodeURI"/>
        /// <seealso cref="https://tc39.es/ecma262/#sec-encodeuri-uri"/>
        /// <returns></returns>
        public static string JavaScriptEncodeURI(string source)
        {
            return JavaScriptEncode(source, ECMA_CHAR_SET_EXTRA);
        }

        /// <summary>
        /// JavaScriptDecodeURI
        /// </summary>
        /// <param name="source"></param>
        /// <see cref="https://developer.mozilla.org/docs/Web/JavaScript/Reference/Global_Objects/decodeURI"/>
        /// <seealso cref="https://tc39.es/ecma262/#sec-decodeuri-encodeduri"/>
        /// <returns></returns>
        public static string JavaScriptDecodeURI(string source)
        {            
            return JavaScriptDecode(source, ECMA_CHAR_SET_EXTRA);
        }

        /// <summary>
        /// JavaScriptEncodeURIComponent
        /// </summary>
        /// <param name="source"></param>
        /// <see cref="https://developer.mozilla.org/docs/Web/JavaScript/Reference/Global_Objects/encodeURIComponent"/>
        /// <seealso cref="https://tc39.es/ecma262/#sec-encodeuricomponent-uricomponent"/>
        /// <returns></returns>
        public static string JavaScriptEncodeURIComponent(string source)
        {
            return JavaScriptEncode(source, ECMA_CHAR_SET_EMPTY);
        }

        /// <summary>
        /// JavaScriptDecodeURIComponent
        /// </summary>
        /// <param name="source"></param>
        /// <see cref="https://developer.mozilla.org/docs/Web/JavaScript/Reference/Global_Objects/decodeURIComponent"/>
        /// <seealso cref="https://tc39.es/ecma262/#sec-decodeuricomponent-encodeduricomponent"/>
        /// <returns></returns>
        public static string JavaScriptDecodeURIComponent(string source)
        {
            return JavaScriptDecode(source, ECMA_CHAR_SET_EMPTY);
        }        

        /// <summary>
        /// ECMA262-ENCODE
        /// </summary>
        /// <see cref="https://tc39.es/ecma262/#sec-encode"/>
        /// <returns></returns>

        public static string JavaScriptEncode(string source, IEnumerable<char> ExtraUnescaped)
        {
            if(ExtraUnescaped is null) { throw new ArgumentNullException(nameof(ExtraUnescaped)); }

            var target = new StringBuilder();
            var index = 0;

            while (index < source.Length)
            {
                var current = source[index];
                if (ECMA_CHAR_SET_UNESCAPED_ALWAYS.Contains(current) || ExtraUnescaped.Contains(current))
                {
                    target.Append(current);
                    index += 1;
                }
                else
                {
                    var code = new char[2];
                    var offset = 0;
                    if (!char.IsHighSurrogate(current) && !char.IsLowSurrogate(current))
                    {
                        code[0] = current;
                        code[1] = char.MinValue;
                        offset = 1;
                    }
                    else if(index + 1 < source.Length && char.IsSurrogatePair(current, source[index + 1]))
                    {
                        code[0] = current;
                        code[1] = source[index + 1];
                        offset = 2;
                    }
                    else
                    {
                        throw new ArgumentException($"Input malformed at char {index}", nameof(source));
                    }

                    try
                    {
                        var utf8 = UTF8.GetBytes(code, 0, offset);
                        foreach (var hex in utf8)
                        {
                            target.Append('%').Append($"{hex:X2}");
                        }                        
                    }
                    catch (Exception ex)
                    {
                        throw new ArgumentException($"Input malformed at char {index}", nameof(source), ex);
                    }

                    index += offset;
                }
            }
            return target.ToString();
        }

        /// <summary>
        /// ECMA262-DECODE
        /// </summary>
        /// <see cref="https://tc39.es/ecma262/#sec-decode"/>
        /// <returns></returns>
        public static string JavaScriptDecode(string source, IEnumerable<char> PreserveEscapeSet)
        {
            if(PreserveEscapeSet is null) { throw new ArgumentNullException(nameof(PreserveEscapeSet)); }

            var target = new StringBuilder();
            var index = 0;

            while (index < source.Length) 
            { 
                var current = source[index];
                if ('%'.Equals(current))
                {
                    if(index + 3 > source.Length) { throw new ArgumentException($"Input malformed at char {index}", nameof(source)); }
                    var escape = source[index..(index + 3)];
                    var hex = new char[2];
                    hex[0] = source[index + 1];
                    hex[1] = source[index + 2];
                    if (!byte.TryParse(hex, NumberStyles.HexNumber, null, out var code))
                    {
                        throw new ArgumentException($"Input malformed at char {index}", nameof(source));
                    }
                    index += 2;
                    var count = code.GetLeadingOneBits();
                    if (count == 0)
                    {
                        var ascii = (char)code;
                        target.Append(PreserveEscapeSet.Contains(ascii) ? escape : ascii);
                    }
                    else
                    {
                        if (count == 1 || count > 4)
                        {
                            throw new ArgumentException($"Input malformed at char {index}", nameof(source));
                        }
                        var utf8 = new byte[count];
                        utf8[0] =  code;
                        var jump = 1;
                        while (jump < count)
                        {
                            index += 1;
                            if (index + 3 > source.Length) { throw new ArgumentException($"Input malformed at char {index}", nameof(source)); }
                            if (!'%'.Equals(source[index])) { throw new ArgumentException($"Input malformed at char {index}", nameof(source)); }

                            var data = new char[2];
                            data[0] = source[index + 1];
                            data[1] = source[index + 2];

                            if (!byte.TryParse(data, NumberStyles.HexNumber, null, out var next))
                            {
                                throw new ArgumentException($"Input malformed at char {index}", nameof(source));
                            }
                            
                            utf8[jump] = next;
                            index += 2;
                            jump += 1;
                        }

                        try
                        {
                            var text = UTF8.GetString(utf8);
                            target.Append(text);
                        }
                        catch (Exception ex)
                        {
                            throw new ArgumentException($"Input malformed at char {index}", nameof(source), ex);
                        }
                    }
                }
                else
                {
                    target.Append(current);
                }
                index += 1;
            }
            return target.ToString(); 
        }        
    }
}
