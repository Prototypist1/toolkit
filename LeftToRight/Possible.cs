using System;
using System.Collections.Generic;
using System.Text;

namespace Prototypist.Toolbox
{
    public static class Possibly
    {

        private class PrivateIs<T> : IIsDefinately<T>
        {
            public PrivateIs(T value)
            {
                Value = value;
            }

            public T Value { get; }
        }

        private class PrivateIsNot<T> : IIsDefinatelyNot<T>
        {
        }

        public static IIsDefinately<T> Is<T>(T t)
        {
            return new PrivateIs<T>(t);
        }

        public static IIsDefinatelyNot<T> IsNot<T>()
        {
            return new PrivateIsNot<T>();
        }
    }

    public interface IIsPossibly<out T>
    {
    }

    public static class IsPossiblyExtenstions
    {
        public static bool IsDefinately<T>(this IIsPossibly<T> self, out IIsDefinately<T> yes, out IIsDefinatelyNot<T> no)
        {
            if (self is IIsDefinately<T> isYes)
            {
                yes = isYes;
                no = default;
                return true;
            }
            if (self is IIsDefinatelyNot<T> isNo)
            {
                no = isNo;
                yes = default;
                return false;
            }
            throw new Exception("bug! this should be a dichotomy!");
        }

        public static IIsPossibly<TT> IfIs<T, TT>(this IIsPossibly<T> self, Func<T, IIsPossibly<TT>> func)
        {
            if (self is IIsDefinately<T> isYes)
            {
                return func(isYes.Value);
            }
            if (self is IIsDefinatelyNot<T>)
            {
                return Possibly.IsNot<TT>();
            }
            throw new Exception("bug! this should be a dichotomy!");
        }

        public static T GetOrThrow<T>(this IIsPossibly<T> self)
        {
            if (self is IIsDefinately<T> isYes)
            {
                return isYes.Value;
            }
            throw new Exception();
        }

    }

    public interface IIsDefinately<out T> : IIsPossibly<T>
    {
        T Value { get; }
    }

    public interface IIsDefinatelyNot
    {

    }

    public interface IIsDefinatelyNot<out T> : IIsPossibly<T>, IIsDefinatelyNot
    {
    }
}
