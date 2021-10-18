using System;

namespace Project1
{
   
    public class B{
        
        
    }
    public class C : B
    {
        public C(object b)
        {
            this.b = b;
          
        }
        public object b;
    }
    public class A : C
    {
        public A(object b1, object b2, object b3, object c) : base(b1)
        {
            this.b2 = b2;
            this.b3 = b3;
            this.c = c;
            
        }
      
        public object b1;
        public object b2;
        public object b3;
        public object c;
    }
    class Program
    {
        static void Main(string[] args)
        {
            B b1 = new B();
            
            A a = new A(b1, new B(), new B(), new C(b1));
           // a        b1       b2      b3         c
           
        }
    }
}
