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
            if (first is null && second is null) { return null; }
            if((first is null || first.Any() == false) && second is not null ) { return second; }
            if(first is not null && (second is null || second.Length == 0)) { return first; }
            return Enumerable.Union(first, second);
        }        
    }
}
