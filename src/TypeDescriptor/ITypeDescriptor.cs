using System;
namespace Hestia.Core.TypeDescriptor
{
    public interface ITypeDescriptor
    {
        string Name { get; }
        Type Type { get; }
        object ToObject(string value);
    }
}
