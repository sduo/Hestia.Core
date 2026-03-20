using System.Collections.Generic;

namespace Hestia.Core
{
    public static class IDictionaryClassClassExtensions
    {
        public static TValue GetValue<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, TKey key) where TKey : class where TValue : class
        {
            if (dictionary == null) { return null; }
            if (key == null) { return null; }
            if (dictionary.Count == 0) { return null; }
            return dictionary.TryGetValue(key, out var value) ? value : null;
        }            
    }

    public static class IDictionaryClassStructExtensions
    {
        public static TValue? GetValue<TKey, TValue>(this IDictionary<TKey, TValue?> dictionary, TKey key) where TKey : class where TValue : struct
        {
            if (dictionary == null) { return null; }
            if (key == null) { return null; }
            if (dictionary.Count == 0) { return null; }
            return dictionary.TryGetValue(key, out var value) ? value : null;
        }

        public static TValue? GetValue<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, TKey key) where TKey : class where TValue : struct
        {
            if (dictionary == null) { return null; }
            if (key == null) { return null; }
            if (dictionary.Count == 0) { return null; }
            return dictionary.TryGetValue(key, out var value) ? value : null;
        }
    }


    public static class IDictionaryStructClassExtensions
    {        
        public static TValue GetValue<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, TKey? key) where TKey : struct where TValue : class
        {
            if (dictionary == null) { return null; }
            if (dictionary.Count == 0) { return null; }
            if (key == null) { return null; }
            return dictionary.TryGetValue(key.Value, out var value) ? value : null;
        }
    }


    public static class IDictionaryStructStructExtensions
    {
        public static TValue? GetValue<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, TKey? key) where TKey : struct where TValue : struct
        {
            if (dictionary == null) { return null; }
            if (dictionary.Count == 0) { return null; }
            if (key == null) { return null; }
            return dictionary.TryGetValue(key.Value, out var value) ? value : null;
        }

        public static TValue? GetValue<TKey, TValue>(this IDictionary<TKey, TValue?> dictionary, TKey? key) where TKey : struct where TValue : struct
        {
            if (dictionary == null) { return null; }
            if (dictionary.Count == 0) { return null; }
            if(key == null) { return null; }
            return dictionary.TryGetValue(key.Value, out var value) ? value : null;
        }
    }
}
