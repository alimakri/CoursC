using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            A a1 = new A();
            a1.M(78);

            B b1 = new B(M);
            b1.Invoke(79);

            Console.ReadLine();
        }
        static int M(int i)
        {
            Console.WriteLine("coucou {0}", i);
            return 0;
        }
    }
    class A
    {
        public void M(int i) { Console.WriteLine("coucou {0}", i); }
    }
    delegate int B(int i);
}
