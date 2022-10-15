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
            DefaultJsonSerializerOptions = new();
            SetDefaultJsonSerializerOptions(DefaultJsonSerializerOptions);            
        }

        public static void SetDefaultJsonSerializerOptions(JsonSerializerOptions options)
        {
            if(options is null) { return; }
            options.DefaultIgnoreCondition = JsonIgnoreCondition.Never;
            options.Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping;
            options.PropertyNamingPolicy = null;
            options.DictionaryKeyPolicy = null;
            options.PropertyNameCaseInsensitive = true;
            options.ReadCommentHandling = JsonCommentHandling.Skip;
            options.NumberHandling = JsonNumberHandling.AllowReadingFromString;            
            options.Converters.Add(DateTimeJsonConverter);
            options.Converters.Add(DateTimeOffsetJsonConverter);
            options.Converters.Add(DateOnlyJsonConverter);
            options.Converters.Add(TimeOnlyJsonConverter);
            options.Converters.Add(TimeSpanJsonConverter);
        }

        public static JsonElement? GetJsonElement(JsonElement? json, string property, JsonValueKind? kind)
        {
            if (json is null) { return null; }
            if (string.IsNullOrEmpty(property)) { return null; }
            if (!json.Value.TryGetProperty(property, out var value)) { return null; }
            if (kind.HasValue && value.ValueKind != kind.Value) { return null; }
            return value;
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
