using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        class A
        {
            protected int field;
            public A()
            { Random rnd = new Random();

                field = rnd.Next(0, 100);
            }
            public string M()
            {
                return field.ToString();
            }
        }
        class B : A
        {
            public int Field { get { return field; } set { field = value; } }
        }
        static void Main(string[] args)
        {
            A b = new A();
            Console.WriteLine(b.M());
            B c = new B();
            b = c as A;
            c = b as B;
            Console.WriteLine(c.Field);
        }
    }
}
