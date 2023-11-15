using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var jeu1 = new JeuVideo { Nom = "FIFA 2023" };
            var jeu2 = new JeuVideo { Nom = "GTA" };
            var jeu3 = new JeuVideo { Nom = "MineCraft" };

            // V1
            //Console.WriteLine(jeu1.Nom);
            // V2
            Console.WriteLine(jeu1);

            Console.ReadLine();
        }
    }
    class JeuVideo
    {
        public string Nom;
        public override string ToString()
        {
            return "Le jeu est " + Nom;
        }
    }
}
