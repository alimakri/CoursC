using System;
using System.Collections.Generic;
using System.IO.Ports;
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
            while (partie.PasFinie())
            {
                partie.GetProposition(JoueurEnum.Humain);
                partie.GetProposition(JoueurEnum.Machine);
                partie.Comparer();
                partie.AfficherScore(ScoreEnum.Intermediaire);
            }
            partie.AfficherScore(ScoreEnum.Final);

            Console.ReadLine();
        }
    }
    enum PropositionEnum { Pierre = 1, Feuille = 2, Ciseau = 3 }
    enum JoueurEnum { Humain, Machine }
    enum ScoreEnum { Intermediaire, Final }
    class Partie
    {
        public Joueur Humain;
        public Joueur Machine;
        private Random Random = new Random();
        public Partie()
        {
            Humain = new Joueur();
            Machine = new Joueur();

        }
        public bool PasFinie()
        {
            return Humain.PasGagne() && Machine.PasGagne();
        }

        public void GetProposition(JoueurEnum joueur)
        {
            string saisie = null; int proposition = 0;
            if (joueur == JoueurEnum.Humain)
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
                Humain.Proposition = (PropositionEnum)proposition;
            }
            else
            {
                Machine.Proposition = (PropositionEnum)Random.Next(1, 4);
            }
        }

        public void Comparer()
        {
            int resultat = 0;
            // Egalite
            if (Humain.Proposition == Machine.Proposition) resultat = 0;
            // Humain gagne
            else if (
                (Humain.Proposition == PropositionEnum.Pierre && Machine.Proposition == PropositionEnum.Ciseau) ||
                (Humain.Proposition == PropositionEnum.Feuille && Machine.Proposition == PropositionEnum.Pierre) ||
                (Humain.Proposition == PropositionEnum.Ciseau && Machine.Proposition == PropositionEnum.Feuille)
                )
            {
                resultat = 1;
            }
            // Machine Gagne
            else resultat = -1;

            // Affichage
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("{0} - {1}", Humain.Proposition.ToString(), Machine.Proposition.ToString());

            AffecterPoints(resultat);
        }
        public void AffecterPoints(int i)
        {
            switch (i)
            {
                case 1: Humain.NbPoint++; Machine.NbPoint = 0; break;
                case -1: Machine.NbPoint++; Humain.NbPoint = 0; break;
            }
        }

        public void AfficherScore(ScoreEnum scoreType)
        {
            switch (scoreType)
            {
                case ScoreEnum.Intermediaire:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("{0} - {1}", Humain.NbPoint, Machine.NbPoint);
                    break;
                case ScoreEnum.Final:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    if (Humain.NbPoint == 3) Console.WriteLine("Bravo !"); else Console.WriteLine("Dommage !");
                    break;
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
