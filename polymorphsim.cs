using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation1
{
    public class Parent
    {
        public virtual void polymorphism(int a, int b) {
            Console.WriteLine(a+b);
        }

        public int polymorphism(int a, int b,int c)
        {
            return a + b+c;
        }
    }

    public class Child : Parent { 
        public override void polymorphism(int b,int c)
        {
            Console.WriteLine(b+c);
        }
    }
}
