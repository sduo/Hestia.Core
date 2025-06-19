using System;
using System.Collections.Generic;
using System.Linq;

namespace Hestia.Core
{
    public static class GenericExtensions
    {
        public static TOut Transform<TIn,TOut>(this TIn source, Func<TIn, TOut> transformer)
        {
            if(transformer == null) { throw new ArgumentNullException(nameof(transformer)); }
            if(source == null) { throw new ArgumentNullException(nameof(transformer)); }
            return transformer.Invoke(source);
        }

        public static IEnumerable<T> Union<T>(this IEnumerable<T> first, params T[] second) 
        {
            if (first == null) { throw new ArgumentNullException(nameof(first)); }
            if( second.Length == 0 ) { return first; }
            return Enumerable.Union(first, second);
        }        
    }
}
