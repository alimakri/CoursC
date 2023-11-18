using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace examen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int compteur = 0;
            string choix;

            string nombrestr;
            int nombre = 0;
            Joueur joueur = new Joueur();
            possibilite choix1 = new pierre();
            choix1.type = "pierre";
            possibilite choix2 = new feuille();
            choix2.type = "feuille";
            possibilite choix3 = new ciseau();
            choix3.type = "ciseau";

            possibilite toutesmespossibilite = new possibilite();
            toutesmespossibilite.lespossibilites.Add(choix1);
            toutesmespossibilite.lespossibilites.Add(choix2);
            toutesmespossibilite.lespossibilites.Add(choix3);
            do
            {
                Console.WriteLine("choisissez un nombre 1 pour pierre, 2 pour feuille, 3 ciseau:");
                nombrestr = Console.ReadLine();
                joueur.nombre_choisi = nombrestr;
                joueur.nombre_reel_jouer = nombre;

                if (!int.TryParse(nombrestr, out joueur.nombre_reel_jouer) && )
                {
                    Console.WriteLine("choisissez de nouveau un nombre");
                }
                else
                {
                    int.TryParse(joueur.nombre_choisi, out joueur.nombre_reel_jouer);
                    if ()
                    {
                        Console.WriteLine();

                        Console.WriteLine("Monsieur {0},votre score est de {1} essaie(s)", joueur.nom, reste);
                    }
                    else if (joueur.choix_joueur = 2 && toutesmespossibilite.lespossibilites.IndexOf(random))
                    {
                        Console.WriteLine("vous avez gagné le round");

                        Console.WriteLine("Monsieur {0},il vous reste plus que {1} essaie(s)", joueur.nom, reste);
                    }
                    else
                    {
                        Console.WriteLine("gagné!");
                        gagner = true;
                    }
                }
                if (compteur = 3)
                {
                    Console.WriteLine("perdu");
                    break;
                }
            } while (gagner == false && round != 3);


        }
        class Partie
        {
            Random random = new Random();
            private bool gagner = false;
            private Joueur joueur = new Joueur();



            public void demande_nom()
            {
                Console.WriteLine("Quel est votre prénom ?");
                joueur.nom = Console.ReadLine();
            }

            public void jouer()
            {
            }


        }

        class Joueur
        {
            public string nom;
            public int choix_joueur;
            public int score_du_joueur;
            public int nombre_reel_joueur;
        }
        class pierre : possibilite
        {

        }
        class feuille : possibilite
        {

        }
        class ciseau : possibilite
        {

        }
        class possibilite
        {
            public List<possibilite> lespossibilites = new List<possibilite>();
            public string type;
        }
    }
}
