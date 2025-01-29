using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation1
{
    internal class Encapsulation
    {
        private string name;
        private int age;

        public string Name{ //With Properties we access private members
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public void Names(string name) //Without Properties
        {
            this.name = name;
            Console.WriteLine(name);
        }

    }
}
