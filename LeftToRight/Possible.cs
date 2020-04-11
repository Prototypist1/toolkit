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

            public object Representative() => Value;
        }

        private class PrivateIsNot<T>: IIsPossibly<T>
        {
        }

        public static IIsDefinately<T> Is<T>(T t)
        {
            return new PrivateIs<T>(t);
        }

        public static IIsPossibly<T> IsNot<T>()
        {
            return new PrivateIsNot<T>();
        }
    }

    public interface IIsPossibly
    {
    }

    public interface IIsPossibly<out T> : IIsPossibly
    {
    }

    public static class IsPossiblyExtenstions
    {

        public static IIsPossibly<TT> IfIs<T, TT>(this IIsPossibly<T> self, Func<T, IIsPossibly<TT>> func)
        {
            if (self is IIsDefinately<T> isYes)
            {
                return func(isYes.Value);
            }
            return Possibly.IsNot<TT>();
        }

        public static void IfElse<T>(this IIsPossibly<T> self, Action<T> ifIs, Action ifNot)
        {
            if (self is IIsDefinately<T> isYes)
            {
                ifIs(isYes.Value);
            }
            else {
                ifNot();
            }
        }

        public static TT IfElseReturn<T, TT>(this IIsPossibly<T> self, Func<T,TT> ifIs, Func<TT> ifNot)
        {
            if (self is IIsDefinately<T> isYes)
            {
                return ifIs(isYes.Value);
            }
            else
            {
                return ifNot();
            }
        }

        public static void If<T, TT>(this IIsPossibly<T> self, Func<T, TT> func)
        {
            if (self is IIsDefinately<T> isYes)
            {
                func(isYes.Value);
            }
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

    public interface IIsDefinately<out T> : IIsPossibly<T>, IAmRepresented
    {
        T Value { get; }
    }

}
