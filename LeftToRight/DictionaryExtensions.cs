using System.Collections.Generic;

namespace Prototypist.Fluent.Dictionary
{
    public static class DictionaryExtensions {

        public static T2 GetOrAdd<T1, T2>(this IDictionary<T1, T2> dict, T1 key, T2 fallback) {
            if (dict.TryGetValue(key,out var res)) {
                return res;
            }
            dict[key] = fallback;
            return fallback;
        } 
    }
}
