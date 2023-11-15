using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int nombreADeviner = random.Next(1, 100);

            Console.WriteLine("Devinez un nombre compris entre 1 et 99");
            bool gagne = false;
            bool perdu = false;
            int tentative = 0;
            while (!gagne && !perdu)
            {
                // Demander une proposition
                int proposition = Conversion("Donner un nombre " + tentative);
                tentative++;
                if (tentative > 7)
                {
                    Console.WriteLine("Perdu ! " + nombreADeviner);
                    perdu = true;
                }
                else if (proposition < nombreADeviner)
                {
                    Console.WriteLine("Trop petit");
                }
                else if (proposition > nombreADeviner)
                {
                    Console.WriteLine("Trop grand");
                }
                else
                {
                    Console.WriteLine("Gagné !");
                    gagne = true;
                }
            }
            Console.ReadLine();
        }
        static int Conversion(string message)
        {
            bool estConverti = false; int op = 0; string opStr;
            while (!estConverti)
            {
                Console.WriteLine(message);
                opStr = Console.ReadLine();
                estConverti = int.TryParse(opStr, out op);
            }
            return op;
        }
    }
}
