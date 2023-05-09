using Hestia.Core.TypeDescriptor;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Hestia.Core
{
    public static partial class Utility
    {
        public static readonly List<ITypeDescriptor> TypeDescriptorList = new() {
            new BasicTypeDescriptor("bool",typeof(bool),(x)=>{ return x.ToBoolean(); }),   
            new BasicTypeDescriptor("byte",typeof(byte),(x)=>{ return x.ToByte(); }),
            new BasicTypeDescriptor("sbyte",typeof(sbyte),(x)=>{ return x.ToSignedByte(); }),
            new BasicTypeDescriptor("ushort",typeof(ushort),(x)=>{ return x.ToUnsignedShort(); }),
            new BasicTypeDescriptor("short",typeof(short),(x)=>{ return x.ToShort(); }),
            new BasicTypeDescriptor("uint",typeof(uint),(x)=>{ return x.ToUnsignedInt(); }),
            new BasicTypeDescriptor("int",typeof(int),(x)=>{ return x.ToInt(); }),
            new BasicTypeDescriptor("ulong",typeof(ulong),(x)=>{ return x.ToUnsignedLong(); }),
            new BasicTypeDescriptor("long",typeof(long),(x)=>{ return x.ToLong(); }),
            new BasicTypeDescriptor("float",typeof(float),(x)=>{ return x.ToFloat(); }),
            new BasicTypeDescriptor("double",typeof(double),(x)=>{ return x.ToDouble(); }),
            new BasicTypeDescriptor("DateTime",typeof(DateTime),(x)=>{ return x.ToDateTime(); }),
            new BasicTypeDescriptor("DateOnly",typeof(DateOnly),(x)=>{ return x.ToDateOnly(); }),
            new BasicTypeDescriptor("TimeOnly",typeof(TimeOnly),(x)=>{ return x.ToTimeOnly(); }),
            new BasicTypeDescriptor("DateTimeOffset",typeof(DateTimeOffset),(x)=>{ return x.ToDateTimeOffset(); }),
            new BasicTypeDescriptor("TimeSpan",typeof(TimeSpan),(x)=>{ return x.ToTimeSpan(); }),
            new BasicTypeDescriptor("string",typeof(string),(x)=>{ return x; }),
            new BasicTypeDescriptor("object",typeof(object),(x)=>{ throw new NotSupportedException(); }),
            new GenericTypeDescriptor("list",typeof(List<>),(generic)=>{ return generic.Length == 1; }),
            new GenericTypeDescriptor("dictionary",typeof(Dictionary<,>),(generic)=>{ return generic.Length == 2; })
        };

        public static ITypeDescriptor BuildTypeDescriptorByExpression(string expression)
        {
            if (string.IsNullOrEmpty(expression)) { throw new ArgumentNullException(nameof(expression)); }

            var stack = new Stack<char>(expression.ToCharArray());            
            var ast = new Stack<ITypeDescriptor>();

            while (true)
            {
                var token = GetExpressionNextToken(stack);
                if (token is null) { break; }
                if (token == ":")
                {
                    token = GetExpressionNextToken(stack);
                    var generic = (GenericTypeDescriptor)GetTypeDescriptorByName(token);

                    var types = ast.Select(x=>x.Type).ToArray();
                    ast.Clear();                    

                    var legal = generic.Verification?.Invoke(types) ?? true;
                    if (!legal) { throw new ArgumentException($"The generic type of \"{token}\" in \"{expression}\" is illegal", nameof(expression)); }                    

                    generic.MakeGenericType(types);
                    ast.Push(generic);
                    continue;
                }
                var basic = (BasicTypeDescriptor)GetTypeDescriptorByName(token);
                ast.Push(basic);
            }

            if (ast.Count > 1) { throw new ArgumentException($"The root type of \"${expression}\" must be only one", nameof(expression)); }
            return ast.Pop();
        }


        private static string GetExpressionNextToken(Stack<char> stack)
        {
            var token = new Stack<char>();
            while (stack.TryPop(out var c))
            {
                if (c == ':')
                {
                    if (token.Count == 0)
                    {
                        token.Push(c);
                    }
                    else
                    {
                        stack.Push(c);
                    }
                    break;
                }
                if (c == ',')
                {
                    break;
                }
                token.Push(c);
            }
            return token.Count == 0 ? null : new string(token.ToArray());
        }               


        private static ITypeDescriptor GetTypeDescriptorByName(string name)
        {
            if (string.IsNullOrEmpty(name)) { throw new ArgumentNullException(nameof(name)); }
            var type = TypeDescriptorList.First(x => string.Equals(x.Name, name, StringComparison.OrdinalIgnoreCase));
            return type;
        }
    }
}
