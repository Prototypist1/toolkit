using System;
using System.Collections.Generic;

namespace Prototypist.Toolbox.Dictionary
{
    public static class DictionaryExtensions {

        public static T2 GetOrAdd<T1, T2>(this IDictionary<T1, T2> dict, T1 key, T2 fallback) {
            if (dict.TryGetValue(key,out var res)) {
                return res;
            }
            dict[key] = fallback;
            return fallback;
        }


        public static T2 GetOrAdd<T1, T2>(this IDictionary<T1, T2> dict, T1 key, Func<T2> gen)
        {
            if (dict.TryGetValue(key, out var res))
            {
                return res;
            }
            res = gen();
            dict[key] = res;
            return res;
        }

    }
}
