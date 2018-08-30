using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prototypist.LeftToRight
{

    public static class IEnumerableExtensions
    {
        public static T LargestOrThrow<T>(this IEnumerable<T> self, Func<T, double> measure) {
            if (self == null)
            {
                throw new ArgumentNullException(nameof(self));
            }

            if (measure == null)
            {
                throw new ArgumentNullException(nameof(measure));
            }
            
            T res = default;
            double score = default;
            var enumerator = self.GetEnumerator();

            if (enumerator.MoveNext()) {
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


            T res = default;
            double score = default;
            var enumerator = self.GetEnumerator();

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

            T res = default;
            double score = default;
            var enumerator = self.GetEnumerator();

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


            T res = default;
            double score = default;
            var enumerator = self.GetEnumerator();

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

    }
}
