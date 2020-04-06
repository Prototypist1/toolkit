using System;
using System.Collections.Generic;

namespace Prototypist.Toolbox
{
//    // these are sort of a hack: https://stackoverflow.com/questions/7664790/why-does-the-c-sharp-compiler-complain-that-types-may-unify-when-they-derive-f/51297066#51297066
//    // underscore to indicate such
//#pragma warning disable IDE1006 // Naming Styles
//    public abstract class _OrType1<T1> :  IIsPossibly<T1> { }
//    public abstract class _OrType2<T1, T2> : _OrType1<T1>, IIsPossibly<T2> { }
//    public abstract class _OrType3<T1, T2, T3> : _OrType2<T1, T2>, IIsPossibly<T3> { }
//    public abstract class _OrType4<T1, T2, T3, T4> : _OrType3<T1, T2, T3>, IIsPossibly<T4> { }
//#pragma warning restore IDE1006 // Naming Styles

    public class OrType<T1, T2> : IOrType<T1, T2>, IEquatable<OrType<T1, T2>>
    {
        private readonly T1 t1;
        private readonly bool isT1;
        private readonly T2 t2;
        private readonly bool isT2;

        public OrType(T1 t1)
        {
            isT1 = true;
            this.t1 = t1;
        }

        public OrType(T2 t2)
        {
            isT2 = true;
            this.t2 = t2;
        }

        
        public IIsPossibly<T1> Possibly1()
        {
            if (isT1)
            {
                return Possibly.Is(t1);
            }
            return Possibly.IsNot<T1>();
        }

        
        public IIsPossibly<T2> Possibly2()
        {
            if (isT2)
            {
                return Possibly.Is(t2);
            }
            return Possibly.IsNot<T2>();
        }

        public T1 Is1OrThrow()
        {
            if (isT1)
            {
                return t1;
            }
            throw new ApplicationException($"expect {typeof(T1).FullName}");
        }
        public T2 Is2OrThrow()
        {
            if (isT2)
            {
                return t2;
            }
            throw new ApplicationException($"expect {typeof(T2).FullName}");
        }

        public void Switch(Action<T1> a1, Action<T2> a2)
        {
            if (isT1)
            {
                a1(t1);
            }
            if (isT2)
            {
                a2(t2);
            }
        }

        public T SwitchReturns<T>(Func<T1, T> a1, Func<T2, T> a2)
        {
            if (isT1)
            {
                return a1(t1);
            }
            if (isT2)
            {
                return a2(t2);
            }
            throw new Exception("or type is none of it's types");
        }

        public bool Is<T>(out T res)
        {
            if (isT1 && t1 is T res1)
            {
                res = res1;
                return true;
            }
            if (isT2 && t2 is T res2)
            {
                res = res2;
                return true;
            }
            throw new Exception("or type is none of it's types");
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as OrType<T1, T2>);
        }

        public bool Equals(OrType<T1, T2> other)
        {
            return other != null &&
                   EqualityComparer<T1>.Default.Equals(t1, other.t1) &&
                   isT1 == other.isT1 &&
                   EqualityComparer<T2>.Default.Equals(t2, other.t2) &&
                   isT2 == other.isT2;
        }

        public override int GetHashCode()
        {
            var hashCode = -447460166;
            hashCode = (hashCode * -1521134295) + EqualityComparer<T1>.Default.GetHashCode(t1);
            hashCode = (hashCode * -1521134295) + isT1.GetHashCode();
            hashCode = (hashCode * -1521134295) + EqualityComparer<T2>.Default.GetHashCode(t2);
            hashCode = (hashCode * -1521134295) + isT2.GetHashCode();
            return hashCode;
        }
    }

    public class OrType<T1, T2, T3> : IOrType<T1, T2,T3>, IEquatable<OrType<T1, T2, T3>>
    {
        private readonly T1 t1;
        private readonly bool isT1;
        private readonly T2 t2;
        private readonly bool isT2;
        private readonly T3 t3;
        private readonly bool isT3;

        public OrType(T1 t1)
        {
            isT1 = true;
            this.t1 = t1;
        }

        public OrType(T2 t2)
        {
            isT2 = true;
            this.t2 = t2;
        }


        public OrType(T3 t3)
        {
            isT3 = true;
            this.t3 = t3;
        }

        
        public IIsPossibly<T1> Possibly1()
        {
            if (isT1)
            {
                return Possibly.Is(t1);
            }
            return Possibly.IsNot<T1>();
        }

        
        public IIsPossibly<T2> Possibly2()
        {
            if (isT2)
            {
                return Possibly.Is(t2);
            }
            return Possibly.IsNot<T2>();
        }
        
        public IIsPossibly<T3> Possibly3()
        {
            if (isT3)
            {
                return Possibly.Is(t3);
            }
            return Possibly.IsNot<T3>();
        }

        public T1 Is1OrThrow()
        {
            if (isT1)
            {
                return t1;
            }
            throw new ApplicationException($"expect {typeof(T1).FullName}");
        }
        public T2 Is2OrThrow()
        {
            if (isT2)
            {
                return t2;
            }
            throw new ApplicationException($"expect {typeof(T2).FullName}");
        }
        public T3 Is3OrThrow()
        {
            if (isT3)
            {
                return t3;
            }
            throw new ApplicationException($"expect {typeof(T3).FullName}");
        }


        public void Switch(Action<T1> a1, Action<T2> a2, Action<T3> a3)
        {
            if (isT1)
            {
                a1(t1);
            }
            if (isT2)
            {
                a2(t2);
            }
            if (isT3)
            {
                a3(t3);
            }
        }

        public T SwitchReturns<T>(Func<T1, T> a1, Func<T2, T> a2, Func<T3,T> a3)
        {
            if (isT1)
            {
                return a1(t1);
            }
            if (isT2)
            {
                return a2(t2);
            }
            if (isT3)
            {
                return a3(t3);
            }
            throw new Exception("or type is none of it's types");
        }

        public bool Is<T>(out T res)
        {
            if (isT1 && t1 is T res1)
            {
                res = res1;
                return true;
            }
            if (isT2 && t2 is T res2)
            {
                res = res2;
                return true;
            }
            if (isT3 && t3 is T res3)
            {
                res = res3;
                return true;
            }
            throw new Exception("or type is none of it's types");
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as OrType<T1, T2, T3>);
        }

        public bool Equals(OrType<T1, T2, T3> other)
        {
            return other != null &&
                   EqualityComparer<T1>.Default.Equals(t1, other.t1) &&
                   isT1 == other.isT1 &&
                   EqualityComparer<T2>.Default.Equals(t2, other.t2) &&
                   isT2 == other.isT2 &&
                   EqualityComparer<T3>.Default.Equals(t3, other.t3) &&
                   isT3 == other.isT3;
        }

        public override int GetHashCode()
        {
            var hashCode = 2049221290;
            hashCode = (hashCode * -1521134295) + EqualityComparer<T1>.Default.GetHashCode(t1);
            hashCode = (hashCode * -1521134295) + isT1.GetHashCode();
            hashCode = (hashCode * -1521134295) + EqualityComparer<T2>.Default.GetHashCode(t2);
            hashCode = (hashCode * -1521134295) + isT2.GetHashCode();
            hashCode = (hashCode * -1521134295) + EqualityComparer<T3>.Default.GetHashCode(t3);
            hashCode = (hashCode * -1521134295) + isT3.GetHashCode();
            return hashCode;
        }
    }

    public class OrType<T1, T2, T3, T4> : IOrType<T1, T2, T3,T4>, IEquatable<OrType<T1, T2, T3, T4>>
    {
        private readonly T1 t1;
        private readonly bool isT1;
        private readonly T2 t2;
        private readonly bool isT2;
        private readonly T3 t3;
        private readonly bool isT3;
        private readonly T4 t4;
        private readonly bool isT4;

        public OrType(T1 t1)
        {
            isT1 = true;
            this.t1 = t1;
        }

        public OrType(T2 t2)
        {
            isT2 = true;
            this.t2 = t2;
        }
        
        public OrType(T3 t3)
        {
            isT3 = true;
            this.t3 = t3;
        }

        public OrType(T4 t4)
        {
            isT4 = true;
            this.t4 = t4;
        }


        
        public IIsPossibly<T1> Possibly1()
        {
            if (isT1)
            {
                return Possibly.Is(t1);
            }
            return Possibly.IsNot<T1>();
        }

        
        public IIsPossibly<T2> Possibly2()
        {
            if (isT2)
            {
                return Possibly.Is(t2);
            }
            return Possibly.IsNot<T2>();
        }

        
        public IIsPossibly<T3> Possibly3()
        {
            if (isT3)
            {
                return Possibly.Is(t3);
            }
            return Possibly.IsNot<T3>();
        }

        
        public IIsPossibly<T4> Possibly4()
        {
            if (isT4)
            {
                return Possibly.Is(t4);
            }
            return Possibly.IsNot<T4>();
        }

        public T1 Is1OrThrow()
        {
            if (isT1)
            {
                return t1;
            }
            throw new ApplicationException($"expect {typeof(T1).FullName}");
        }
        public T2 Is2OrThrow()
        {
            if (isT2)
            {
                return t2;
            }
            throw new ApplicationException($"expect {typeof(T2).FullName}");
        }
        public T3 Is3OrThrow()
        {
            if (isT3)
            {
                return t3;
            }
            throw new ApplicationException($"expect {typeof(T3).FullName}");
        }
        public T4 Is4OrThrow()
        {
            if (isT4)
            {
                return t4;
            }
            throw new ApplicationException($"expect {typeof(T4).FullName}");
        }


        public void Switch(Action<T1> a1, Action<T2> a2, Action<T3> a3, Action<T4> a4)
        {
            if (isT1)
            {
                a1(t1);
            }
            if (isT2)
            {
                a2(t2);
            }
            if (isT3)
            {
                a3(t3);
            }
            if (isT4)
            {
                a4(t4);
            }
        }

        public T SwitchReturns<T>(Func<T1, T> a1, Func<T2, T> a2, Func<T3, T> a3, Func<T4, T> a4)
        {
            if (isT1)
            {
                return a1(t1);
            }
            if (isT2)
            {
                return a2(t2);
            }
            if (isT3)
            {
                return a3(t3);
            }
            if (isT4)
            {
                return a4(t4);
            }
            throw new Exception("or type is none of it's types");
        }

        public bool Is<T>(out T res)
        {
            if (isT1 && t1 is T res1)
            {
                res = res1;
                return true;
            }
            if (isT2 && t2 is T res2)
            {
                res = res2;
                return true;
            }
            if (isT3 && t3 is T res3)
            {
                res = res3;
                return true;
            }
            if (isT4 && t4 is T res4)
            {
                res = res4;
                return true;
            }
            throw new Exception("or type is none of it's types");
        }


        public override bool Equals(object obj)
        {
            return Equals(obj as OrType<T1, T2, T3, T4>);
        }

        public bool Equals(OrType<T1, T2, T3, T4> other)
        {
            return other != null &&
                   EqualityComparer<T1>.Default.Equals(t1, other.t1) &&
                   isT1 == other.isT1 &&
                   EqualityComparer<T2>.Default.Equals(t2, other.t2) &&
                   isT2 == other.isT2 &&
                   EqualityComparer<T3>.Default.Equals(t3, other.t3) &&
                   isT3 == other.isT3 &&
                   EqualityComparer<T4>.Default.Equals(t4, other.t4) &&
                   isT4 == other.isT4;
        }

        public override int GetHashCode()
        {
            var hashCode = 1611974508;
            hashCode = (hashCode * -1521134295) + EqualityComparer<T1>.Default.GetHashCode(t1);
            hashCode = (hashCode * -1521134295) + isT1.GetHashCode();
            hashCode = (hashCode * -1521134295) + EqualityComparer<T2>.Default.GetHashCode(t2);
            hashCode = (hashCode * -1521134295) + isT2.GetHashCode();
            hashCode = (hashCode * -1521134295) + EqualityComparer<T3>.Default.GetHashCode(t3);
            hashCode = (hashCode * -1521134295) + isT3.GetHashCode();
            hashCode = (hashCode * -1521134295) + EqualityComparer<T4>.Default.GetHashCode(t4);
            hashCode = (hashCode * -1521134295) + isT4.GetHashCode();
            return hashCode;
        }
    }

    public class OrType<T1, T2, T3, T4, T5> : IOrType<T1, T2, T3, T4,T5>, IEquatable<OrType<T1, T2, T3, T4, T5>>
    {
        private readonly T1 t1;
        private readonly bool isT1;
        private readonly T2 t2;
        private readonly bool isT2;
        private readonly T3 t3;
        private readonly bool isT3;
        private readonly T4 t4;
        private readonly bool isT4;
        private readonly T5 t5;
        private readonly bool isT5;

        public OrType(T1 t1)
        {
            isT1 = true;
            this.t1 = t1;
        }

        public OrType(T2 t2)
        {
            isT2 = true;
            this.t2 = t2;
        }

        public OrType(T3 t3)
        {
            isT3 = true;
            this.t3 = t3;
        }

        public OrType(T4 t4)
        {
            isT4 = true;
            this.t4 = t4;
        }

        public OrType(T5 t5)
        {
            isT5 = true;
            this.t5 = t5;
        }



        
        public IIsPossibly<T1> Possibly1()
        {
            if (isT1)
            {
                return Possibly.Is(t1);
            }
            return Possibly.IsNot<T1>();
        }

        
        public IIsPossibly<T2> Possibly2()
        {
            if (isT2)
            {
                return Possibly.Is(t2);
            }
            return Possibly.IsNot<T2>();
        }
        
        public IIsPossibly<T3> Possibly3()
        {
            if (isT3)
            {
                return Possibly.Is(t3);
            }
            return Possibly.IsNot<T3>();
        }

        public IIsPossibly<T4> Possibly4()
        {
            if (isT4)
            {
                return Possibly.Is(t4);
            }
            return Possibly.IsNot<T4>();
        }

        public IIsPossibly<T5> Possibly5()
        {
            if (isT5)
            {
                return Possibly.Is(t5);
            }
            return Possibly.IsNot<T5>();
        }

        public T1 Is1OrThrow()
        {
            if (isT1)
            {
                return t1;
            }
            throw new ApplicationException($"expect {typeof(T1).FullName}");
        }
        public T2 Is2OrThrow()
        {
            if (isT2)
            {
                return t2;
            }
            throw new ApplicationException($"expect {typeof(T2).FullName}");
        }
        public T3 Is3OrThrow()
        {
            if (isT3)
            {
                return t3;
            }
            throw new ApplicationException($"expect {typeof(T3).FullName}");
        }
        public T4 Is4OrThrow()
        {
            if (isT4)
            {
                return t4;
            }
            throw new ApplicationException($"expect {typeof(T4).FullName}");
        }

        public T5 Is5OrThrow()
        {
            if (isT5)
            {
                return t5;
            }
            throw new ApplicationException($"expect {typeof(T5).FullName}");
        }


        public void Switch(Action<T1> a1, Action<T2> a2, Action<T3> a3, Action<T4> a4, Action<T5> a5)
        {
            if (isT1)
            {
                a1(t1);
            }
            if (isT2)
            {
                a2(t2);
            }
            if (isT3)
            {
                a3(t3);
            }
            if (isT4)
            {
                a4(t4);
            }
            if (isT5)
            {
                a5(t5);
            }
        }

        public T SwitchReturns<T>(Func<T1, T> a1, Func<T2, T> a2, Func<T3, T> a3, Func<T4, T> a4, Func<T5, T> a5)
        {
            if (isT1)
            {
                return a1(t1);
            }
            if (isT2)
            {
                return a2(t2);
            }
            if (isT3)
            {
                return a3(t3);
            }
            if (isT4)
            {
                return a4(t4);
            }
            if (isT5)
            {
                return a5(t5);
            }
            throw new Exception("or type is none of it's types");
        }

        public bool Is<T>(out T res)
        {
            if (isT1 && t1 is T res1)
            {
                res = res1;
                return true;
            }
            if (isT2 && t2 is T res2)
            {
                res = res2;
                return true;
            }
            if (isT3 && t3 is T res3)
            {
                res = res3;
                return true;
            }
            if (isT4 && t4 is T res4)
            {
                res = res4;
                return true;
            }
            if (isT5 && t5 is T res5)
            {
                res = res5;
                return true;
            }
            throw new Exception("or type is none of it's types");
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as OrType<T1, T2, T3, T4, T5>);
        }

        public bool Equals(OrType<T1, T2, T3, T4, T5> other)
        {
            return other != null &&
                   EqualityComparer<T1>.Default.Equals(t1, other.t1) &&
                   isT1 == other.isT1 &&
                   EqualityComparer<T2>.Default.Equals(t2, other.t2) &&
                   isT2 == other.isT2 &&
                   EqualityComparer<T3>.Default.Equals(t3, other.t3) &&
                   isT3 == other.isT3 &&
                   EqualityComparer<T4>.Default.Equals(t4, other.t4) &&
                   isT4 == other.isT4 &&
                   EqualityComparer<T5>.Default.Equals(t5, other.t5) &&
                   isT5 == other.isT5;
        }

        public override int GetHashCode()
        {
            var hashCode = -527366096;
            hashCode = (hashCode * -1521134295) + EqualityComparer<T1>.Default.GetHashCode(t1);
            hashCode = (hashCode * -1521134295) + isT1.GetHashCode();
            hashCode = (hashCode * -1521134295) + EqualityComparer<T2>.Default.GetHashCode(t2);
            hashCode = (hashCode * -1521134295) + isT2.GetHashCode();
            hashCode = (hashCode * -1521134295) + EqualityComparer<T3>.Default.GetHashCode(t3);
            hashCode = (hashCode * -1521134295) + isT3.GetHashCode();
            hashCode = (hashCode * -1521134295) + EqualityComparer<T4>.Default.GetHashCode(t4);
            hashCode = (hashCode * -1521134295) + isT4.GetHashCode();
            hashCode = (hashCode * -1521134295) + EqualityComparer<T5>.Default.GetHashCode(t5);
            hashCode = (hashCode * -1521134295) + isT5.GetHashCode();
            return hashCode;
        }
    }




    public class OrType {


        
        private class y<T1> : IIsDefinately<T1> { public y(T1 value) { Value = value; } public T1 Value { get; }}
        private class n<T1> : IIsDefinatelyNot<T1> { }


        private class ny<T1, T2> : n<T1>, IIsDefinately<T2> { public ny(T2 value) { Value = value; } public T2 Value { get; } }
        private class nn<T1, T2> : n<T1>, IIsDefinatelyNot<T2> { }
        private class yn<T1, T2> : y<T1>, IIsDefinatelyNot<T2>
        {
            public yn(T1 t1) : base(t1)
            {
            }
        }

        private class oyn<T1, T2> : yn<T1, T2>, IOrType<T1, T2>
        {
            public oyn(T1 value) : base(value)
            {
            }
        }
        private class ony<T1, T2> : ny<T1, T2>, IOrType<T1, T2>
        {
            public ony(T2 value) : base(value)
            {
            }
        }

        private class nny<T1, T2, T3> : nn<T1, T2>, IIsDefinately<T3> { public nny(T3 value) { Value = value; } public T3 Value { get; } }
        private class nnn<T1, T2,T3> : nn<T1,T2>, IIsDefinatelyNot<T3> { }
        private class nyn<T1, T2, T3> : ny<T1, T2>, IIsDefinatelyNot<T3>
        {
            public nyn(T2 value) : base(value)
            {
            }
        }
        private class ynn<T1, T2, T3> : yn<T1, T2>, IIsDefinatelyNot<T3>
        {
            public ynn(T1 t1) : base(t1)
            {
            }
        }


        private class oynn<T1, T2,T3> : ynn<T1, T2,T3>, IOrType<T1, T2,T3>
        {
            public oynn(T1 value) : base(value)
            {
            }
        }
        private class onyn<T1, T2,T3> : nyn<T1, T2,T3>, IOrType<T1, T2,T3>
        {
            public onyn(T2 value) : base(value)
            {
            }
        }

        private class onny<T1, T2, T3> : nny<T1, T2, T3>, IOrType<T1, T2, T3>
        {
            public onny(T3 value) : base(value)
            {
            }
        }

        private class nnny<T1, T2, T3, T4> : nnn<T1, T2, T3>, IIsDefinately<T4> { public nnny(T4 value) { Value = value; } public T4 Value { get; } }
        private class nnnn<T1, T2, T3, T4> : nnn<T1, T2, T3>, IIsDefinatelyNot<T4> { }
        private class nnyn<T1, T2, T3, T4> : nny<T1, T2, T3>, IIsDefinatelyNot<T4>
        {
            public nnyn(T3 value) : base(value)
            {
            }
        }
        private class nynn<T1, T2, T3, T4> : nyn<T1, T2, T3>, IIsDefinatelyNot<T4>
        {
            public nynn(T2 value) : base(value)
            {
            }
        }
        private class ynnn<T1, T2, T3, T4> : ynn<T1, T2, T3>, IIsDefinatelyNot<T4>
        {
            public ynnn(T1 t1) : base(t1)
            {
            }
        }

        private class oynnn<T1, T2, T3,T4> : ynnn<T1, T2, T3,T4>, IOrType<T1, T2, T3,T4>
        {
            public oynnn(T1 value) : base(value)
            {
            }
        }
        private class onynn<T1, T2, T3,T4> : nynn<T1, T2, T3,T4>, IOrType<T1, T2, T3,T4>
        {
            public onynn(T2 value) : base(value)
            {
            }
        }

        private class onnyn<T1, T2, T3,T4> : nnyn<T1, T2, T3,T4>, IOrType<T1, T2, T3,T4>
        {
            public onnyn(T3 value) : base(value)
            {
            }
        }
        private class onnny<T1, T2, T3, T4> : nnny<T1, T2, T3, T4>, IOrType<T1, T2, T3, T4>
        {
            public onnny(T4 value) : base(value)
            {
            }
        }

        private class nnnny<T1, T2, T3, T4, T5> : nnnn<T1, T2, T3,T4>, IIsDefinately<T5> { public nnnny(T5 value) { Value = value; } public T5 Value { get; } }
        private class nnnnn<T1, T2, T3, T4, T5> : nnnn<T1, T2, T3,T4>, IIsDefinatelyNot<T5> { }
        private class nnnyn<T1, T2, T3, T4, T5> : nnny<T1, T2, T3, T4>, IIsDefinatelyNot<T5>
        {
            public nnnyn(T4 value) : base(value)
            {
            }
        }
        private class nnynn<T1, T2, T3, T4, T5> : nnyn<T1, T2, T3, T4>, IIsDefinatelyNot<T5>
        {
            public nnynn(T3 value) : base(value)
            {
            }
        }
        private class nynnn<T1, T2, T3, T4, T5> : nynn<T1, T2, T3, T4>, IIsDefinatelyNot<T5>
        {
            public nynnn(T2 value) : base(value)
            {
            }
        }
        private class ynnnn<T1, T2, T3, T4, T5> : ynnn<T1, T2, T3, T4>, IIsDefinatelyNot<T5>
        {
            public ynnnn(T1 t1) : base(t1)
            {
            }
        }

        private class oynnnn<T1, T2, T3, T4,T5> : ynnnn<T1, T2, T3, T4, T5>, IOrType<T1, T2, T3, T4, T5>
        {
            public oynnnn(T1 value) : base(value)
            {
            }
        }
        private class onynnn<T1, T2, T3, T4, T5> : nynnn<T1, T2, T3, T4, T5>, IOrType<T1, T2, T3, T4, T5>
        {
            public onynnn(T2 value) : base(value)
            {
            }
        }
        private class onnynn<T1, T2, T3, T4, T5> : nnynn<T1, T2, T3, T4, T5>, IOrType<T1, T2, T3, T4, T5>
        {
            public onnynn(T3 value) : base(value)
            {
            }
        }
        private class onnnyn<T1, T2, T3, T4, T5> : nnnyn<T1, T2, T3, T4, T5>, IOrType<T1, T2, T3, T4, T5>
        {
            public onnnyn(T4 value) : base(value)
            {
            }
        }
        private class onnnny<T1, T2, T3, T4, T5> : nnnny<T1, T2, T3, T4, T5>, IOrType<T1, T2, T3, T4, T5>
        {
            public onnnny(T5 value) : base(value)
            {
            }
        }

        public static IOrType<T1, T2> Make<T1, T2>(T1 value) => new oyn<T1,T2>(value);
        public static IOrType<T1, T2> Make<T1, T2>(T2 value) => new ony<T1, T2>(value);


        public static IOrType<T1, T2,T3> Make<T1, T2,T3>(T1 value) => new oynn<T1, T2,T3>(value);
        public static IOrType<T1, T2,T3> Make<T1, T2,T3>(T2 value) => new onyn<T1, T2,T3>(value);
        public static IOrType<T1, T2, T3> Make<T1, T2, T3>(T3 value) => new onny<T1, T2, T3>(value);


        public static IOrType<T1, T2, T3,T4> Make<T1, T2, T3, T4>(T1 value) => new oynnn<T1, T2, T3, T4>(value);
        public static IOrType<T1, T2, T3, T4> Make<T1, T2, T3, T4>(T2 value) => new onynn<T1, T2, T3, T4>(value);
        public static IOrType<T1, T2, T3, T4> Make<T1, T2, T3, T4>(T3 value) => new onnyn<T1, T2, T3, T4>(value);
        public static IOrType<T1, T2, T3, T4> Make<T1, T2, T3, T4>(T4 value) => new onnny<T1, T2, T3, T4>(value);

        public static IOrType<T1, T2, T3, T4,T5> Make<T1, T2, T3, T4, T5>(T1 value) => new oynnnn<T1, T2, T3, T4, T5>(value);
        public static IOrType<T1, T2, T3, T4, T5> Make<T1, T2, T3, T4, T5>(T2 value) => new onynnn<T1, T2, T3, T4, T5>(value);
        public static IOrType<T1, T2, T3, T4, T5> Make<T1, T2, T3, T4, T5>(T3 value) => new onnynn<T1, T2, T3, T4, T5>(value);
        public static IOrType<T1, T2, T3, T4, T5> Make<T1, T2, T3, T4, T5>(T4 value) => new onnnyn<T1, T2, T3, T4, T5>(value);
        public static IOrType<T1, T2, T3, T4, T5> Make<T1, T2, T3, T4, T5>(T5 value) => new onnnny<T1, T2, T3, T4, T5>(value);
    }
    
}
