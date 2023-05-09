using System;

namespace Hestia.Core.TypeDescriptor
{
    public struct BasicTypeDescriptor : ITypeDescriptor
    {
        public string Name { get; private set; }

        public Type Type { get; private set; }

        private Func<string, object> Converter { get; set; }

        public object ToObject(string value)
        {
            return Converter.Invoke(value);
        }      

        public BasicTypeDescriptor(string name, Type type, Func<string,  object> converter)
        {
            Name = name;
            Type = type;
            Converter = converter;
        }
    }
}
