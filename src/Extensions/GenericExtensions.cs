using System;
using System.Collections.Generic;
using System.Linq;

namespace Hestia.Core
{
    public static class GenericExtensions
    {
        public static TOut Transform<TIn, TOut>(this TIn source, Func<TIn, TOut> transformer) where TOut : class
        {
            if (source is null) { return null; }
            return transformer?.Invoke(source);
        }

        public static TOut? Transform<TIn, TOut>(this TIn source, Func<TIn, TOut?> transformer) where TOut : struct
        {
            if (source is null) { return null; }
            return transformer?.Invoke(source);
        }

        public static IEnumerable<T> Union<T>(this IEnumerable<T> first, params T[] second) 
        {
            first ??= [];
            if( second.Length == 0 ) { return first; }
            return Enumerable.Union(first, second);
        }        
    }
}
