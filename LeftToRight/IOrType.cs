using System;

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
}