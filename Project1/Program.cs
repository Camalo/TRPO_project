using System;

namespace Project1
{
   
    class Program
    {
        static void Main(string[] args)
        {
            //Создается объект класса B, на него ссылается экземпляр класса A и  экземпляр класса C
            B b1 = new B();
            
            A a = new A(b1, new B(), new B(), new C(b1));
           // a        b1       b2      b3         c
           
        }
    }
}
