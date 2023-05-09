using System;

namespace Hestia.Core.Type
{
    public class GenericType : BasicType
    {
        public Func<System.Type[], bool> Verification { get; private set; }

        public GenericType(string name, System.Type type, Func<System.Type[], bool> verification = null) : base(name, type)
        {
            Verification = verification;
        }
    }
}
