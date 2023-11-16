using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class A
    {
        private int p1;
        public int p2;
        internal int p3;
        protected int p4;
        internal protected int p5;
        public void M()
        {
            var x = p1;
        }
    }
    public class B : A
    {
        public void M()
        {
            A a1 = new A();
            int x = a1.p2;
            // x = a1.p1;
            x = a1.p3;
            x = p4;
            x = p2;
            x = p5;
        }
    }
    public class C
    {
        public void M()
        {
            A a1 = new A();
            int x = a1.p2;
            //x = a1.p1;
            x = a1.p3;
            x = a1.p5;
        }
    }
}
