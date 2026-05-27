using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Hestia.Core.Json.Converters
{
    public class StructJsonConverter<T>(Func<string, T?> parser, Func<T, string> formatter) : JsonConverter<T> where T : struct
    {

        public Func<string, T?> Parser { get; private set; } = parser;

        public Func<T, string> Formatter { get; private set; } = formatter;

        public override T Read(ref Utf8JsonReader reader, Type convert, JsonSerializerOptions options)
        {
            if(Parser == null) { throw new NotImplementedException(); }
            return Parser.Invoke(reader.GetString()) ?? throw new InvalidCastException();
        }

        public override void Write(Utf8JsonWriter writer, T value, JsonSerializerOptions options)
        {
            if(Formatter == null) { throw new NotImplementedException(); }
            writer.WriteStringValue(Formatter.Invoke(value) ?? throw new InvalidCastException());
        }
    }
}
