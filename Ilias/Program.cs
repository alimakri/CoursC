using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_
{
    internal class Program
    {
        static void Main()
        {
            int userPoint = 0;
            int machinePoint = 0;

            while (userPoint < 3 && machinePoint < 3)
            {
                Console.WriteLine($"Le Score est le suivant: Vous {userPoint} - Machine {machinePoint}");
                string userChoice = GetUserChoice();
                string machineChoice = GetMachineChoice();
                Console.WriteLine($"Le choix de la machine est le suivant: {machineChoice}");
                string result = DetermineWinner(userChoice, machineChoice);

                if (result == "Gagné")
                {
                    Console.WriteLine("Vous venez de remporter cette manche ! Bravo à vous !");
                    userPoint++;
                }
                else if (result == "Perdu")
                {
                    Console.WriteLine("La machine vient de remporter cette manche ! Ne vous découragez pas !");
                    machinePoint++;
                }
                else
                {
                    Console.WriteLine("Vous et la machine avez choisi la même chose lors de ce tour !");
                }

                Console.WriteLine();
            }

            if (userPoint == 3)
            {
                Console.WriteLine("Bravo à vous, vous êtes le premier à être arrivé à trois, vous remporter donc le jeu");
            }
            else
            {
                Console.WriteLine("Dommage, la machine est la première à être arrivé en première, elle remporte donc le jeu !");
            }
        }

        static string GetUserChoice()
        {
            Console.Write("Tapper P en majuscule pour Pierre, F majuscule pour Feuille et C majuscule pour Ciseaux: ");
            string choice = Console.ReadLine();

            while (choice != "P" && choice != "F" && choice != "C")
            {
                Console.Write("Choix invalide. Ressayer s'il vous plaît.");
                choice = Console.ReadLine();
            }
            return choice;
        }

        static string GetMachineChoice()
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 4);

            switch (randomNumber)
            {
                case 1:
                    return "P";
                case 2:
                    return "F";
                case 3:
                    return "C";
                default:
                    return "";
            }
        }

        static string DetermineWinner(string userChoice, string machineChoice)
        {
            userChoice = userChoice.ToUpper(); // Je converti en majuscule pour éviter les soucis d'entrée de la valeur 
            machineChoice = machineChoice.ToUpper(); // Je converti en majuscule pour éviter les soucis d'entrée de la valeur 

            if ((userChoice == "P" && machineChoice == "C") ||
                (userChoice == "F" && machineChoice == "P") ||
                (userChoice == "C" && machineChoice == "F"))
            {
                return "Gagné";
            }
            else if ((machineChoice == "P" && userChoice == "C") ||
                     (machineChoice == "F" && userChoice == "P") ||
                     (machineChoice == "C" && userChoice == "F"))
            {
                return "Perdu";
            }
            else
            {
                return "Égalité";
            }
        }
    }
}
