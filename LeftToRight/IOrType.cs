﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Prototypist.Toolbox
{

    public interface IOrType<out T1,out T2> 
    {
        bool Is<T>(out T res);
        T1 Is1OrThrow();
        T2 Is2OrThrow();
        IIsPossibly<T1> Possibly1();
        IIsPossibly<T2> Possibly2();
        void Switch(Action<T1> a1, Action<T2> a2);
        T SwitchReturns<T>(Func<T1, T> f1, Func<T2, T> f2);
    }

    public interface IOrType<out T1, out T2, out T3>
    {
        bool Is<T>(out T res);
        T1 Is1OrThrow();
        T2 Is2OrThrow();
        T3 Is3OrThrow();
        IIsPossibly<T1> Possibly1();
        IIsPossibly<T2> Possibly2();
        IIsPossibly<T3> Possibly3();
        void Switch(Action<T1> a1, Action<T2> a2, Action<T3> a3);
        T SwitchReturns<T>(Func<T1, T> f1, Func<T2, T> f2, Func<T3, T> f3);
    }

    public interface IOrType<out T1, out T2, out T3, out T4>
    {
        bool Is<T>(out T res);
        T1 Is1OrThrow();
        T2 Is2OrThrow();
        T3 Is3OrThrow();
        T4 Is4OrThrow();
        IIsPossibly<T1> Possibly1();
        IIsPossibly<T2> Possibly2();
        IIsPossibly<T3> Possibly3();
        IIsPossibly<T4> Possibly4();
        void Switch(Action<T1> a1, Action<T2> a2, Action<T3> a3, Action<T4> a4);
        T SwitchReturns<T>(Func<T1, T> f1, Func<T2, T> f2, Func<T3, T> f3, Func<T4, T> f4);
    }

    public interface IOrType<out T1, out T2, out T3, out T4, out T5>
    {
        bool Is<T>(out T res);
        T1 Is1OrThrow();
        T2 Is2OrThrow();
        T3 Is3OrThrow();
        T4 Is4OrThrow();
        T5 Is5OrThrow();
        IIsPossibly<T1> Possibly1();
        IIsPossibly<T2> Possibly2();
        IIsPossibly<T3> Possibly3();
        IIsPossibly<T4> Possibly4();
        IIsPossibly<T5> Possibly5();
        void Switch(Action<T1> a1, Action<T2> a2, Action<T3> a3, Action<T4> a4, Action<T5> a5);
        T SwitchReturns<T>(Func<T1, T> f1, Func<T2, T> f2, Func<T3, T> f3, Func<T4, T> f4, Func<T5, T> f5);
    }

    public interface IOrType<out T1, out T2, out T3, out T4, out T5, out T6>
    {
        bool Is<T>(out T res);
        T1 Is1OrThrow();
        T2 Is2OrThrow();
        T3 Is3OrThrow();
        T4 Is4OrThrow();
        T5 Is5OrThrow();
        T6 Is6OrThrow();
        IIsPossibly<T1> Possibly1();
        IIsPossibly<T2> Possibly2();
        IIsPossibly<T3> Possibly3();
        IIsPossibly<T4> Possibly4();
        IIsPossibly<T5> Possibly5();
        IIsPossibly<T6> Possibly6();
        void Switch(Action<T1> a1, Action<T2> a2, Action<T3> a3, Action<T4> a4, Action<T5> a5, Action<T6> a6);
        T SwitchReturns<T>(Func<T1, T> f1, Func<T2, T> f2, Func<T3, T> f3, Func<T4, T> f4, Func<T5, T> f5, Func<T6, T> f6);
    }

    public interface IOrType<out T1, out T2, out T3, out T4, out T5, out T6, out T7>
    {
        bool Is<T>(out T res);
        T1 Is1OrThrow();
        T2 Is2OrThrow();
        T3 Is3OrThrow();
        T4 Is4OrThrow();
        T5 Is5OrThrow();
        T6 Is6OrThrow();
        T7 Is7OrThrow();
        IIsPossibly<T1> Possibly1();
        IIsPossibly<T2> Possibly2();
        IIsPossibly<T3> Possibly3();
        IIsPossibly<T4> Possibly4();
        IIsPossibly<T5> Possibly5();
        IIsPossibly<T6> Possibly6();
        IIsPossibly<T7> Possibly7();
        void Switch(Action<T1> a1, Action<T2> a2, Action<T3> a3, Action<T4> a4, Action<T5> a5, Action<T6> a6, Action<T7> a7);
        T SwitchReturns<T>(Func<T1, T> f1, Func<T2, T> f2, Func<T3, T> f3, Func<T4, T> f4, Func<T5, T> f5, Func<T6, T> f6, Func<T7, T> f7);
    }

    public interface IOrType<out T1, out T2, out T3, out T4, out T5, out T6, out T7, out T8>
    {
        bool Is<T>(out T res);
        T1 Is1OrThrow();
        T2 Is2OrThrow();
        T3 Is3OrThrow();
        T4 Is4OrThrow();
        T5 Is5OrThrow();
        T6 Is6OrThrow();
        T7 Is7OrThrow();
        T8 Is8OrThrow();
        IIsPossibly<T1> Possibly1();
        IIsPossibly<T2> Possibly2();
        IIsPossibly<T3> Possibly3();
        IIsPossibly<T4> Possibly4();
        IIsPossibly<T5> Possibly5();
        IIsPossibly<T6> Possibly6();
        IIsPossibly<T7> Possibly7();
        IIsPossibly<T8> Possibly8();
        void Switch(Action<T1> a1, Action<T2> a2, Action<T3> a3, Action<T4> a4, Action<T5> a5, Action<T6> a6, Action<T7> a7, Action<T8> a8);
        T SwitchReturns<T>(Func<T1, T> f1, Func<T2, T> f2, Func<T3, T> f3, Func<T4, T> f4, Func<T5, T> f5, Func<T6, T> f6, Func<T7, T> f7, Func<T8, T> f8);
    }
    public static class OrTypeExtensions
    {



        public static T GetValueAs<T1, T2, T>(this IOrType<T1, T2> self)
            where T1: T
            where T2: T
        {
            if (self.Is<T>(out var res)) {
                return res;
            }
            throw new Exception($"{self}'s value is not a {typeof(T).Name}");
        }

        public static T GetValueAs<T1, T2, T>(this IOrType<T1, T2> self, out T t)
            where T1 : T
            where T2 : T
        {
            if (self.Is<T>(out var res))
            {
                t = res;
                return t;
            }
            throw new Exception($"{self}'s value is not a {typeof(T).Name}");
        }

        public static T IsOrThrow<T1,T2,T>(this IOrType<T1, T2> self)
        {
            if (self.Is<T>(out var v))
            {
                return v;
            }
            throw new Exception($"{self}'s value is not a {typeof(T).Name}");
        }

        public static bool Is1<T1, T2>(this IOrType<T1, T2> self, out T1 t1)
        {
            if (self.Possibly1() is IIsDefinately<T1> definate)
            {
                t1 = definate.Value;
                return true;
            }
            t1 = default;
            return false;
        }

        public static bool Is2<T1, T2>(this IOrType<T1, T2> self, out T2 t2)
        {
            if (self.Possibly2() is IIsDefinately<T2> definate)
            {
                t2 = definate.Value;
                return true;
            }
            t2 = default;
            return false;
        }

        public static T GetValueAs<T1, T2, T3, T>(this IOrType<T1, T2, T3> self)
            where T1 : T
            where T2 : T
            where T3 : T
        {
            if (self.Is<T>(out var res))
            {
                return res;
            }
            throw new Exception($"{self}'s value is not a {typeof(T).Name}");
        }


        public static T GetValueAs<T1, T2, T3, T>(this IOrType<T1, T2, T3> self, out T t)
            where T1 : T
            where T2 : T
            where T3 : T
        {
            if (self.Is<T>(out var res))
            {
                t = res;
                return res;
            }
            throw new Exception($"{self}'s value is not a {typeof(T).Name}");
        }

        public static T IsOrThrow<T1, T2, T3, T>(this IOrType<T1, T2, T3> self)
        {
            if (self.Is<T>(out var v))
            {
                return v;
            }
            throw new Exception($"{self}'s value is not a {typeof(T).Name}");
        }


        public static bool Is1<T1, T2, T3>(this IOrType<T1, T2, T3> self, out T1 t1)
        {
            if (self.Possibly1() is IIsDefinately<T1> definate)
            {
                t1 = definate.Value;
                return true;
            }
            t1 = default;
            return false;
        }

        public static bool Is2<T1, T2, T3>(this IOrType<T1, T2, T3> self, out T2 t2)
        {
            if (self.Possibly2() is IIsDefinately<T2> definate)
            {
                t2 = definate.Value;
                return true;
            }
            t2 = default;
            return false;
        }
        public static bool Is3<T1, T2, T3>(this IOrType<T1, T2, T3> self, out T3 t3)
        {
            if (self.Possibly3() is IIsDefinately<T3> definate)
            {
                t3 = definate.Value;
                return true;
            }
            t3 = default;
            return false;
        }

        public static T GetValueAs<T1, T2, T3, T4, T>(this IOrType<T1, T2, T3, T4> self)
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
        {
            if (self.Is<T>(out var res))
            {
                return res;
            }
            throw new Exception($"{self}'s value is not a {typeof(T).Name}");
        }

        public static T GetValueAs<T1, T2, T3, T4, T>(this IOrType<T1, T2, T3, T4> self, out T t)
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
        {
            if (self.Is<T>(out var res))
            {
                t = res;
                return res;
            }
            throw new Exception($"{self}'s value is not a {typeof(T).Name}");
        }

        public static T IsOrThrow<T1, T2, T3, T4, T>(this IOrType<T1, T2, T3, T4> self)
        {
            if (self.Is<T>(out var v))
            {
                return v;
            }
            throw new Exception($"{self}'s value is not a {typeof(T).Name}");
        }

        public static bool Is1<T1, T2, T3, T4>(this IOrType<T1, T2, T3, T4> self, out T1 t1)
        {
            if (self.Possibly1() is IIsDefinately<T1> definate)
            {
                t1 = definate.Value;
                return true;
            }
            t1 = default;
            return false;
        }

        public static bool Is2<T1, T2, T3, T4>(this IOrType<T1, T2, T3, T4> self, out T2 t2)
        {
            if (self.Possibly2() is IIsDefinately<T2> definate)
            {
                t2 = definate.Value;
                return true;
            }
            t2 = default;
            return false;
        }
        public static bool Is3<T1, T2, T3, T4>(this IOrType<T1, T2, T3, T4> self, out T3 t3)
        {
            if (self.Possibly3() is IIsDefinately<T3> definate)
            {
                t3 = definate.Value;
                return true;
            }
            t3 = default;
            return false;
        }
        public static bool Is4<T1, T2, T3, T4>(this IOrType<T1, T2, T3, T4> self, out T4 t4)
        {
            if (self.Possibly4() is IIsDefinately<T4> definate)
            {
                t4 = definate.Value;
                return true;
            }
            t4 = default;
            return false;
        }

        public static T GetValueAs<T1, T2, T3, T4, T5, T>(this IOrType<T1, T2, T3, T4, T5> self)
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
            where T5 : T
        {
            if (self.Is<T>(out var res))
            {
                return res;
            }
            throw new Exception($"{self}'s value is not a {typeof(T).Name}");
        }

        public static T GetValueAs<T1, T2, T3, T4, T5, T>(this IOrType<T1, T2, T3, T4, T5> self, out T t)
    where T1 : T
    where T2 : T
    where T3 : T
    where T4 : T
    where T5 : T
        {
            if (self.Is<T>(out var res))
            {
                t = res;
                return res;
            }
            throw new Exception($"{self}'s value is not a {typeof(T).Name}");
        }

        public static T IsOrThrow<T1, T2, T3, T4, T5, T>(this IOrType<T1, T2, T3, T4, T5> self)
        {
            if (self.Is<T>(out var v))
            {
                return v;
            }
            throw new Exception($"{self}'s value is not a {typeof(T).Name}");
        }


        public static bool Is1<T1, T2, T3, T4, T5>(this IOrType<T1, T2, T3, T4, T5> self, out T1 t1)
        {
            if (self.Possibly1() is IIsDefinately<T1> definate)
            {
                t1 = definate.Value;
                return true;
            }
            t1 = default;
            return false;
        }
        public static bool Is2<T1, T2, T3, T4, T5>(this IOrType<T1, T2, T3, T4, T5> self, out T2 t2)
        {
            if (self.Possibly2() is IIsDefinately<T2> definate)
            {
                t2 = definate.Value;
                return true;
            }
            t2 = default;
            return false;
        }
        public static bool Is3<T1, T2, T3, T4, T5>(this IOrType<T1, T2, T3, T4, T5> self, out T3 t3)
        {
            if (self.Possibly3() is IIsDefinately<T3> definate)
            {
                t3 = definate.Value;
                return true;
            }
            t3 = default;
            return false;
        }
        public static bool Is4<T1, T2, T3, T4, T5>(this IOrType<T1, T2, T3, T4, T5> self, out T4 t4)
        {
            if (self.Possibly4() is IIsDefinately<T4> definate)
            {
                t4 = definate.Value;
                return true;
            }
            t4 = default;
            return false;
        }
        public static bool Is5<T1, T2, T3, T4, T5>(this IOrType<T1, T2, T3, T4, T5> self, out T5 t5)
        {
            if (self.Possibly5() is IIsDefinately<T5> definate)
            {
                t5 = definate.Value;
                return true;
            }
            t5 = default;
            return false;
        }


        public static T GetValueAs<T1, T2, T3, T4, T5, T6, T>(this IOrType<T1, T2, T3, T4, T5, T6> self)
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
            where T5 : T
            where T6 : T
        {
            if (self.Is<T>(out var res))
            {
                return res;
            }
            throw new Exception($"{self}'s value is not a {typeof(T).Name}");
        }

        public static T GetValueAs<T1, T2, T3, T4, T5, T6, T>(this IOrType<T1, T2, T3, T4, T5, T6> self, out T t )
    where T1 : T
    where T2 : T
    where T3 : T
    where T4 : T
    where T5 : T
    where T6 : T
        {
            if (self.Is<T>(out var res))
            {
                t = res;
                return res;
            }
            throw new Exception($"{self}'s value is not a {typeof(T).Name}");
        }

        public static T IsOrThrow<T1, T2, T3, T4, T5, T6, T>(this IOrType<T1, T2, T3, T4, T5, T6> self)
        {
            if (self.Is<T>(out var v))
            {
                return v;
            }
            throw new Exception($"{self}'s value is not a {typeof(T).Name}");
        }

        public static bool Is1<T1, T2, T3, T4, T5, T6>(this IOrType<T1, T2, T3, T4, T5, T6> self, out T1 t1)
        {
            if (self.Possibly1() is IIsDefinately<T1> definate)
            {
                t1 = definate.Value;
                return true;
            }
            t1 = default;
            return false;
        }
        public static bool Is2<T1, T2, T3, T4, T5, T6>(this IOrType<T1, T2, T3, T4, T5, T6> self, out T2 t2)
        {
            if (self.Possibly2() is IIsDefinately<T2> definate)
            {
                t2 = definate.Value;
                return true;
            }
            t2 = default;
            return false;
        }
        public static bool Is3<T1, T2, T3, T4, T5, T6>(this IOrType<T1, T2, T3, T4, T5, T6> self, out T3 t3)
        {
            if (self.Possibly3() is IIsDefinately<T3> definate)
            {
                t3 = definate.Value;
                return true;
            }
            t3 = default;
            return false;
        }
        public static bool Is4<T1, T2, T3, T4, T5, T6>(this IOrType<T1, T2, T3, T4, T5, T6> self, out T4 t4)
        {
            if (self.Possibly4() is IIsDefinately<T4> definate)
            {
                t4 = definate.Value;
                return true;
            }
            t4 = default;
            return false;
        }
        public static bool Is5<T1, T2, T3, T4, T5, T6>(this IOrType<T1, T2, T3, T4, T5, T6> self, out T5 t5)
        {
            if (self.Possibly5() is IIsDefinately<T5> definate)
            {
                t5 = definate.Value;
                return true;
            }
            t5 = default;
            return false;
        }

        public static bool Is6<T1, T2, T3, T4, T5, T6>(this IOrType<T1, T2, T3, T4, T5, T6> self, out T6 t6)
        {
            if (self.Possibly6() is IIsDefinately<T6> definate)
            {
                t6 = definate.Value;
                return true;
            }
            t6 = default;
            return false;
        }

        public static T GetValueAs<T1, T2, T3, T4, T5, T6, T7, T>(this IOrType<T1, T2, T3, T4, T5, T6, T7> self)
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
            where T5 : T
            where T6 : T
            where T7 : T
        {
            if (self.Is<T>(out var res))
            {
                return res;
            }
            throw new Exception($"{self}'s value is not a {typeof(T).Name}");
        }

        public static T GetValueAs<T1, T2, T3, T4, T5, T6, T7, T>(this IOrType<T1, T2, T3, T4, T5, T6, T7> self, out T t)
    where T1 : T
    where T2 : T
    where T3 : T
    where T4 : T
    where T5 : T
    where T6 : T
    where T7 : T
        {
            if (self.Is<T>(out var res))
            {
                t = res;
                return res;
            }
            throw new Exception($"{self}'s value is not a {typeof(T).Name}");
        }

        public static T IsOrThrow<T1, T2, T3, T4, T5, T6, T7, T>(this IOrType<T1, T2, T3, T4, T5, T6, T7> self)
        {
            if (self.Is<T>(out var v))
            {
                return v;
            }
            throw new Exception($"{self}'s value is not a {typeof(T).Name}");
        }
        public static bool Is1<T1, T2, T3, T4, T5, T6, T7>(this IOrType<T1, T2, T3, T4, T5, T6, T7> self, out T1 t1)
        {
            if (self.Possibly1() is IIsDefinately<T1> definate)
            {
                t1 = definate.Value;
                return true;
            }
            t1 = default;
            return false;
        }
        public static bool Is2<T1, T2, T3, T4, T5, T6, T7>(this IOrType<T1, T2, T3, T4, T5, T6, T7> self, out T2 t2)
        {
            if (self.Possibly2() is IIsDefinately<T2> definate)
            {
                t2 = definate.Value;
                return true;
            }
            t2 = default;
            return false;
        }
        public static bool Is3<T1, T2, T3, T4, T5, T6, T7>(this IOrType<T1, T2, T3, T4, T5, T6, T7> self, out T3 t3)
        {
            if (self.Possibly3() is IIsDefinately<T3> definate)
            {
                t3 = definate.Value;
                return true;
            }
            t3 = default;
            return false;
        }
        public static bool Is4<T1, T2, T3, T4, T5, T6, T7>(this IOrType<T1, T2, T3, T4, T5, T6, T7> self, out T4 t4)
        {
            if (self.Possibly4() is IIsDefinately<T4> definate)
            {
                t4 = definate.Value;
                return true;
            }
            t4 = default;
            return false;
        }
        public static bool Is5<T1, T2, T3, T4, T5, T6, T7>(this IOrType<T1, T2, T3, T4, T5, T6, T7> self, out T5 t5)
        {
            if (self.Possibly5() is IIsDefinately<T5> definate)
            {
                t5 = definate.Value;
                return true;
            }
            t5 = default;
            return false;
        }

        public static bool Is6<T1, T2, T3, T4, T5, T6, T7>(this IOrType<T1, T2, T3, T4, T5, T6, T7> self, out T6 t6)
        {
            if (self.Possibly6() is IIsDefinately<T6> definate)
            {
                t6 = definate.Value;
                return true;
            }
            t6 = default;
            return false;
        }

        public static bool Is7<T1, T2, T3, T4, T5, T6, T7>(this IOrType<T1, T2, T3, T4, T5, T6, T7> self, out T7 t7)
        {
            if (self.Possibly7() is IIsDefinately<T7> definate)
            {
                t7 = definate.Value;
                return true;
            }
            t7 = default;
            return false;
        }


        public static T GetValueAs<T1, T2, T3, T4, T5, T6, T7, T8, T>(this IOrType<T1, T2, T3, T4, T5, T6, T7, T8> self)
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
            where T5 : T
            where T6 : T
            where T7 : T
            where T8 : T
        {
            if (self.Is<T>(out var res))
            {
                return res;
            }
            throw new Exception($"{self}'s value is not a {typeof(T).Name}");
        }

        public static T GetValueAs<T1, T2, T3, T4, T5, T6, T7, T8, T>(this IOrType<T1, T2, T3, T4, T5, T6, T7, T8> self, out T t)
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
            where T5 : T
            where T6 : T
            where T7 : T
            where T8 : T
        {
            if (self.Is<T>(out var res))
            {
                t = res;
                return res;
            }
            throw new Exception($"{self}'s value is not a {typeof(T).Name}");
        }

        public static T IsOrThrow<T1, T2, T3, T4, T5, T6, T7, T8, T>(this IOrType<T1, T2, T3, T4, T5, T6, T7, T8> self)
        {
            if (self.Is<T>(out var v))
            {
                return v;
            }
            throw new Exception($"{self}'s value is not a {typeof(T).Name}");
        }
        public static bool Is1<T1, T2, T3, T4, T5, T6, T7, T8>(this IOrType<T1, T2, T3, T4, T5, T6, T7, T8> self, out T1 t1)
        {
            if (self.Possibly1() is IIsDefinately<T1> definate)
            {
                t1 = definate.Value;
                return true;
            }
            t1 = default;
            return false;
        }
        public static bool Is2<T1, T2, T3, T4, T5, T6, T7, T8>(this IOrType<T1, T2, T3, T4, T5, T6, T7, T8> self, out T2 t2)
        {
            if (self.Possibly2() is IIsDefinately<T2> definate)
            {
                t2 = definate.Value;
                return true;
            }
            t2 = default;
            return false;
        }
        public static bool Is3<T1, T2, T3, T4, T5, T6, T7, T8>(this IOrType<T1, T2, T3, T4, T5, T6, T7, T8> self, out T3 t3)
        {
            if (self.Possibly3() is IIsDefinately<T3> definate)
            {
                t3 = definate.Value;
                return true;
            }
            t3 = default;
            return false;
        }
        public static bool Is4<T1, T2, T3, T4, T5, T6, T7, T8>(this IOrType<T1, T2, T3, T4, T5, T6, T7, T8> self, out T4 t4)
        {
            if (self.Possibly4() is IIsDefinately<T4> definate)
            {
                t4 = definate.Value;
                return true;
            }
            t4 = default;
            return false;
        }
        public static bool Is5<T1, T2, T3, T4, T5, T6, T7, T8>(this IOrType<T1, T2, T3, T4, T5, T6, T7, T8> self, out T5 t5)
        {
            if (self.Possibly5() is IIsDefinately<T5> definate)
            {
                t5 = definate.Value;
                return true;
            }
            t5 = default;
            return false;
        }

        public static bool Is6<T1, T2, T3, T4, T5, T6, T7, T8>(this IOrType<T1, T2, T3, T4, T5, T6, T7, T8> self, out T6 t6)
        {
            if (self.Possibly6() is IIsDefinately<T6> definate)
            {
                t6 = definate.Value;
                return true;
            }
            t6 = default;
            return false;
        }

        public static bool Is7<T1, T2, T3, T4, T5, T6, T7, T8>(this IOrType<T1, T2, T3, T4, T5, T6, T7, T8> self, out T7 t7)
        {
            if (self.Possibly7() is IIsDefinately<T7> definate)
            {
                t7 = definate.Value;
                return true;
            }
            t7 = default;
            return false;
        }
        public static bool Is8<T1, T2, T3, T4, T5, T6, T7, T8>(this IOrType<T1, T2, T3, T4, T5, T6, T7, T8> self, out T8 t8)
        {
            if (self.Possibly8() is IIsDefinately<T8> definate)
            {
                t8 = definate.Value;
                return true;
            }
            t8 = default;
            return false;
        }
    }
}