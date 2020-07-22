<<<<<<< HEAD
﻿using System;

namespace Abstract_Class
{
    public abstract class PureBase
    {
        public abstract int GetFirst();
        public abstract int GetNext();
    }

    public class DerivedA : PureBase
    {
        private int no = 1;

        // abstract override
        public override int GetFirst()
        {
            return no;
        }
        
        public override int GetNext()
        {
            return ++no;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            DerivedA derivedA = new DerivedA();
            int no = derivedA.GetFirst();
            
            Console.WriteLine(no);
        }
    }
}
=======
﻿using System;

namespace Abstract_Class
{
    public abstract class PureBase
    {
        public abstract int GetFirst();
        public abstract int GetNext();
    }

    public class DerivedA : PureBase
    {
        private int no = 1;

        // abstract override
        public override int GetFirst()
        {
            return no;
        }
        
        public override int GetNext()
        {
            return ++no;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            DerivedA derivedA = new DerivedA();
            int no = derivedA.GetFirst();
            
            Console.WriteLine(no);
        }
    }
}
>>>>>>> d2e7b951dce912923d6d05b0809030f1f81655b7
