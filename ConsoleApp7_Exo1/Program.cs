using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7_Exo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] tableau1 = new int[3] { 3, 4, 7 };
            int[] tableau2 = new int[3] { 6, 5, 2 };
            int[] resultat = AdditionTableau(tableau1, tableau2);
        }
        static int[] AdditionTableau(int[] t1, int[] t2)
        {
            int[] tableauResultat = new int[3];
            for(int i = 0; i < t1.Length; i++)
            {
                tableauResultat[i]=  t1[i] + t2[i];
            }
            return tableauResultat;
        }
    }
}
