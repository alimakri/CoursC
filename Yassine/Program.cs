using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Shifumi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Shifumi !");

            Joueur joueur1 = new Joueur("Joueur 1");
            Joueur joueur2 = new Joueur("Joueur 2 (PC)");

            string choixJoueur1 = joueur1.FaireChoix();

            Random random = new Random();
            int choixRandom = random.Next(0, 3);
            string choixJoueur2 = choixRandom == 0 ? "pierre" : (choixRandom = 1 ? "feuille" : "ciseaux");

            Console.WriteLine($"Joueur 1 choisit {choixJoueur1}");
            Console.WriteLine($"Joueur 2 (PC) choisit {choixJoueur2}");

            // Correction
            //Winner(choixJoueur1, choixJoueur2);
            Shifumi.Winner(choixJoueur1, choixJoueur2);
        }

        public class Joueur
        {
            public string Nom;
            public Joueur(string nom)
            {
                Nom = nom;
            }
            public string FaireChoix()
            {
                Console.WriteLine($"{Nom}, veuillez choisir (pierre, feuille, ciseaux): ");
                string choix = Console.ReadLine().ToLower();

                // Vérification de la validité du choix
                if (choix == "pierre" || choix == "feuille" || choix == "ciseaux")
                {
                    return choix;
                }
                else
                {
                    Console.WriteLine("Choix non valide. Réessayez.");
                    return FaireChoix();
                }
            }
        }

        public class Shifumi
        {
            public static void Winner(string choixJoueur1, string choixJoueur2)
            {
                if (choixJoueur1 == choixJoueur2)
                {
                    Console.WriteLine("Égalité !");
                }
                else if ((choixJoueur1 == "pierre" && choixJoueur2 == "ciseaux") ||
                         (choixJoueur1 == "feuille" && choixJoueur2 == "pierre") ||
                         (choixJoueur1 == "ciseaux" && choixJoueur2 == "feuille"))
                {
                    Console.WriteLine("Joueur 1 gagne !");
                }
                else
                {
                    Console.WriteLine("Joueur 2 (PC) gagne !");
                }
            }
        }
    }
}
