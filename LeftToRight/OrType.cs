using System;
using System.Collections.Generic;

namespace Prototypist.Toolbox
{
    public class OrType<T1, T2> : IEquatable<OrType<T1, T2>>
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

        public bool Is1(out T1 item)
        {
            item = t1;
            return isT1;
        }

        public bool Is2(out T2 item)
        {
            item = t2;
            return isT2;
        }

        public T1 Is1OrThrow() {
            if (isT1) {
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

        public void Switch(Action<T1> a1, Action<T2> a2) {
            if (isT1) {
                a1(t1);
            }
            if (isT2) {
                a2(t2);
            }
        }

        public T SwitchReturns<T>(Func<T1,T> a1, Func<T2,T> a2)
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

        public bool Is<T>(out T res) {
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

    public class OrType<T1, T2, T3> : IEquatable<OrType<T1, T2, T3>>
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

        public bool Is1(out T1 item)
        {
            item = t1;
            return isT1;
        }

        public bool Is2(out T2 item)
        {
            item = t2;
            return isT2;
        }

        public bool Is3(out T3 item)
        {
            item = t3;
            return isT3;
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

    public class OrType<T1, T2, T3, T4> : IEquatable<OrType<T1, T2, T3, T4>>
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

        public bool Is1(out T1 item)
        {
            item = t1;
            return isT1;
        }

        public bool Is2(out T2 item)
        {
            item = t2;
            return isT2;
        }

        public bool Is3(out T3 item)
        {
            item = t3;
            return isT3;
        }
        
        public bool Is4(out T4 item)
        {
            item = t4;
            return isT4;
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
    
    public class OrType<T1, T2, T3, T4, T5> : IEquatable<OrType<T1, T2, T3, T4, T5>>
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

        public bool Is1(out T1 item)
        {
            item = t1;
            return isT1;
        }

        public bool Is2(out T2 item)
        {
            item = t2;
            return isT2;
        }

        public bool Is3(out T3 item)
        {
            item = t3;
            return isT3;
        }

        public bool Is4(out T4 item)
        {
            item = t4;
            return isT4;
        }

        public bool Is5(out T5 item)
        {
            item = t5;
            return isT5;
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


}
