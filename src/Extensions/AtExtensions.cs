using System.Collections.Generic;

namespace Hestia.Core
{
    public static class AtClassExtensions
    {
        public static T At<T>(this IList<T> list, int index=0) where T : class 
        {
            if(list == null) { return null; }
            if (list.Count == 0) { return  null; }
            if (index < 0) { index += list.Count; }
            if (index < 0 || index >= list.Count) { return null; }
            return list[index];
        }

        public static T At<T>(this T[] array,int index =0) where T : class
        {
            if(array == null) { return null; }
            if(array.Length == 0) { return null; }
            if (index < 0) { index += array.Length; }
            if (index < 0 || index >= array.Length) { return null; }
            return array[index];
        }
    }

    public static class AtStructExtensions
    {
        public static T? At<T>(this IList<T> list, int index = 0) where T : struct
        {
            if (list == null) { return null; }
            if (list.Count == 0) { return null; }
            if (index < 0) { index += list.Count; }
            if (index < 0 || index >= list.Count) { return null; }
            return list[index];
        }

        public static T? At<T>(this T[] array, int index = 0) where T : struct
        {
            if (array == null) { return null; }
            if (array.Length == 0) { return null; }
            if (index < 0) { index += array.Length; }
            if (index < 0 || index >= array.Length) { return null; }
            return array[index];
        }
    }
}
