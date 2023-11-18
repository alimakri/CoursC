using System;
class Program
{
    static void Main()
    {
        Random rand = new Random();
        int points = 0;

        while (true)
        {
            Console.Write("pierre, feuille ou ciseaux ? ");
            string choixJoueur = Console.ReadLine().ToLower();

            if (!Array.Exists(new[] { "pierre", "feuille", "ciseaux" }, e => e == choixJoueur))
            {
                Console.WriteLine("Veuillez choisir pierre, feuille ou ciseaux.");
                continue;
            }

            string choixOrdinateur = new[] { "pierre", "feuille", "ciseaux" }[rand.Next(3)];
            Console.WriteLine($"Ordinateur : {choixOrdinateur}");

            if (choixJoueur == choixOrdinateur)
            {
                Console.WriteLine("egalite !");
            }
            else if ((choixJoueur == "pierre" && choixOrdinateur == "ciseaux") ||
                     (choixJoueur == "feuille" && choixOrdinateur == "pierre") ||
                     (choixJoueur == "ciseaux" && choixOrdinateur == "feuille"))
            {
                Console.WriteLine("Victoire !");
                points++;
            }
            else
            {
                Console.WriteLine("Perdu. Points remis a zero.");
                points = 0;
            }

            Console.WriteLine($"Points : {points}");

            // Une double boucle while était nécessaire
            //Console.Write("Voulez-vous rejouer ? (o/n): ");
            //if (Console.ReadLine().ToLower() != "o")
            //    break;
        }
    }
}
