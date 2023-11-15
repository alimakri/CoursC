using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        // Tri à bulle
        static void Main(string[] args)
        {
            int[] tableau = { 8, 7, 1, 5 };
            int curseur = 0; int tampon;
            while (curseur < tableau.Length-1)
            {
                if (tableau[curseur] > tableau[curseur + 1])
                {
                    tampon = tableau[curseur + 1];
                    tableau[curseur + 1] = tableau[curseur];
                    tableau[curseur] = tampon;
                    curseur = 0;
                }
                else
                {
                    curseur++;
                }
            }
            for (int i = 0; i < tableau.Length; i++)
            {
                Console.WriteLine(tableau[i]);
            }
            Console.ReadLine();
        }
    }
}
