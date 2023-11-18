// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Choisissez entre pierre, feuille et ciseaux :");
        string choixUtilisateur = Console.ReadLine().ToLower();

        // Vérifier si le choix de l'utilisateur est valide
        if (EstChoixValide(choixUtilisateur))
        {
            string choixMachine = GenererChoixMachine();

            Console.WriteLine($"Votre choix : {choixUtilisateur}");
            Console.WriteLine($"Choix de la machine : {choixMachine}");

            // Déterminer le gagnant
            DeterminerGagnant(choixUtilisateur, choixMachine);
        }
        else
        {
            Console.WriteLine("Choix invalide. Veuillez choisir entre pierre, feuille et ciseaux.");
        }
    }

    static bool EstChoixValide(string choix)
    {
        return choix == "pierre" || choix == "feuille" || choix == "ciseaux";
    }

    static string GenererChoixMachine()
    {
        string[] optionsMachine = { "pierre", "feuille", "ciseaux" };
        Random rand = new Random();
        return optionsMachine[rand.Next(optionsMachine.Length)];
    }

    static void DeterminerGagnant(string choixUtilisateur, string choixMachine)
    {
        if (choixUtilisateur == choixMachine)
        {
            Console.WriteLine("C'est une égalite !");
        }
        else if (
            (choixUtilisateur == "pierre" && choixMachine == "ciseaux") ||
            (choixUtilisateur == "feuille" && choixMachine == "pierre") ||
            (choixUtilisateur == "ciseaux" && choixMachine == "feuille")
        )
        {
            Console.WriteLine("Vous avez gagne !");
        }
        else
        {
            Console.WriteLine("La machine a gagne !");
        }
    }
}
