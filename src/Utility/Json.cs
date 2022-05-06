using Hestia.Core.Json.Converters;
using System;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Hestia.Core
{
    public static partial class Utility
    {
        public static JsonSerializerOptions DefaultJsonSerializerOptions { get; private set; }
        public static readonly StructJsonConverter<DateTime> DateTimeJsonConverter = new(x => x.ToDateTime(), x => x.ToString("yyyy-MM-dd HH:mm:ss"));
        public static readonly StructJsonConverter<DateTimeOffset> DateTimeOffsetJsonConverter = new(x => x.ToDateTimeOffset(), x => x.ToString("yyyy-MM-dd HH:mm:ss"));
        public static readonly StructJsonConverter<DateOnly> DateOnlyJsonConverter = new(x => x.ToDateOnly(), x => x.ToString("yyyy-MM-dd"));
        public static readonly StructJsonConverter<TimeOnly> TimeOnlyJsonConverter = new(x => x.ToTimeOnly(), x => x.ToString("HH:mm:ss"));
        public static readonly StructJsonConverter<TimeSpan> TimeSpanJsonConverter = new(x => x.ToTimeSpan(), x => x.ToString("G"));


        static Utility()
        {
            DefaultJsonSerializerOptions = new()
            {
                DefaultIgnoreCondition = JsonIgnoreCondition.Never,
                Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
            };
            DefaultJsonSerializerOptions.Converters.Add(DateTimeJsonConverter);
            DefaultJsonSerializerOptions.Converters.Add(DateTimeOffsetJsonConverter);
            DefaultJsonSerializerOptions.Converters.Add(DateOnlyJsonConverter);
            DefaultJsonSerializerOptions.Converters.Add(TimeOnlyJsonConverter);
            DefaultJsonSerializerOptions.Converters.Add(TimeSpanJsonConverter);
        }

        public static string ToJson<T>(T obj, JsonSerializerOptions options = null)
        {
            return JsonSerializer.Serialize(obj, options ?? DefaultJsonSerializerOptions);
        }

        public static T FromJson<T>(string json, JsonSerializerOptions options = null)
        {
            return JsonSerializer.Deserialize<T>(json, options ?? DefaultJsonSerializerOptions);
        }
    }
}
