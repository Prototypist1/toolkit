﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prototypist.Toolbox.IEnumerable
{

    public static class IEnumerableExtensions
    {
        public static IEnumerable<T> PossilyOrType<T>(this IEnumerable<IIsPossibly<T>> self)
        {
            return self.Where(x => x.Is(out var _)).Select(x => x.GetOrThrow());
        }

        public static T LargestOrThrow<T>(this IEnumerable<T> self, Func<T, double> measure) {
            if (self == null)
            {
                throw new ArgumentNullException(nameof(self));
            }

            if (measure == null)
            {
                throw new ArgumentNullException(nameof(measure));
            }

            var enumerator = self.GetEnumerator();


            T res;

            double score;
            if (enumerator.MoveNext())
            {
                res = enumerator.Current;
                score = measure(res);
            }
            else
            {
                throw new InvalidOperationException($"argument {nameof(self)} is expected to have atleast one element");
            }

            while (enumerator.MoveNext())
            {
                var at = enumerator.Current;
                var atScore = measure(at);
                if (atScore > score) {
                    res = at;
                    score = atScore;
                }
            }

            return res;
        }

        public static T LargestOrFallback<T>(this IEnumerable<T> self, T fallback, Func<T, double> measure)
        {
            if (self == null)
            {
                throw new ArgumentNullException(nameof(self));
            }

            if (measure == null)
            {
                throw new ArgumentNullException(nameof(measure));
            }

            var enumerator = self.GetEnumerator();



            T res;

            double score;
            if (enumerator.MoveNext())
            {
                res = enumerator.Current;
                score = measure(res);
            }
            else
            {
                return fallback;
            }

            while (enumerator.MoveNext())
            {
                var at = enumerator.Current;
                var atScore = measure(at);
                if (atScore > score)
                {
                    res = at;
                    score = atScore;
                }
            }

            return res;
        }

        public static bool TryLargest<T>(this IEnumerable<T> self, Func<T, double> measure, out T res) {
            if (self == null)
            {
                throw new ArgumentNullException(nameof(self));
            }

            if (measure == null)
            {
                throw new ArgumentNullException(nameof(measure));
            }

            var enumerator = self.GetEnumerator();

            double score;
            if (enumerator.MoveNext())
            {
                res = enumerator.Current;
                score = measure(res);
            }
            else {
                res = default;
                return false;
            }

            while (enumerator.MoveNext())
            {
                var at = enumerator.Current;
                var atScore = measure(at);
                if (atScore > score)
                {
                    res = at;
                    score = atScore;
                }
            }

            return true; ;
        }

        public static T SmallestOrThrow<T>(this IEnumerable<T> self, Func<T, double> measure)
        {
            if (self == null)
            {
                throw new ArgumentNullException(nameof(self));
            }

            if (measure == null)
            {
                throw new ArgumentNullException(nameof(measure));
            }

            var enumerator = self.GetEnumerator();


            T res;

            double score;
            if (enumerator.MoveNext())
            {
                res = enumerator.Current;
                score = measure(res);
            }
            else
            {
                throw new InvalidOperationException($"argument {nameof(self)} is expected to have atleast one element");
            }

            while (enumerator.MoveNext())
            {
                var at = enumerator.Current;
                var atScore = measure(at);
                if (atScore < score)
                {
                    res = at;
                    score = atScore;
                }
            }

            return res;

        }

        public static T SmallestOrFallback<T>(this IEnumerable<T> self, T fallback, Func<T, double> measure)
        {
            if (self == null)
            {
                throw new ArgumentNullException(nameof(self));
            }

            if (measure == null)
            {
                throw new ArgumentNullException(nameof(measure));
            }

            var enumerator = self.GetEnumerator();

            T res;

            double score;
            if (enumerator.MoveNext())
            {
                res = enumerator.Current;
                score = measure(res);
            }
            else
            {
                return fallback;
            }

            while (enumerator.MoveNext())
            {
                var at = enumerator.Current;
                var atScore = measure(at);
                if (atScore < score)
                {
                    res = at;
                    score = atScore;
                }
            }

            return res;
        }

        public static bool TrySmallest<T>(this IEnumerable<T> self, Func<T, double> measure, out T res)
        {
            if (self == null)
            {
                throw new ArgumentNullException(nameof(self));
            }

            if (measure == null)
            {
                throw new ArgumentNullException(nameof(measure));
            }

            var enumerator = self.GetEnumerator();

            double score;
            if (enumerator.MoveNext())
            {
                res = enumerator.Current;
                score = measure(res);
            }
            else
            {
                res = default;
                return false;
            }

            while (enumerator.MoveNext())
            {
                var at = enumerator.Current;
                var atScore = measure(at);
                if (atScore < score)
                {
                    res = at;
                    score = atScore;
                }
            }

            return true; ;
        }

        public static bool SetEqual<T>(this IEnumerable<T> self, IEnumerable<T> other)
        {
            if (self is null)
            {
                throw new ArgumentNullException(nameof(self));
            }

            return self.Count() == other.Count() && self.Except(other).Count() == 0;
        }

        public static bool NullSafeSetEqual<T>(this IEnumerable<T> self, IEnumerable<T> other) {
            if (self is null)
            {
                return other is null;
            }


            if (other is null)
            {
                return false;
            }

            return self.Count() == other.Count() && self.Except(other).Count() == 0;
        }
        
        public static bool NullSafeSequenceEqual<T>(this IEnumerable<T> self, IEnumerable<T> other) {
            if (self is null)
            {
                return other is null;
            }

            if (other is null) {
                return false;
            }

            return self.SequenceEqual(other);
        }


        public static bool TryFirst<T>(this IEnumerable<T> self, out T first)
        {
            if (self.Any()) {
                first = self.First();
                return true;
            }
            first = default;
            return false;
        }

        public static bool TrySingle<T>(this IEnumerable<T> self, out T single)
        {
            if (self.Count() == 1)
            {
                single = self.First();
                return true;
            }
            single = default;
            return false;
        }

        public static bool TryLast<T>(this IEnumerable<T> self, out T single)
        {
            if (self.Any())
            {
                single = self.Last();
                return true;
            }
            single = default;
            return false;
        }
        public delegate bool TrySelectDelegate<TIn, TOut>(TIn input, out TOut output);

        public static IEnumerable<TOut> TrySelect<TIn, TOut>(this IEnumerable<TIn> self, TrySelectDelegate<TIn, TOut> @delegate) {
            foreach (var item in self)
            {
                if (@delegate(item, out var output)) {
                    yield return output;
                }
            }
        }

        //public static T FirstOrThrow<T>(this IEnumerable<T> self)
        //{
        //    if (self.Any())
        //    {
        //        return self.First();
        //    }
        //    throw new Ex
        //}

        //public static T LastOrThrow<T>(this IEnumerable<T> self)
        //{
        //    if (self.Any())
        //    {
        //        first = self.First();
        //        return true;
        //    }
        //    first = default;
        //    return false;
        //}
    }
}
