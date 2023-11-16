using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Exo_ConsoleApp12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Votre nom : ");
            var nom = Console.ReadLine();
            var p = new Partie();
            p.Init(nom);

            var reponse = -5;
            while (reponse != 0 && reponse != -2)
            {
                p.Joueur.Proposition = p.Conversion("Votre proposition : ");
                p.Tentative++;
                reponse = p.Comparer();
                switch (reponse)
                {
                    case 0: Console.WriteLine("Gagné"); break;
                    case 1: Console.WriteLine("Trop grand"); break;
                    case -1: Console.WriteLine("Trop petit"); break;
                    case -2: Console.WriteLine("Perdu"); break;
                }
            }
            Console.ReadLine();
        }
    }
    class Partie
    {
        public Joueur Joueur= new Joueur();
        private Random random= new Random();
        public int NombreADeviner;
        public int Tentative;
        public void Init(string nom)
        {
            Joueur.Nom = nom;
            NombreADeviner= random.Next(1,100);
            Tentative = 0;
        }
        public int Comparer()
        {
            if (Tentative > 6) return -2;
            if (Joueur.Proposition < NombreADeviner) return -1;
            if (Joueur.Proposition >NombreADeviner) return 1;
            return 0;
        }
        public int Conversion(string message)
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
    class Joueur
    {
        public int Proposition;
        public string Nom;
    }
}
