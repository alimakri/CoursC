using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tableau de caractères
            string s = Console.ReadLine();
            Console.WriteLine("le premier caractère est {0}", s[0]);
            Console.WriteLine("le dernier caractère est {0}", s[s.Length - 1]);

            // Tableau d'entier
            int[] tableauEntier = new int[5] { 15, 58, 6, 69, 38 };
            Console.WriteLine("le premier entier est {0}", tableauEntier[0]);
            Console.WriteLine("le dernier entier est {0}", tableauEntier[tableauEntier.Length - 1]);

            // Tableau de string
            string[] tableauString = new string[3] { "15", "ABC", "Ok" };
            Console.WriteLine("le premier string est {0}", tableauString[0]);
            Console.WriteLine("le dernier string est {0}", tableauString[tableauString.Length - 1]);

            // Tableau de tableau d'entier
            int[,] tableauTableauEntier = new int[2, 2];
            tableauTableauEntier[0, 0] = 1;
            tableauTableauEntier[0, 1] = 2;
            tableauTableauEntier[1, 0] = 3;
            tableauTableauEntier[1, 1] = 4;
            Console.WriteLine("le 3e est {0}", tableauTableauEntier[1, 0]);
            Console.ReadLine();
        }
    }
}
