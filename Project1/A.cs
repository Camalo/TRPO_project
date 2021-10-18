using System;
using System.Collections.Generic;
using System.Text;

namespace Project1
{
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
}
