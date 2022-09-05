using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

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
