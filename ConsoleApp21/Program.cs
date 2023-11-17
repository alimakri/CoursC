using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    enum CouleurEnum { Cyan=1, Magenta=2, Blanc=3 }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choisissez votre couleur : (1/2/3)");
            Console.WriteLine("1. Cyan");
            Console.WriteLine("2. Magenta");
            Console.WriteLine("3. Blanc");
            var saisie = Console.ReadLine();

            // Version
            //int i = 0;

            // Version 2
            CouleurEnum i = CouleurEnum.Cyan;
            try
            {
                // Version 1
                //i = int.Parse(saisie);

                // Version 2
                i = (CouleurEnum)Enum.Parse(typeof(CouleurEnum), saisie);

                // Version 1
                //if (i != 1 && i != 2 && i == 3) return               
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
            switch (i)
            {
                case CouleurEnum.Cyan: Console.ForegroundColor = ConsoleColor.Cyan; break;
                case CouleurEnum.Magenta: Console.ForegroundColor = ConsoleColor.Magenta; break;
                case CouleurEnum.Blanc: Console.ForegroundColor = ConsoleColor.White; break;
                default: Console.WriteLine("Erreur"); break;
            }
            Console.WriteLine("Bonjour");

            Console.ReadLine();
        }
    }
}
