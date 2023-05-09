using System;

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
    }
}
