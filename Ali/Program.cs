using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ali
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var partie = new Partie();
            partie.Humain = new Joueur();
            partie.Machine = new Joueur();
            int i = 0;

            while (partie.PasFinie())
            {
                partie.GetProposition(true);
                partie.GetProposition(false);
                i = partie.Comparer();
                partie.AffecterPoints(i);
                partie.AfficherScore();
            }

            Console.ForegroundColor = ConsoleColor.Cyan;
            if (partie.Humain.NbPoint == 3) Console.WriteLine("Bravo !"); else Console.WriteLine("Dommage !");
            Console.ReadLine();
        }
    }
    enum PropositionEnum { Pierre = 1, Feuille = 2, Ciseau = 3 }
    class Partie
    {
        public Joueur Humain;
        public Joueur Machine;
        private Random Random = new Random();

        public bool PasFinie()
        {
            return Humain.PasGagne() && Machine.PasGagne();
        }

        public void GetProposition(bool humain)
        {
            string saisie = null; int proposition = 0;
            if (humain)
            {
                proposition = 0;
                while (proposition == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write("Proposition (1=Pierre, 2=Feuille, 3=Ciseau)> ");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    saisie = Console.ReadLine();
                    int.TryParse(saisie, out proposition);
                }
                Humain.Proposition = (PropositionEnum) proposition;
            }
            else
            {
                Machine.Proposition = (PropositionEnum)Random.Next(1, 4);
            }
        }

        public int Comparer()
        {
            int resultat = 0;
            // Egalite
            if (Humain.Proposition == Machine.Proposition) resultat= 0;
            // Humain gagne
            else if (
                (Humain.Proposition == PropositionEnum.Pierre && Machine.Proposition == PropositionEnum.Ciseau) ||
                (Humain.Proposition == PropositionEnum.Feuille && Machine.Proposition == PropositionEnum.Pierre) ||
                (Humain.Proposition == PropositionEnum.Ciseau && Machine.Proposition == PropositionEnum.Feuille)
                )
            {
                resultat= 1;
            }
            // Machine Gagne
            else resultat =- 1;

            // Affichage
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("{0} - {1}", Humain.Proposition.ToString(), Machine.Proposition.ToString());

            return resultat;
        }

        public void AfficherScore()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("{0} - {1}", Humain.NbPoint, Machine.NbPoint);
        }

        public void AffecterPoints(int i)
        {
            switch(i)
            {
                case 1: Humain.NbPoint++; Machine.NbPoint = 0; break;
                case -1: Machine.NbPoint++; Humain.NbPoint = 0; break;
            }
        }
    }
    class Joueur
    {
        public PropositionEnum Proposition;
        public int NbPoint = 0;
        public bool PasGagne()
        {
            return NbPoint < 3;
        }
    }

}
