using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Hestia.Core.Json.Converters
{
    public class StructJsonConverter<T> : JsonConverter<T> where T : struct
    {
        
        public Func<string, T?> Parser { get;private set; }

        public Func<T, string> Formatter { get; private set; }

        public StructJsonConverter(Func<string,T?> parser, Func<T,string> formatter)
        {
            Parser = parser;
            Formatter = formatter;
        }

        public override T Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if(Parser == null) { throw new NotImplementedException(); }
            return Parser.Invoke(reader.GetString()) ?? throw new Exception();
        }

        public override void Write(Utf8JsonWriter writer, T value, JsonSerializerOptions options)
        {
            if(Formatter == null) { throw new NotImplementedException(); }
            writer.WriteStringValue(Formatter.Invoke(value));
        }
    }
}
