using System;
using System.Collections.Generic;
using System.Text;

namespace Prototypist.Fluent
{
    public static class BoolExtensions
    {
        public static bool If(this bool self, Action action) {
            if (self)
            {
                action();
            }
            return self;
        }

        public static bool Else(this bool self, Action action)
        {
            if (!self)
            {
                action();
            }
            return self;
        }

        public static bool Not(this bool self) {
            return !self;
        }

    }
}
