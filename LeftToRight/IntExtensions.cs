using System;
using System.Text;

namespace Prototypist.Fluent.Int
{
    public static class IntExtensions
    {
        public static void For(this int reps, Action<int> action) {
            if (reps < 0) {
                throw new ArgumentOutOfRangeException(nameof(reps));
            }

            for (int i = 0; i < reps; i++)
            {
                action(i);
            }
        }
    }
}
