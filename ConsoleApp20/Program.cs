using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder s = new StringBuilder("les sanglots longs des violons de l'automne");
            var nbLettres = s.Length;
            var nMots = s.NbreMots();
        }

    }
    public static class Outils
    {
        public static int NbreMots(this string s)
        {
            return s.Split(' ').Length;
        }
        public static int NbreMots(this StringBuilder s)
        {
            return NbreMots(s.ToString());
        }

    }
}
