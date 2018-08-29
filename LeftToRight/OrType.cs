namespace Prototypist.LeftToRight
{
    public class OrType<T1, T2>
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

        public bool Is(out T1 item)
        {
            item = t1;
            return isT1;
        }

        public bool Is(out T2 item)
        {
            item = t2;
            return isT2;
        }
    }

    public class OrType<T1, T2, T3>
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

        public bool Is(out T1 item)
        {
            item = t1;
            return isT1;
        }

        public bool Is(out T2 item)
        {
            item = t2;
            return isT2;
        }

        public bool Is(out T3 item)
        {
            item = t3;
            return isT3;
        }
    }

    public class OrType<T1, T2, T3, T4>
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

        public bool Is(out T1 item)
        {
            item = t1;
            return isT1;
        }

        public bool Is(out T2 item)
        {
            item = t2;
            return isT2;
        }

        public bool Is(out T3 item)
        {
            item = t3;
            return isT3;
        }
        
        public bool Is(out T4 item)
        {
            item = t4;
            return isT4;
        }
    }
    
    public class OrType<T1, T2, T3, T4, T5>
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

        public bool Is(out T1 item)
        {
            item = t1;
            return isT1;
        }

        public bool Is(out T2 item)
        {
            item = t2;
            return isT2;
        }

        public bool Is(out T3 item)
        {
            item = t3;
            return isT3;
        }

        public bool Is(out T4 item)
        {
            item = t4;
            return isT4;
        }

        public bool Is(out T5 item)
        {
            item = t5;
            return isT5;
        }
    }
}
