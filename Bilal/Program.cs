using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammeCsharp
{
    class Program
    {
        static void Main()
        {
            int scoreJoueur = 0;
            int scoreOrdinateur = 0;
            const int victoiresPourGagner = 3;

            Console.WriteLine("Bienvenue dans le jeu Pierre-Papier-Ciseaux!");

            while (scoreJoueur < victoiresPourGagner && scoreOrdinateur < victoiresPourGagner)
            {
                Console.WriteLine("Score actuel - Joueur:  " + scoreJoueur + ", Ordinateur: " + scoreOrdinateur);

                Console.Write("Choisissez \n1.Pierre \n2.Papier \n3.Ciseaux \n");

                // Si on tape 1 choixJoueur va être 49 !!!
                // Console.ReadLine pas Console.Read
                //int choixJoueur = Console.Read();

                // Correction
                int choixJoueur = int.Parse(Console.ReadLine());


                Random random = new Random();
                int[] choixOrdinateur = { 1, 2, 3 };
                int indexOrdinateur = random.Next(choixOrdinateur.Length);
                int choixOrdi = choixOrdinateur[indexOrdinateur];

                Console.WriteLine("L'ordinateur choisit " + choixOrdi);

                if (choixJoueur == choixOrdi)
                {
                    Console.WriteLine("Égalité !");
                }
                else if ((choixJoueur == 1 && choixOrdi == 3) ||
                         (choixJoueur == 2 && choixOrdi == 1) ||
                         (choixJoueur == 3 && choixOrdi == 2))
                {
                    Console.WriteLine("Vous avez gagné cette manche ! \nVous avez " + scoreJoueur + " points !");
                    scoreJoueur++; // Mettre 1 ligne au dessus
                    scoreOrdinateur = 0;
                }
                else
                {
                    Console.WriteLine("L'ordinateur a gagné cette manche.\nL'ordinateur a " + scoreOrdinateur + " points !");
                    scoreOrdinateur++;
                    scoreJoueur = 0;
                }

                /*switch (choixOrdi)
                {
                    case 1: Parse.choixOrdi = "Pierre";
                    case 2: Parse.choixOrdi = "Papier";
                    case 3: Parse.choixOrdi = "Ciseaux";

                }
                */
                Console.WriteLine();
            }

            if (scoreJoueur == victoiresPourGagner)
            {
                Console.WriteLine("Félicitations, vous avez remporté la partie !");
            }
            else
            {
                Console.WriteLine("Désolé, l'ordinateur a remporté la partie. Essayez à nouveau !");
            }

            Console.ReadLine();
        }
    }
}
