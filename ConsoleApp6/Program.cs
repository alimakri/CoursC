using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Factoriel(7));
            Console.Read();
        }
        static int Factoriel(int n)
        {
            if (n == 2) return 2;
            return n * Factoriel(n - 1);
        }
    }
}
