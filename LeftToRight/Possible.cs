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

            public override bool Equals(object obj)
            {
                return obj is PrivateIs<T> @is && 
                       (@is.Value?.Equals(Value) ?? Value == null);
            }

            public override int GetHashCode()
            {
                return Value?.GetHashCode() ?? 0;
            }

            public object Representative() => Value;

            public override string ToString()
            {
                return $"is {typeof(T).Name}: {Value}";
            }
        }

        private class PrivateIsNot<T>: IIsPossibly<T>
        {
            public override bool Equals(object obj)
            {
                return obj is PrivateIsNot<T>;
            }

            public override int GetHashCode()
            {
                return 923949347;
            }

            public override string ToString()
            {
                return $"is not {typeof(T).Name}";
            }

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

        public static IEnumerable<T> AsEnumerable<T>(this IIsPossibly<T> self) {
            if (self is IIsDefinately<T> definate) {
                yield return definate.Value;
            }
        }

        public static IIsPossibly<TT> IfIsReturns<T, TT>(this IIsPossibly<T> self, Func<T, IIsPossibly<TT>> func)
        {
            if (self is IIsDefinately<T> isYes)
            {
                return func(isYes.Value);
            }
            return Possibly.IsNot<TT>();
        }

        public static IIsPossibly<TT> TransformInner<T, TT>(this IIsPossibly<T> self, Func<T, TT> func)
        {
            if (self is IIsDefinately<T> isYes)
            {
                return Possibly.Is<TT>( func(isYes.Value));
            }
            return Possibly.IsNot<TT>();
        }


        public static void IfIs<T>(this IIsPossibly<T> self, Action<T> action)
        {
            if (self is IIsDefinately<T> isYes)
            {
                action(isYes.Value);
            }
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

        public static void If<T>(this IIsPossibly<T> self, Action<T> action)
        {
            if (self is IIsDefinately<T> isYes)
            {
                action(isYes.Value);
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

        public static bool Is<T>(this IIsPossibly<T> self, out T t) {
            if (self is IIsDefinately<T> isYes)
            {
                t = isYes.Value;
                return true;
            }
            else
            {
                t = default;
                return false;
            }
        }

        public static bool IsNot<T>(this IIsPossibly<T> self)
        {
            if (self is IIsDefinately<T>)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }

    public interface IIsDefinately<out T> : IIsPossibly<T>, IAmRepresented
    {
        T Value { get; }
    }

}
