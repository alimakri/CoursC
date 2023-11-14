using System;

namespace Espace1
{
    class Classe1
    {

    }
    class Classe2
    {
        static void Main()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Quel est votre nom ?");
            string s = Console.ReadLine();
            Console.WriteLine("Bonjour {0} {0}", s);
            Console.ReadLine();
        }
    }
    class Classe3
    {

    }
}