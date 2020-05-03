using System;
using System.Collections.Generic;
using System.Text;

namespace Prototypist.Toolbox.Object
{
    // think about these all having a prefix
    // so they don't clutter up intellisense
    // PT_ ? Pt

    public static class ObjectExtensions
    {
        public static TT SafeCastTo<T,TT>(this T o)
            where TT:T
        {
            return (TT)o;
        }

        public static TT SafeCastTo<T, TT>(this T o, Exception e)
            where TT : T
        {
            if (o is TT tt) { return tt; }
            throw e;
        }

        public static bool SafeIs<T, TT>(this T o)
            where TT : T
        {
            return o is TT;
        }

        public static bool SafeIs<T, TT>(this T o, out TT res)
            where TT : T
        {
            res = o is TT t ? t : default;
            return o is TT;
        }


        public static TT CastTo<TT>(this object o)
        {
            return (TT)o;
        }

        public static TT CastTo<TT>(this object o, Exception e)
        {
            if (o is TT tt) { return tt; }
            throw e;
        }



        public static T Assign<T>(this T t, out T res) {
            res = t;
            return t;
        }

        //public static T[] AsArray<T>(this T t) {
        //    return new T[] { t };
        //}

        //public static T CheckArgument<T>(this T t, string argName) {
        //    if (t == null) {
        //        throw new ArgumentNullException(argName);
        //    }
        //    return t;
        //}

        //public static bool IsNull(this object o) {
        //    return o is null;
        //}
        
        //public static bool IsNotNull(this object o)
        //{
        //    return !(o is null);
        //}

        /// <summary>
        /// empty string when
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        public static string NullSafeToString(this object o) {
            return o?.ToString() ?? "";
        }

        public static bool NullSafeEqual(this object o, object other)
        {
            if (o is null)
            {
                return other is null;
            }
            return o.Equals(other);
        }
    }
}
