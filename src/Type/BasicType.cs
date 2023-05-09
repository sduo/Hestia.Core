namespace Hestia.Core.Type
{
    public class BasicType
    {
        public string Name { get;private set; }

        public System.Type Type { get; private set; }        

        public BasicType(string name, System.Type type)
        {
            Name = name;
            Type = type;            
        }
    }
}
