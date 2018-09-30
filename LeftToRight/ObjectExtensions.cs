using System;
using System.Collections.Generic;
using System.Text;

namespace Prototypist.Fluent
{
    public static class ObjectExtensions
    {
        public static T Cast<T>(this object o) {
            return (T)o;
        }

        public static bool Is<T>(this object o)
        {
            return o is T;
        }
        
        public static bool Is<T>(this object o, out T res)
        {
            res = o is T t ? t : default;
            return o is T;
        }

        public static bool NullSafeEqual<T>(this object o, object other)
        {
            if (o is null) {
                return other is null;
            }
            return o.Equals(other);
        }
        
        public static T Assign<T>(this T t, out T res) {
            res = t;
            return t;
        }

        public static T[] ToArray<T>(this T t) {
            return new T[] { t };
        }

        public static T CheckArgument<T>(this T t, string argName) {
            if (t == null) {
                throw new ArgumentNullException(argName);
            }
            return t;
        }

        public static bool IsNull(this object o) {
            return o is null;
        }
        
        public static bool IsNotNull(this object o)
        {
            return !(o is null);
        }
    }
}
