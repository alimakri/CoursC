using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            A a1 = new A();

            // Lecture
            var x = a1.i;

            // Ecriture
            a1.i = 108;

        }
    }
    class A
    {
        //private int i = 7;
        //public int Get()
        //{
        //    return i;
        //}
        //public void Set(int value)
        //{
        //    if (value < 100) i = value;
        //}

        private int _i = 7;
        public int i
        {
            get { return _i; }
            set { if (value < 100) _i = value; }
        }

    }
}
