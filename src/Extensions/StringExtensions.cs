using System;
using System.Globalization;

namespace Hestia.Core
{
    public static class StringExtensions
    {
        public static bool? ToBoolean(this string source) 
        { 
            return bool.TryParse(source, out bool value) == true ? value : null;
        }
        public static Guid? ToGuid(this string source) => source.ToGuid("D", "N","B","P");
        public static Guid? ToGuid(this string source, params string[] formats)
        {
            foreach (var format in formats)
            {
                if (Guid.TryParseExact(source, format, out Guid value) == true)
                {
                    return value;
                }
            }
            return null;
        }

        public static T? ToEnum<T>(this string source, bool ignoreCase = true, bool isDefined = true) where T : struct, Enum
        {
            return Enum.TryParse(source, ignoreCase, out T value) && (!isDefined || Enum.IsDefined(value)) ? value : null;
        }

        public static TimeSpan? ToTimeSpan(this string source) => source.ToTimeSpan(TimeSpanStyles.None, null, "c", "g", "G");
        public static TimeSpan? ToTimeSpan(this string source, TimeSpanStyles style, IFormatProvider provider, params string[] formats)
        {
            return TimeSpan.TryParseExact(source, formats, provider, style, out TimeSpan value) == true ? value : null;
        }


        public delegate bool NumberParser<T>(string source, NumberStyles style, IFormatProvider provider, out T value);
        public static byte? ToByte(this string source,bool hex = false) => source.ToNumber<byte>(byte.TryParse, hex ? NumberStyles.AllowHexSpecifier : NumberStyles.None, null);

        public static sbyte? ToSignedByte(this string source) => source.ToNumber<sbyte>(sbyte.TryParse, NumberStyles.AllowLeadingSign , null);
        public static Half? ToHalf(this string source) => source.ToNumber<Half>(Half.TryParse, NumberStyles.AllowThousands | NumberStyles.AllowLeadingSign | NumberStyles.AllowExponent | NumberStyles.AllowDecimalPoint, null);
        public static float? ToFloat(this string source) => source.ToNumber<float>(float.TryParse, NumberStyles.AllowThousands | NumberStyles.AllowLeadingSign | NumberStyles.AllowExponent | NumberStyles.AllowDecimalPoint, null);
        public static double? ToDouble(this string source) => source.ToNumber<double>(double.TryParse, NumberStyles.AllowThousands | NumberStyles.AllowLeadingSign | NumberStyles.AllowExponent | NumberStyles.AllowDecimalPoint, null);
        public static decimal? ToDecimal(this string source) => source.ToNumber<decimal>(decimal.TryParse, NumberStyles.AllowThousands | NumberStyles.AllowLeadingSign | NumberStyles.AllowExponent | NumberStyles.AllowDecimalPoint, null);
        public static short? ToShort(this string source) => source.ToNumber<short>(short.TryParse, NumberStyles.AllowThousands | NumberStyles.AllowLeadingSign | NumberStyles.AllowExponent | NumberStyles.AllowDecimalPoint, null);
        public static ushort? ToUnsignedShort(this string source) => source.ToNumber<ushort>(ushort.TryParse, NumberStyles.AllowThousands | NumberStyles.AllowExponent | NumberStyles.AllowDecimalPoint, null);
        public static int? ToInt(this string source) => source.ToNumber<int>(int.TryParse, NumberStyles.AllowThousands | NumberStyles.AllowLeadingSign | NumberStyles.AllowExponent | NumberStyles.AllowDecimalPoint, null);
        public static uint? ToUnsignedInt(this string source) => source.ToNumber<uint>(uint.TryParse, NumberStyles.AllowThousands | NumberStyles.AllowExponent | NumberStyles.AllowDecimalPoint, null);
        public static long? ToLong(this string source) => source.ToNumber<long>(long.TryParse, NumberStyles.AllowThousands | NumberStyles.AllowLeadingSign | NumberStyles.AllowExponent | NumberStyles.AllowDecimalPoint, null);
        public static ulong? ToUnsignedLong(this string source) => source.ToNumber<ulong>(ulong.TryParse, NumberStyles.AllowThousands | NumberStyles.AllowExponent | NumberStyles.AllowDecimalPoint, null);
        public static T? ToNumber<T>(this string source, NumberParser<T> parser, NumberStyles style, IFormatProvider provider) where T : struct
        {
            return parser?.Invoke(source, style, provider, out T value) == true ? value : null;
        }

        public delegate bool DateTimeParser<T>(string source, string[] format, IFormatProvider provider, DateTimeStyles style, out T value);
        public static DateTime? ToDateTime(this string source) => source.ToDateTime<DateTime>(DateTime.TryParseExact, DateTimeStyles.None, null, "yyyy-MM-dd HH:mm:ss", "yyyyMMddHHmmss", "yyyy-MM-dd", "yyyyMMdd", "yyyy-MM-dd HH:mm:ss.fffffff", "yyyyMMddHHmmssfffffff");
        public static DateTimeOffset? ToDateTimeOffset(this string source) => source.ToDateTime<DateTimeOffset>(DateTimeOffset.TryParseExact, DateTimeStyles.None, null, "yyyy-MM-dd HH:mm:ss", "yyyyMMddHHmmss", "yyyy-MM-dd", "yyyyMMdd", "yyyy-MM-dd HH:mm:ss.fffffff", "yyyyMMddHHmmssfffffff");
        public static DateOnly? ToDateOnly(this string source) => source.ToDateTime<DateOnly>(DateOnly.TryParseExact, DateTimeStyles.None, null, "yyyy-MM-dd", "yyyyMMdd");
        public static TimeOnly? ToTimeOnly(this string source) => source.ToDateTime<TimeOnly>(TimeOnly.TryParseExact, DateTimeStyles.None, null, "HH:mm:ss", "HHmmss", "HH:mm:ss.fffffff", "HHmmssfffffff");
        public static T? ToDateTime<T>(this string source, DateTimeParser<T> parser, DateTimeStyles style, IFormatProvider provider, params string[] formats) where T : struct
        {
            return parser?.Invoke(source, formats, provider, style, out T value) == true ? value : null;
        }        
    }
}
