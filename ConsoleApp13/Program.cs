using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 13;
            int adresse = &i;
            int j = *adresse;

            int j = i;
            Boite b2;
            {
                var x = 10;
                var b1 = new Boite();
                b1 = null;
                b2 = b1;
            }
            i = 12;
        }
    }
    class Boite
    {
        int a = 1;
        int b = 2;
    }
}
