using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Encapsulation Obj = new Encapsulation();
            Obj.Name = "Ali";
            Obj.Age = 100;
            Console.WriteLine(Obj.Name);
            Console.WriteLine(Obj.Age);
        }
    }
}
