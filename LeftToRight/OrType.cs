﻿using Prototypist.Toolbox.Object;
using System;
using System.Collections.Generic;

namespace Prototypist.Toolbox
{
    // something something Source generator...

    public abstract class p<T1> : IIsPossibly<T1>, IAmRepresented {

        public override int GetHashCode()
        {
            return Representative()?.GetHashCode() ?? 0;
        }


        public override string ToString()
        {
            return Representative()?.ToString();
        }

        public abstract object Representative();
    }
    public abstract class p<T1, T2> : p<T1>, IIsPossibly<T2> { }
    public abstract class p<T1, T2, T3> : p<T1, T2>, IIsPossibly<T3> { }
    public abstract class p<T1, T2, T3, T4> : p<T1, T2, T3>, IIsPossibly<T4> { }
    public abstract class p<T1, T2, T3, T4, T5> : p<T1, T2, T3, T4>, IIsPossibly<T5> { }
    public abstract class p<T1, T2, T3, T4, T5, T6> : p<T1, T2, T3, T4, T5>, IIsPossibly<T6> { }
    public abstract class p<T1, T2, T3, T4, T5, T6,T7> : p<T1, T2, T3, T4, T5,T6>, IIsPossibly<T7> { }
    public abstract class p<T1, T2, T3, T4, T5, T6, T7,T8> : p<T1, T2, T3, T4, T5, T6,T7>, IIsPossibly<T8> { }

    public interface IAmRepresented {
        object Representative();
    }

#pragma warning disable CS0659 // Type overrides Object.Equals(object o) but does not override Object.GetHashCode()
    public abstract class OrType<T1, T2> : p<T1, T2>, IOrType<T1, T2>
#pragma warning restore CS0659 // Type overrides Object.Equals(object o) but does not override Object.GetHashCode()
    {
        public bool Is<T>(out T res)
        {
            if (Representative() is T t)
            {
                res = t;
                return true;
            }
            res = default;
            return false;
        }

        public T1 Is1OrThrow()
        {
            if (this is IIsDefinately<T1> definate)
            {
                return definate.Value;
            }
            throw new Exception($"is not {typeof(T1)}");
        }

        public T2 Is2OrThrow()
        {
            if (this is IIsDefinately<T2> definate)
            {
                return definate.Value;
            }
            throw new Exception($"is not {typeof(T2)}");
        }

        public IIsPossibly<T1> Possibly1() => this;
        public IIsPossibly<T2> Possibly2() => this;

        public void Switch(Action<T1> a1, Action<T2> a2)
        {
            if (this is IIsDefinately<T1> definate1)
            {
                a1(definate1.Value);
            }
            else if (this is IIsDefinately<T2> definate2)
            {
                a2(definate2.Value);
            }
            else
            {
                throw new Exception("bug!");
            }
        }

        public T SwitchReturns<T>(Func<T1, T> f1, Func<T2, T> f2)
        {
            if (this is IIsDefinately<T1> definate1)
            {
                return f1(definate1.Value);
            }
            if (this is IIsDefinately<T2> definate2)
            {
                return f2(definate2.Value);
            }
            throw new Exception("bug!");
        }

        public override bool Equals(object obj)
        {
            if (obj is OrType<T1, T2> other)
            {
                return other.Representative().NullSafeEqual(Representative());
            }
            return false;
        }

        public static implicit operator OrType<T1, T2>(T1 t1) => OrType.Make<T1,T2>(t1);
        public static implicit operator OrType<T1, T2>(T2 t2) => OrType.Make<T1, T2>(t2);
    }
#pragma warning disable CS0659 // Type overrides Object.Equals(object o) but does not override Object.GetHashCode()
    public abstract class OrType<T1, T2, T3> : p<T1, T2, T3>, IOrType<T1, T2, T3>
#pragma warning restore CS0659 // Type overrides Object.Equals(object o) but does not override Object.GetHashCode()
    {


        public bool Is<T>(out T res)
        {
            if (Representative() is T t)
            {
                res = t;
                return true;
            }
            res = default;
            return false;
        }

        public T1 Is1OrThrow()
        {
            if (this is IIsDefinately<T1> definate)
            {
                return definate.Value;
            }
            throw new Exception($"is not {typeof(T1)}");
        }

        public T2 Is2OrThrow()
        {
            if (this is IIsDefinately<T2> definate)
            {
                return definate.Value;
            }
            throw new Exception($"is not {typeof(T2)}");
        }
        public T3 Is3OrThrow()
        {
            if (this is IIsDefinately<T3> definate)
            {
                return definate.Value;
            }
            throw new Exception($"is not {typeof(T3)}");
        }

        public IIsPossibly<T1> Possibly1() => this;
        public IIsPossibly<T2> Possibly2() => this;
        public IIsPossibly<T3> Possibly3() => this;

        public void Switch(Action<T1> a1, Action<T2> a2, Action<T3> a3)
        {
            if (this is IIsDefinately<T1> definate1)
            {
                a1(definate1.Value);
            }
            else if (this is IIsDefinately<T2> definate2)
            {
                a2(definate2.Value);
            }
            else if (this is IIsDefinately<T3> definate3)
            {
                a3(definate3.Value);
            }
            else
            {
                throw new Exception("bug!");
            }
        }

        public T SwitchReturns<T>(Func<T1, T> f1, Func<T2, T> f2, Func<T3, T> f3)
        {
            if (this is IIsDefinately<T1> definate1)
            {
                return f1(definate1.Value);
            }
            if (this is IIsDefinately<T2> definate2)
            {
                return f2(definate2.Value);
            }
            if (this is IIsDefinately<T3> definate3)
            {
                return f3(definate3.Value);
            }
            throw new Exception("bug!");
        }

        public override bool Equals(object obj)
        {
            if (obj is OrType<T1, T2,T3> other)
            {
                return other.Representative().NullSafeEqual(Representative());
            }
            return false;
        }

        public static implicit operator OrType<T1, T2, T3>(T1 t1) => OrType.Make<T1, T2, T3>(t1);
        public static implicit operator OrType<T1, T2, T3>(T2 t2) => OrType.Make<T1, T2, T3>(t2);
        public static implicit operator OrType<T1, T2, T3>(T3 t3) => OrType.Make<T1, T2, T3>(t3);
    }
#pragma warning disable CS0659 // Type overrides Object.Equals(object o) but does not override Object.GetHashCode()
    public abstract class OrType<T1, T2, T3, T4> : p<T1, T2, T3, T4>, IOrType<T1, T2, T3, T4>
#pragma warning restore CS0659 // Type overrides Object.Equals(object o) but does not override Object.GetHashCode()
    {
        public bool Is<T>(out T res)
        {
            if (Representative() is T t)
            {
                res = t;
                return true;
            }
            res = default;
            return false;
        }

        public T1 Is1OrThrow()
        {
            if (this is IIsDefinately<T1> definate)
            {
                return definate.Value;
            }
            throw new Exception($"is not {typeof(T1)}");
        }

        public T2 Is2OrThrow()
        {
            if (this is IIsDefinately<T2> definate)
            {
                return definate.Value;
            }
            throw new Exception($"is not {typeof(T2)}");
        }
        public T3 Is3OrThrow()
        {
            if (this is IIsDefinately<T3> definate)
            {
                return definate.Value;
            }
            throw new Exception($"is not {typeof(T3)}");
        }
        public T4 Is4OrThrow()
        {
            if (this is IIsDefinately<T4> definate)
            {
                return definate.Value;
            }
            throw new Exception($"is not {typeof(T4)}");
        }

        public IIsPossibly<T1> Possibly1() => this;
        public IIsPossibly<T2> Possibly2() => this;
        public IIsPossibly<T3> Possibly3() => this;
        public IIsPossibly<T4> Possibly4() => this;

        public void Switch(Action<T1> a1, Action<T2> a2, Action<T3> a3, Action<T4> a4)
        {
            if (this is IIsDefinately<T1> definate1)
            {
                a1(definate1.Value);
            }
            else if (this is IIsDefinately<T2> definate2)
            {
                a2(definate2.Value);
            }
            else if (this is IIsDefinately<T3> definate3)
            {
                a3(definate3.Value);
            }
            else if (this is IIsDefinately<T4> definate4)
            {
                a4(definate4.Value);
            }
            else
            {
                throw new Exception("bug!");
            }
        }

        public T SwitchReturns<T>(Func<T1, T> f1, Func<T2, T> f2, Func<T3, T> f3, Func<T4, T> f4)
        {
            if (this is IIsDefinately<T1> definate1)
            {
                return f1(definate1.Value);
            }
            if (this is IIsDefinately<T2> definate2)
            {
                return f2(definate2.Value);
            }
            if (this is IIsDefinately<T3> definate3)
            {
                return f3(definate3.Value);
            }
            if (this is IIsDefinately<T4> definate4)
            {
                return f4(definate4.Value);
            }
            throw new Exception("bug!");
        }


        public override bool Equals(object obj)
        {
            if (obj is OrType<T1, T2, T3,T4> other)
            {
                return other.Representative().NullSafeEqual(Representative());
            }
            return false;
        }

        public static implicit operator OrType<T1, T2, T3, T4>(T1 t1) => OrType.Make<T1, T2, T3, T4>(t1);
        public static implicit operator OrType<T1, T2, T3, T4>(T2 t2) => OrType.Make<T1, T2, T3, T4>(t2);
        public static implicit operator OrType<T1, T2, T3, T4>(T3 t3) => OrType.Make<T1, T2, T3, T4>(t3);
        public static implicit operator OrType<T1, T2, T3, T4>(T4 t4) => OrType.Make<T1, T2, T3, T4>(t4);

    }
#pragma warning disable CS0659 // Type overrides Object.Equals(object o) but does not override Object.GetHashCode()
    public abstract class OrType<T1, T2, T3, T4, T5> : p<T1, T2, T3, T4, T5>, IOrType<T1, T2, T3, T4, T5>
#pragma warning restore CS0659 // Type overrides Object.Equals(object o) but does not override Object.GetHashCode()
    {
        public bool Is<T>(out T res)
        {
            if (Representative() is T t) {
                res = t;
                return true;
            }
            res = default;
            return false;
        }

        public T1 Is1OrThrow()
        {
            if (this is IIsDefinately<T1> definate)
            {
                return definate.Value;
            }
            throw new Exception($"is not {typeof(T1)}");
        }

        public T2 Is2OrThrow()
        {
            if (this is IIsDefinately<T2> definate)
            {
                return definate.Value;
            }
            throw new Exception($"is not {typeof(T2)}");
        }
        public T3 Is3OrThrow()
        {
            if (this is IIsDefinately<T3> definate)
            {
                return definate.Value;
            }
            throw new Exception($"is not {typeof(T3)}");
        }
        public T4 Is4OrThrow()
        {
            if (this is IIsDefinately<T4> definate)
            {
                return definate.Value;
            }
            throw new Exception($"is not {typeof(T4)}");
        }
        public T5 Is5OrThrow()
        {
            if (this is IIsDefinately<T5> definate)
            {
                return definate.Value;
            }
            throw new Exception($"is not {typeof(T5)}");
        }

        public IIsPossibly<T1> Possibly1() => this;
        public IIsPossibly<T2> Possibly2() => this;
        public IIsPossibly<T3> Possibly3() => this;
        public IIsPossibly<T4> Possibly4() => this;
        public IIsPossibly<T5> Possibly5() => this;

        public void Switch(Action<T1> a1, Action<T2> a2, Action<T3> a3, Action<T4> a4, Action<T5> a5)
        {
            if (this is IIsDefinately<T1> definate1)
            {
                a1(definate1.Value);
            }
            else if (this is IIsDefinately<T2> definate2)
            {
                a2(definate2.Value);
            }
            else if (this is IIsDefinately<T3> definate3)
            {
                a3(definate3.Value);
            }
            else if (this is IIsDefinately<T4> definate4)
            {
                a4(definate4.Value);
            }
            else if (this is IIsDefinately<T5> definate5)
            {
                a5(definate5.Value);
            }
            else
            {
                throw new Exception("bug!");
            }
        }

        public T SwitchReturns<T>(Func<T1, T> f1, Func<T2, T> f2, Func<T3, T> f3, Func<T4, T> f4, Func<T5, T> f5)
        {
            if (this is IIsDefinately<T1> definate1)
            {
                return f1(definate1.Value);
            }
            if (this is IIsDefinately<T2> definate2)
            {
                return f2(definate2.Value);
            }
            if (this is IIsDefinately<T3> definate3)
            {
                return f3(definate3.Value);
            }
            if (this is IIsDefinately<T4> definate4)
            {
                return f4(definate4.Value);
            }
            if (this is IIsDefinately<T5> definate5)
            {
                return f5(definate5.Value);
            }
            throw new Exception("bug!");
        }


        public override bool Equals(object obj)
        {
            if (obj is OrType<T1, T2, T3, T4,T5> other)
            {
                return other.Representative().NullSafeEqual(Representative());
            }
            return false;
        }

        public static implicit operator OrType<T1, T2, T3, T4, T5>(T1 t1) => OrType.Make<T1, T2, T3, T4, T5>(t1);
        public static implicit operator OrType<T1, T2, T3, T4, T5>(T2 t2) => OrType.Make<T1, T2, T3, T4, T5>(t2);
        public static implicit operator OrType<T1, T2, T3, T4, T5>(T3 t3) => OrType.Make<T1, T2, T3, T4, T5>(t3);
        public static implicit operator OrType<T1, T2, T3, T4, T5>(T4 t4) => OrType.Make<T1, T2, T3, T4, T5>(t4);
        public static implicit operator OrType<T1, T2, T3, T4, T5>(T5 t5) => OrType.Make<T1, T2, T3, T4, T5>(t5);

    }

#pragma warning disable CS0659 //
    public abstract class OrType<T1, T2, T3, T4, T5, T6> : p<T1, T2, T3, T4, T5, T6>, IOrType<T1, T2, T3, T4, T5, T6>
#pragma warning restore CS0659 // Type overrides Object.Equals(object o) but does not override Object.GetHashCode()
    {
        public bool Is<T>(out T res)
        {
            if (Representative() is T t)
            {
                res = t;
                return true;
            }
            res = default;
            return false;
        }

        public T1 Is1OrThrow()
        {
            if (this is IIsDefinately<T1> definate)
            {
                return definate.Value;
            }
            throw new Exception($"is not {typeof(T1)}");
        }

        public T2 Is2OrThrow()
        {
            if (this is IIsDefinately<T2> definate)
            {
                return definate.Value;
            }
            throw new Exception($"is not {typeof(T2)}");
        }
        public T3 Is3OrThrow()
        {
            if (this is IIsDefinately<T3> definate)
            {
                return definate.Value;
            }
            throw new Exception($"is not {typeof(T3)}");
        }
        public T4 Is4OrThrow()
        {
            if (this is IIsDefinately<T4> definate)
            {
                return definate.Value;
            }
            throw new Exception($"is not {typeof(T4)}");
        }
        public T5 Is5OrThrow()
        {
            if (this is IIsDefinately<T5> definate)
            {
                return definate.Value;
            }
            throw new Exception($"is not {typeof(T5)}");
        }
        public T6 Is6OrThrow()
        {
            if (this is IIsDefinately<T6> definate)
            {
                return definate.Value;
            }
            throw new Exception($"is not {typeof(T6)}");
        }
        public IIsPossibly<T1> Possibly1() => this;
        public IIsPossibly<T2> Possibly2() => this;
        public IIsPossibly<T3> Possibly3() => this;
        public IIsPossibly<T4> Possibly4() => this;
        public IIsPossibly<T5> Possibly5() => this;
        public IIsPossibly<T6> Possibly6() => this;

        public void Switch(Action<T1> a1, Action<T2> a2, Action<T3> a3, Action<T4> a4, Action<T5> a5, Action<T6> a6)
        {
            if (this is IIsDefinately<T1> definate1)
            {
                a1(definate1.Value);
            }
            else if (this is IIsDefinately<T2> definate2)
            {
                a2(definate2.Value);
            }
            else if (this is IIsDefinately<T3> definate3)
            {
                a3(definate3.Value);
            }
            else if (this is IIsDefinately<T4> definate4)
            {
                a4(definate4.Value);
            }
            else if (this is IIsDefinately<T5> definate5)
            {
                a5(definate5.Value);
            }
            else if (this is IIsDefinately<T6> definate6)
            {
                a6(definate6.Value);
            }
            else
            {
                throw new Exception("bug!");
            }
        }

        public T SwitchReturns<T>(Func<T1, T> f1, Func<T2, T> f2, Func<T3, T> f3, Func<T4, T> f4, Func<T5, T> f5, Func<T6, T> f6)
        {
            if (this is IIsDefinately<T1> definate1)
            {
                return f1(definate1.Value);
            }
            if (this is IIsDefinately<T2> definate2)
            {
                return f2(definate2.Value);
            }
            if (this is IIsDefinately<T3> definate3)
            {
                return f3(definate3.Value);
            }
            if (this is IIsDefinately<T4> definate4)
            {
                return f4(definate4.Value);
            }
            if (this is IIsDefinately<T5> definate5)
            {
                return f5(definate5.Value);
            }
            if (this is IIsDefinately<T6> definate6)
            {
                return f6(definate6.Value);
            }
            throw new Exception("bug!");
        }

        public override bool Equals(object obj)
        {
            if (obj is OrType<T1, T2, T3, T4, T5,T6> other)
            {
                return other.Representative().NullSafeEqual(Representative());
            }
            return false;
        }

        public static implicit operator OrType<T1, T2, T3, T4, T5, T6>(T1 t1) => OrType.Make<T1, T2, T3, T4, T5, T6>(t1);
        public static implicit operator OrType<T1, T2, T3, T4, T5, T6>(T2 t2) => OrType.Make<T1, T2, T3, T4, T5, T6>(t2);
        public static implicit operator OrType<T1, T2, T3, T4, T5, T6>(T3 t3) => OrType.Make<T1, T2, T3, T4, T5, T6>(t3);
        public static implicit operator OrType<T1, T2, T3, T4, T5, T6>(T4 t4) => OrType.Make<T1, T2, T3, T4, T5, T6>(t4);
        public static implicit operator OrType<T1, T2, T3, T4, T5, T6>(T5 t5) => OrType.Make<T1, T2, T3, T4, T5, T6>(t5);
        public static implicit operator OrType<T1, T2, T3, T4, T5, T6>(T6 t6) => OrType.Make<T1, T2, T3, T4, T5, T6>(t6);

    }

#pragma warning disable CS0659 //
    public abstract class OrType<T1, T2, T3, T4, T5, T6,T7> : p<T1, T2, T3, T4, T5, T6, T7>, IOrType<T1, T2, T3, T4, T5, T6, T7>
#pragma warning restore CS0659 // Type overrides Object.Equals(object o) but does not override Object.GetHashCode()
    {
        public bool Is<T>(out T res)
        {
            if (Representative() is T t)
            {
                res = t;
                return true;
            }
            res = default;
            return false;
        }

        public T1 Is1OrThrow()
        {
            if (this is IIsDefinately<T1> definate)
            {
                return definate.Value;
            }
            throw new Exception($"is not {typeof(T1)}");
        }

        public T2 Is2OrThrow()
        {
            if (this is IIsDefinately<T2> definate)
            {
                return definate.Value;
            }
            throw new Exception($"is not {typeof(T2)}");
        }
        public T3 Is3OrThrow()
        {
            if (this is IIsDefinately<T3> definate)
            {
                return definate.Value;
            }
            throw new Exception($"is not {typeof(T3)}");
        }
        public T4 Is4OrThrow()
        {
            if (this is IIsDefinately<T4> definate)
            {
                return definate.Value;
            }
            throw new Exception($"is not {typeof(T4)}");
        }
        public T5 Is5OrThrow()
        {
            if (this is IIsDefinately<T5> definate)
            {
                return definate.Value;
            }
            throw new Exception($"is not {typeof(T5)}");
        }
        public T6 Is6OrThrow()
        {
            if (this is IIsDefinately<T6> definate)
            {
                return definate.Value;
            }
            throw new Exception($"is not {typeof(T6)}");
        }
        public T7 Is7OrThrow()
        {
            if (this is IIsDefinately<T7> definate)
            {
                return definate.Value;
            }
            throw new Exception($"is not {typeof(T7)}");
        }
        public IIsPossibly<T1> Possibly1() => this;
        public IIsPossibly<T2> Possibly2() => this;
        public IIsPossibly<T3> Possibly3() => this;
        public IIsPossibly<T4> Possibly4() => this;
        public IIsPossibly<T5> Possibly5() => this;
        public IIsPossibly<T6> Possibly6() => this;
        public IIsPossibly<T7> Possibly7() => this;
        public void Switch(Action<T1> a1, Action<T2> a2, Action<T3> a3, Action<T4> a4, Action<T5> a5, Action<T6> a6, Action<T7> a7)
        {
            if (this is IIsDefinately<T1> definate1)
            {
                a1(definate1.Value);
            }
            else if (this is IIsDefinately<T2> definate2)
            {
                a2(definate2.Value);
            }
            else if (this is IIsDefinately<T3> definate3)
            {
                a3(definate3.Value);
            }
            else if (this is IIsDefinately<T4> definate4)
            {
                a4(definate4.Value);
            }
            else if (this is IIsDefinately<T5> definate5)
            {
                a5(definate5.Value);
            }
            else if (this is IIsDefinately<T6> definate6)
            {
                a6(definate6.Value);
            }
            else if (this is IIsDefinately<T7> definate7)
            {
                a7(definate7.Value);
            }
            else
            {
                throw new Exception("bug!");
            }
        }

        public T SwitchReturns<T>(Func<T1, T> f1, Func<T2, T> f2, Func<T3, T> f3, Func<T4, T> f4, Func<T5, T> f5, Func<T6, T> f6, Func<T7, T> f7)
        {
            if (this is IIsDefinately<T1> definate1)
            {
                return f1(definate1.Value);
            }
            if (this is IIsDefinately<T2> definate2)
            {
                return f2(definate2.Value);
            }
            if (this is IIsDefinately<T3> definate3)
            {
                return f3(definate3.Value);
            }
            if (this is IIsDefinately<T4> definate4)
            {
                return f4(definate4.Value);
            }
            if (this is IIsDefinately<T5> definate5)
            {
                return f5(definate5.Value);
            }
            if (this is IIsDefinately<T6> definate6)
            {
                return f6(definate6.Value);
            }
            if (this is IIsDefinately<T7> definate7)
            {
                return f7(definate7.Value);
            }
            throw new Exception("bug!");
        }

        public override bool Equals(object obj)
        {
            if (obj is OrType<T1, T2, T3, T4, T5, T6,T7> other)
            {
                return other.Representative().NullSafeEqual(Representative());
            }
            return false;
        }

        public static implicit operator OrType<T1, T2, T3, T4, T5, T6, T7>(T1 t1) => OrType.Make<T1, T2, T3, T4, T5, T6, T7>(t1);
        public static implicit operator OrType<T1, T2, T3, T4, T5, T6, T7>(T2 t2) => OrType.Make<T1, T2, T3, T4, T5, T6, T7>(t2);
        public static implicit operator OrType<T1, T2, T3, T4, T5, T6, T7>(T3 t3) => OrType.Make<T1, T2, T3, T4, T5, T6, T7>(t3);
        public static implicit operator OrType<T1, T2, T3, T4, T5, T6, T7>(T4 t4) => OrType.Make<T1, T2, T3, T4, T5, T6, T7>(t4);
        public static implicit operator OrType<T1, T2, T3, T4, T5, T6, T7>(T5 t5) => OrType.Make<T1, T2, T3, T4, T5, T6, T7>(t5);
        public static implicit operator OrType<T1, T2, T3, T4, T5, T6, T7>(T6 t6) => OrType.Make<T1, T2, T3, T4, T5, T6, T7>(t6);
        public static implicit operator OrType<T1, T2, T3, T4, T5, T6, T7>(T7 t7) => OrType.Make<T1, T2, T3, T4, T5, T6, T7>(t7);
    }


#pragma warning disable CS0659 //
    public abstract class OrType<T1, T2, T3, T4, T5, T6, T7, T8> : p<T1, T2, T3, T4, T5, T6, T7, T8>, IOrType<T1, T2, T3, T4, T5, T6, T7, T8>
#pragma warning restore CS0659 // Type overrides Object.Equals(object o) but does not override Object.GetHashCode()
    {
        public bool Is<T>(out T res)
        {
            if (Representative() is T t)
            {
                res = t;
                return true;
            }
            res = default;
            return false;
        }

        public T1 Is1OrThrow()
        {
            if (this is IIsDefinately<T1> definate)
            {
                return definate.Value;
            }
            throw new Exception($"is not {typeof(T1)}");
        }

        public T2 Is2OrThrow()
        {
            if (this is IIsDefinately<T2> definate)
            {
                return definate.Value;
            }
            throw new Exception($"is not {typeof(T2)}");
        }
        public T3 Is3OrThrow()
        {
            if (this is IIsDefinately<T3> definate)
            {
                return definate.Value;
            }
            throw new Exception($"is not {typeof(T3)}");
        }
        public T4 Is4OrThrow()
        {
            if (this is IIsDefinately<T4> definate)
            {
                return definate.Value;
            }
            throw new Exception($"is not {typeof(T4)}");
        }
        public T5 Is5OrThrow()
        {
            if (this is IIsDefinately<T5> definate)
            {
                return definate.Value;
            }
            throw new Exception($"is not {typeof(T5)}");
        }
        public T6 Is6OrThrow()
        {
            if (this is IIsDefinately<T6> definate)
            {
                return definate.Value;
            }
            throw new Exception($"is not {typeof(T6)}");
        }
        public T7 Is7OrThrow()
        {
            if (this is IIsDefinately<T7> definate)
            {
                return definate.Value;
            }
            throw new Exception($"is not {typeof(T7)}");
        }
        public T8 Is8OrThrow()
        {
            if (this is IIsDefinately<T8> definate)
            {
                return definate.Value;
            }
            throw new Exception($"is not {typeof(T8)}");
        }
        public IIsPossibly<T1> Possibly1() => this;
        public IIsPossibly<T2> Possibly2() => this;
        public IIsPossibly<T3> Possibly3() => this;
        public IIsPossibly<T4> Possibly4() => this;
        public IIsPossibly<T5> Possibly5() => this;
        public IIsPossibly<T6> Possibly6() => this;
        public IIsPossibly<T7> Possibly7() => this;
        public IIsPossibly<T8> Possibly8() => this;
        public void Switch(Action<T1> a1, Action<T2> a2, Action<T3> a3, Action<T4> a4, Action<T5> a5, Action<T6> a6, Action<T7> a7, Action<T8> a8)
        {
            if (this is IIsDefinately<T1> definate1)
            {
                a1(definate1.Value);
            }
            else if (this is IIsDefinately<T2> definate2)
            {
                a2(definate2.Value);
            }
            else if (this is IIsDefinately<T3> definate3)
            {
                a3(definate3.Value);
            }
            else if (this is IIsDefinately<T4> definate4)
            {
                a4(definate4.Value);
            }
            else if (this is IIsDefinately<T5> definate5)
            {
                a5(definate5.Value);
            }
            else if (this is IIsDefinately<T6> definate6)
            {
                a6(definate6.Value);
            }
            else if (this is IIsDefinately<T7> definate7)
            {
                a7(definate7.Value);
            }
            else if (this is IIsDefinately<T8> definate8)
            {
                a8(definate8.Value);
            }
            else
            {
                throw new Exception("bug!");
            }
        }

        public T SwitchReturns<T>(Func<T1, T> f1, Func<T2, T> f2, Func<T3, T> f3, Func<T4, T> f4, Func<T5, T> f5, Func<T6, T> f6, Func<T7, T> f7, Func<T8, T> f8)
        {
            if (this is IIsDefinately<T1> definate1)
            {
                return f1(definate1.Value);
            }
            if (this is IIsDefinately<T2> definate2)
            {
                return f2(definate2.Value);
            }
            if (this is IIsDefinately<T3> definate3)
            {
                return f3(definate3.Value);
            }
            if (this is IIsDefinately<T4> definate4)
            {
                return f4(definate4.Value);
            }
            if (this is IIsDefinately<T5> definate5)
            {
                return f5(definate5.Value);
            }
            if (this is IIsDefinately<T6> definate6)
            {
                return f6(definate6.Value);
            }
            if (this is IIsDefinately<T7> definate7)
            {
                return f7(definate7.Value);
            }
            if (this is IIsDefinately<T8> definate8)
            {
                return f8(definate8.Value);
            }
            throw new Exception("bug!");
        }

        public override bool Equals(object obj)
        {
            if (obj is OrType<T1, T2, T3, T4, T5, T6, T7, T8> other)
            {
                return other.Representative().NullSafeEqual(Representative());
            }
            return false;
        }

        public static implicit operator OrType<T1, T2, T3, T4, T5, T6, T7, T8>(T1 t1) => OrType.Make<T1, T2, T3, T4, T5, T6, T7, T8>(t1);
        public static implicit operator OrType<T1, T2, T3, T4, T5, T6, T7, T8>(T2 t2) => OrType.Make<T1, T2, T3, T4, T5, T6, T7, T8>(t2);
        public static implicit operator OrType<T1, T2, T3, T4, T5, T6, T7, T8>(T3 t3) => OrType.Make<T1, T2, T3, T4, T5, T6, T7, T8>(t3);
        public static implicit operator OrType<T1, T2, T3, T4, T5, T6, T7, T8>(T4 t4) => OrType.Make<T1, T2, T3, T4, T5, T6, T7, T8>(t4);
        public static implicit operator OrType<T1, T2, T3, T4, T5, T6, T7, T8>(T5 t5) => OrType.Make<T1, T2, T3, T4, T5, T6, T7, T8>(t5);
        public static implicit operator OrType<T1, T2, T3, T4, T5, T6, T7, T8>(T6 t6) => OrType.Make<T1, T2, T3, T4, T5, T6, T7, T8>(t6);
        public static implicit operator OrType<T1, T2, T3, T4, T5, T6, T7, T8>(T7 t7) => OrType.Make<T1, T2, T3, T4, T5, T6, T7, T8>(t7);
    }

    public class OrType_1<T1, T2> : OrType<T1, T2>, IIsDefinately<T1>
    {
        public OrType_1(T1 value)
        {
            this.Value = value;
        }

        public new T1 Value { get; }

        public override object Representative() => Value;
    }
    public class OrType_2<T1, T2> : OrType<T1, T2>, IIsDefinately<T2>
    {
        public OrType_2(T2 value)
        {
            this.Value = value;
        }

        public T2 Value { get; }
        public override object Representative() => Value;
    }

    public class OrType_1<T1, T2, T3> : OrType<T1, T2, T3>, IIsDefinately<T1>
    {
        public OrType_1(T1 value)
        {
            this.Value = value;
        }

        public T1 Value { get; }
        public override object Representative() => Value;
    }
    public class OrType_2<T1, T2, T3> : OrType<T1, T2, T3>, IIsDefinately<T2>
    {
        public OrType_2(T2 value)
        {
            this.Value = value;
        }

        public T2 Value { get; }
        public override object Representative() => Value;
    }
    public class OrType_3<T1, T2, T3> : OrType<T1, T2, T3>, IIsDefinately<T3>
    {
        public OrType_3(T3 value)
        {
            this.Value = value;
        }

        public T3 Value { get; }
        public override object Representative() => Value;
    }

    public class OrType_1<T1, T2, T3, T4> : OrType<T1, T2, T3, T4>, IIsDefinately<T1>
    {
        public OrType_1(T1 value)
        {
            this.Value = value;
        }

        public T1 Value { get; }
        public override object Representative() => Value;
    }
    public class OrType_2<T1, T2, T3, T4> : OrType<T1, T2, T3, T4>, IIsDefinately<T2>
    {
        public OrType_2(T2 value)
        {
            this.Value = value;
        }

        public T2 Value { get; }
        public override object Representative() => Value;
    }
    public class OrType_3<T1, T2, T3, T4> : OrType<T1, T2, T3, T4>, IIsDefinately<T3>
    {
        public OrType_3(T3 value)
        {
            this.Value = value;
        }

        public T3 Value { get; }
        public override object Representative() => Value;
    }
    public class OrType_4<T1, T2, T3, T4> : OrType<T1, T2, T3, T4>, IIsDefinately<T4>
    {
        public OrType_4(T4 value)
        {
            this.Value = value;
        }

        public T4 Value { get; }
        public override object Representative() => Value;
    }

    public class OrType_1<T1, T2, T3, T4, T5> : OrType<T1, T2, T3, T4, T5>, IIsDefinately<T1>
    {
        public OrType_1(T1 value)
        {
            this.Value = value;
        }

        public T1 Value { get; }
        public override object Representative() => Value;
    }
    public class OrType_2<T1, T2, T3, T4, T5> : OrType<T1, T2, T3, T4, T5>, IIsDefinately<T2>
    {
        public OrType_2(T2 value)
        {
            this.Value = value;
        }

        public T2 Value { get; }
        public override object Representative() => Value;
    }
    public class OrType_3<T1, T2, T3, T4, T5> : OrType<T1, T2, T3, T4, T5>, IIsDefinately<T3>
    {
        public OrType_3(T3 value)
        {
            this.Value = value;
        }

        public T3 Value { get; }
        public override object Representative() => Value;
    }
    public class OrType_4<T1, T2, T3, T4, T5> : OrType<T1, T2, T3, T4, T5>, IIsDefinately<T4>
    {
        public OrType_4(T4 value)
        {
            this.Value = value;
        }

        public T4 Value { get; }
        public override object Representative() => Value;
    }
    public class OrType_5<T1, T2, T3, T4, T5> : OrType<T1, T2, T3, T4, T5>, IIsDefinately<T5>
    {
        public OrType_5(T5 value)
        {
            this.Value = value;
        }

        public T5 Value { get; }
        public override object Representative() => Value;
    }


    public class OrType_1<T1, T2, T3, T4, T5, T6> : OrType<T1, T2, T3, T4, T5, T6>, IIsDefinately<T1>
    {
        public OrType_1(T1 value)
        {
            this.Value = value;
        }

        public T1 Value { get; }
        public override object Representative() => Value;
    }
    public class OrType_2<T1, T2, T3, T4, T5, T6> : OrType<T1, T2, T3, T4, T5, T6>, IIsDefinately<T2>
    {
        public OrType_2(T2 value)
        {
            this.Value = value;
        }

        public T2 Value { get; }
        public override object Representative() => Value;
    }
    public class OrType_3<T1, T2, T3, T4, T5, T6> : OrType<T1, T2, T3, T4, T5, T6>, IIsDefinately<T3>
    {
        public OrType_3(T3 value)
        {
            this.Value = value;
        }

        public T3 Value { get; }
        public override object Representative() => Value;
    }
    public class OrType_4<T1, T2, T3, T4, T5, T6> : OrType<T1, T2, T3, T4, T5, T6>, IIsDefinately<T4>
    {
        public OrType_4(T4 value)
        {
            this.Value = value;
        }

        public T4 Value { get; }
        public override object Representative() => Value;
    }
    public class OrType_5<T1, T2, T3, T4, T5, T6> : OrType<T1, T2, T3, T4, T5, T6>, IIsDefinately<T5>
    {
        public OrType_5(T5 value)
        {
            this.Value = value;
        }

        public T5 Value { get; }
        public override object Representative() => Value;
    }

    public class OrType_6<T1, T2, T3, T4, T5, T6> : OrType<T1, T2, T3, T4, T5, T6>, IIsDefinately<T6>
    {
        public OrType_6(T6 value)
        {
            this.Value = value;
        }

        public T6 Value { get; }
        public override object Representative() => Value;
    }


    public class OrType_1<T1, T2, T3, T4, T5, T6, T7> : OrType<T1, T2, T3, T4, T5, T6, T7>, IIsDefinately<T1>
    {
        public OrType_1(T1 value)
        {
            this.Value = value;
        }

        public T1 Value { get; }
        public override object Representative() => Value;
    }
    public class OrType_2<T1, T2, T3, T4, T5, T6, T7> : OrType<T1, T2, T3, T4, T5, T6, T7>, IIsDefinately<T2>
    {
        public OrType_2(T2 value)
        {
            this.Value = value;
        }

        public T2 Value { get; }
        public override object Representative() => Value;
    }
    public class OrType_3<T1, T2, T3, T4, T5, T6, T7> : OrType<T1, T2, T3, T4, T5, T6, T7>, IIsDefinately<T3>
    {
        public OrType_3(T3 value)
        {
            this.Value = value;
        }

        public T3 Value { get; }
        public override object Representative() => Value;
    }
    public class OrType_4<T1, T2, T3, T4, T5, T6, T7> : OrType<T1, T2, T3, T4, T5, T6, T7>, IIsDefinately<T4>
    {
        public OrType_4(T4 value)
        {
            this.Value = value;
        }

        public T4 Value { get; }
        public override object Representative() => Value;
    }
    public class OrType_5<T1, T2, T3, T4, T5, T6, T7> : OrType<T1, T2, T3, T4, T5, T6, T7>, IIsDefinately<T5>
    {
        public OrType_5(T5 value)
        {
            this.Value = value;
        }

        public T5 Value { get; }
        public override object Representative() => Value;
    }

    public class OrType_6<T1, T2, T3, T4, T5, T6, T7> : OrType<T1, T2, T3, T4, T5, T6, T7>, IIsDefinately<T6>
    {
        public OrType_6(T6 value)
        {
            this.Value = value;
        }

        public T6 Value { get; }
        public override object Representative() => Value;
    }


    public class OrType_7<T1, T2, T3, T4, T5, T6, T7> : OrType<T1, T2, T3, T4, T5, T6, T7>, IIsDefinately<T7>
    {
        public OrType_7(T7 value)
        {
            this.Value = value;
        }

        public T7 Value { get; }
        public override object Representative() => Value;
    }


    public class OrType_1<T1, T2, T3, T4, T5, T6, T7, T8> : OrType<T1, T2, T3, T4, T5, T6, T7, T8>, IIsDefinately<T1>
    {
        public OrType_1(T1 value)
        {
            this.Value = value;
        }

        public T1 Value { get; }
        public override object Representative() => Value;
    }
    public class OrType_2<T1, T2, T3, T4, T5, T6, T7, T8> : OrType<T1, T2, T3, T4, T5, T6, T7, T8>, IIsDefinately<T2>
    {
        public OrType_2(T2 value)
        {
            this.Value = value;
        }

        public T2 Value { get; }
        public override object Representative() => Value;
    }
    public class OrType_3<T1, T2, T3, T4, T5, T6, T7, T8> : OrType<T1, T2, T3, T4, T5, T6, T7, T8>, IIsDefinately<T3>
    {
        public OrType_3(T3 value)
        {
            this.Value = value;
        }

        public T3 Value { get; }
        public override object Representative() => Value;
    }
    public class OrType_4<T1, T2, T3, T4, T5, T6, T7, T8> : OrType<T1, T2, T3, T4, T5, T6, T7, T8>, IIsDefinately<T4>
    {
        public OrType_4(T4 value)
        {
            this.Value = value;
        }

        public T4 Value { get; }
        public override object Representative() => Value;
    }
    public class OrType_5<T1, T2, T3, T4, T5, T6, T7, T8> : OrType<T1, T2, T3, T4, T5, T6, T7, T8>, IIsDefinately<T5>
    {
        public OrType_5(T5 value)
        {
            this.Value = value;
        }

        public T5 Value { get; }
        public override object Representative() => Value;
    }

    public class OrType_6<T1, T2, T3, T4, T5, T6, T7, T8> : OrType<T1, T2, T3, T4, T5, T6, T7, T8>, IIsDefinately<T6>
    {
        public OrType_6(T6 value)
        {
            this.Value = value;
        }

        public T6 Value { get; }
        public override object Representative() => Value;
    }


    public class OrType_7<T1, T2, T3, T4, T5, T6, T7, T8> : OrType<T1, T2, T3, T4, T5, T6, T7, T8>, IIsDefinately<T7>
    {
        public OrType_7(T7 value)
        {
            this.Value = value;
        }

        public T7 Value { get; }
        public override object Representative() => Value;
    }

    public class OrType_8<T1, T2, T3, T4, T5, T6, T7, T8> : OrType<T1, T2, T3, T4, T5, T6, T7, T8>, IIsDefinately<T8>
    {
        public OrType_8(T8 value)
        {
            this.Value = value;
        }

        public T8 Value { get; }
        public override object Representative() => Value;
    }

    public class OrType {

        public static OrType<T1, T2> Make<T1, T2>(T1 value) => new OrType_1<T1,T2>(value);
        public static OrType<T1, T2> Make<T1, T2>(T2 value) => new OrType_2<T1, T2>(value);
        
        public static OrType<T1, T2,T3> Make<T1, T2,T3>(T1 value) => new OrType_1<T1, T2,T3>(value);
        public static OrType<T1, T2,T3> Make<T1, T2,T3>(T2 value) => new OrType_2<T1, T2,T3>(value);
        public static OrType<T1, T2, T3> Make<T1, T2, T3>(T3 value) => new OrType_3<T1, T2, T3>(value);
        
        public static OrType<T1, T2, T3,T4> Make<T1, T2, T3, T4>(T1 value) => new OrType_1<T1, T2, T3, T4>(value);
        public static OrType<T1, T2, T3, T4> Make<T1, T2, T3, T4>(T2 value) => new OrType_2<T1, T2, T3, T4>(value);
        public static OrType<T1, T2, T3, T4> Make<T1, T2, T3, T4>(T3 value) => new OrType_3<T1, T2, T3, T4>(value);
        public static OrType<T1, T2, T3, T4> Make<T1, T2, T3, T4>(T4 value) => new OrType_4<T1, T2, T3, T4>(value);

        public static OrType<T1, T2, T3, T4,T5> Make<T1, T2, T3, T4, T5>(T1 value) => new OrType_1<T1, T2, T3, T4, T5>(value);
        public static OrType<T1, T2, T3, T4, T5> Make<T1, T2, T3, T4, T5>(T2 value) => new OrType_2<T1, T2, T3, T4, T5>(value);
        public static OrType<T1, T2, T3, T4, T5> Make<T1, T2, T3, T4, T5>(T3 value) => new OrType_3<T1, T2, T3, T4, T5>(value);
        public static OrType<T1, T2, T3, T4, T5> Make<T1, T2, T3, T4, T5>(T4 value) => new OrType_4<T1, T2, T3, T4, T5>(value);
        public static OrType<T1, T2, T3, T4, T5> Make<T1, T2, T3, T4, T5>(T5 value) => new OrType_5<T1, T2, T3, T4, T5>(value);

        public static OrType<T1, T2, T3, T4, T5, T6> Make<T1, T2, T3, T4, T5, T6>(T1 value) => new OrType_1<T1, T2, T3, T4, T5, T6>(value);
        public static OrType<T1, T2, T3, T4, T5, T6> Make<T1, T2, T3, T4, T5, T6>(T2 value) => new OrType_2<T1, T2, T3, T4, T5, T6>(value);
        public static OrType<T1, T2, T3, T4, T5, T6> Make<T1, T2, T3, T4, T5, T6>(T3 value) => new OrType_3<T1, T2, T3, T4, T5, T6>(value);
        public static OrType<T1, T2, T3, T4, T5, T6> Make<T1, T2, T3, T4, T5, T6>(T4 value) => new OrType_4<T1, T2, T3, T4, T5, T6>(value);
        public static OrType<T1, T2, T3, T4, T5, T6> Make<T1, T2, T3, T4, T5, T6>(T5 value) => new OrType_5<T1, T2, T3, T4, T5, T6>(value);
        public static OrType<T1, T2, T3, T4, T5, T6> Make<T1, T2, T3, T4, T5, T6>(T6 value) => new OrType_6<T1, T2, T3, T4, T5, T6>(value);

        public static OrType<T1, T2, T3, T4, T5, T6, T7> Make<T1, T2, T3, T4, T5, T6, T7>(T1 value) => new OrType_1<T1, T2, T3, T4, T5, T6, T7>(value);
        public static OrType<T1, T2, T3, T4, T5, T6, T7> Make<T1, T2, T3, T4, T5, T6, T7>(T2 value) => new OrType_2<T1, T2, T3, T4, T5, T6, T7>(value);
        public static OrType<T1, T2, T3, T4, T5, T6, T7> Make<T1, T2, T3, T4, T5, T6, T7>(T3 value) => new OrType_3<T1, T2, T3, T4, T5, T6, T7>(value);
        public static OrType<T1, T2, T3, T4, T5, T6, T7> Make<T1, T2, T3, T4, T5, T6, T7>(T4 value) => new OrType_4<T1, T2, T3, T4, T5, T6, T7>(value);
        public static OrType<T1, T2, T3, T4, T5, T6, T7> Make<T1, T2, T3, T4, T5, T6, T7>(T5 value) => new OrType_5<T1, T2, T3, T4, T5, T6, T7>(value);
        public static OrType<T1, T2, T3, T4, T5, T6, T7> Make<T1, T2, T3, T4, T5, T6, T7>(T6 value) => new OrType_6<T1, T2, T3, T4, T5, T6, T7>(value);
        public static OrType<T1, T2, T3, T4, T5, T6, T7> Make<T1, T2, T3, T4, T5, T6, T7>(T7 value) => new OrType_7<T1, T2, T3, T4, T5, T6, T7>(value);

        public static OrType<T1, T2, T3, T4, T5, T6, T7, T8> Make<T1, T2, T3, T4, T5, T6, T7, T8>(T1 value) => new OrType_1<T1, T2, T3, T4, T5, T6, T7, T8>(value);
        public static OrType<T1, T2, T3, T4, T5, T6, T7, T8> Make<T1, T2, T3, T4, T5, T6, T7, T8>(T2 value) => new OrType_2<T1, T2, T3, T4, T5, T6, T7, T8>(value);
        public static OrType<T1, T2, T3, T4, T5, T6, T7, T8> Make<T1, T2, T3, T4, T5, T6, T7, T8>(T3 value) => new OrType_3<T1, T2, T3, T4, T5, T6, T7, T8>(value);
        public static OrType<T1, T2, T3, T4, T5, T6, T7, T8> Make<T1, T2, T3, T4, T5, T6, T7, T8>(T4 value) => new OrType_4<T1, T2, T3, T4, T5, T6, T7, T8>(value);
        public static OrType<T1, T2, T3, T4, T5, T6, T7, T8> Make<T1, T2, T3, T4, T5, T6, T7, T8>(T5 value) => new OrType_5<T1, T2, T3, T4, T5, T6, T7, T8>(value);
        public static OrType<T1, T2, T3, T4, T5, T6, T7, T8> Make<T1, T2, T3, T4, T5, T6, T7, T8>(T6 value) => new OrType_6<T1, T2, T3, T4, T5, T6, T7, T8>(value);
        public static OrType<T1, T2, T3, T4, T5, T6, T7, T8> Make<T1, T2, T3, T4, T5, T6, T7, T8>(T7 value) => new OrType_7<T1, T2, T3, T4, T5, T6, T7, T8>(value);
        public static OrType<T1, T2, T3, T4, T5, T6, T7, T8> Make<T1, T2, T3, T4, T5, T6, T7, T8>(T8 value) => new OrType_8<T1, T2, T3, T4, T5, T6, T7, T8>(value);

    }

}
