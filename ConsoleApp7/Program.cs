using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cavLigne = 1;
            int cavColonne = 1;
            int[] deplaceLigne = new int[8]  { 1, -1, 1, -1, 2, -2, 2, -2 };
            int[] deplaceColonne = new int[8] { 2, 2, -2, -2, 1, 1, -1, -1 };
            Random rand = new Random();

            int index = 0;
            while (cavLigne != 8 || cavColonne != 8)
            {
                int alea = rand.Next(0, 8);
                int ligne = cavLigne + deplaceLigne[alea];
                int colonne = cavColonne + deplaceColonne[alea];
                if (ligne > 0 && colonne > 0 && ligne < 9 && colonne < 9)
                {
                    index++;
                    cavLigne = ligne;
                    cavColonne = colonne;
                    Console.WriteLine("{2}. {0}{1}", (char) (cavColonne+64), cavLigne, index);
                }
            }
            Console.ReadLine();
        }
    }
}
