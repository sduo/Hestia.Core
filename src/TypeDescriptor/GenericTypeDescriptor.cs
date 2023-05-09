using System;
using System.Text.Json;

namespace Hestia.Core.TypeDescriptor
{
    public struct GenericTypeDescriptor : ITypeDescriptor
    {
        public string Name { get; private set; }

        public Type Type { get; private set; }

        public object ToObject(string value)
        {
            return JsonSerializer.Deserialize(value, Type, Utility.DefaultJsonSerializerOptions);
        }

        public Func<Type[], bool> Verification { get; private set; }

        public GenericTypeDescriptor(string name, Type type, Func<Type[], bool> verification = null) 
        {
            Name = name;
            Type = type;
            Verification = verification;
        }

        public void MakeGenericType(Type[] types)
        {
            Type = Type.MakeGenericType(types);
        }
    }
}
