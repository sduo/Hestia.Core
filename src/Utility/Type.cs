using Hestia.Core.Type;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Hestia.Core
{
    public static partial class Utility
    {
        public static readonly List<BasicType> TypeMap = new() {
            new ("bool",typeof(bool)),
            new ("byte",typeof(byte)),
            new ("sbyte",typeof(sbyte)),
            new ("ushort",typeof(ushort)),
            new ("short",typeof(short)),
            new ("uint",typeof(uint)),
            new ("int",typeof(int)),
            new ("ulong",typeof(ulong)),
            new ("long",typeof(long)),
            new ("float",typeof(float)),
            new ("double",typeof(double)),
            new ("DateTime",typeof(DateTime)),
            new ("DateOnly",typeof(DateOnly)),
            new ("TimeOnly",typeof(TimeOnly)),
            new ("DateTimeOffset",typeof(DateTimeOffset)),
            new ("TimeSpan",typeof(TimeSpan)),
            new ("string",typeof(string)),
            new ("object",typeof(object)),
            new GenericType("list",typeof(List<>),(types)=>{ return types.Length == 1; }),
            new GenericType("dictionary",typeof(Dictionary<,>),(types)=>{ return types.Length == 2; })
        };

        public static System.Type BuildTypeByExpression(string expression)
        {
            if (string.IsNullOrEmpty(expression)) { throw new ArgumentNullException(nameof(expression)); }
            var stack = new Stack<char>(expression.ToCharArray());
            var ast = new Stack<System.Type>();

            while (true)
            {
                var token = GetExpressionNextToken(stack);
                if (token is null) { break; }
                if (token == ":")
                {
                    token = GetExpressionNextToken(stack);
                    var generic = GetTypeByName(token);
                    if (generic is not GenericType) { throw new ArgumentException($"The type of \"{token}\" in \"{expression}\" must be a generic type", nameof(expression)); }

                    var types = ast.ToArray();
                    ast.Clear();

                    var legal = ((GenericType)generic).Verification?.Invoke(types) ?? true;
                    if (!legal) { throw new ArgumentException($"The generic type of \"{token}\" in \"{expression}\" is illegal",nameof(expression)); }

                    ast.Push(generic.Type.MakeGenericType(types));
                    continue;
                }
                var basic = GetTypeByName(token);
                if(basic is not BasicType) { throw new ArgumentException($"The type of \"{token}\" in \"{expression}\" must be a basic type",nameof(expression)); }
                ast.Push(basic.Type);
            }

            if (ast.Count > 1) { throw new ArgumentException($"The root type of \"${expression}\" must be only one", nameof(expression)); }
            return ast.TryPop(out var type) ? type : throw new Exception();
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


        public static BasicType GetTypeByName(string name)
        {
            if (string.IsNullOrEmpty(name)) { throw new ArgumentNullException(nameof(name)); }
            var type = TypeMap.FirstOrDefault(x => string.Equals(x.Name, name, StringComparison.OrdinalIgnoreCase));
            return type is null ? throw new ArgumentException($"The type of \"{name}\" must be one of \"{string.Join(",",TypeMap.Select(x=>x.Name))}\"",nameof(name)) : type;
        }
    }
}
