using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Type référence
            // Déclaration d'un objet c1
            // Construction 
            // Référence
            // Initialisation
            Chargeur c1 = new Chargeur(3);
            Chargeur c2 = new Chargeur();

            // Type valeur
            // Déclaration d'un objet i
            // Construction 
            // Initialisation
            int i = 7;
        }
    }
    class Chargeur
    {
        public int Puissance;
        public Chargeur()
        {
        }
        public Chargeur(int val)
        {
            Puissance = val;
        }
    }
}
