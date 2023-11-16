using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var c1 = new Compteur { Nom = "c1", Depart = 1, Arrivee = 10, Pause = 500, Couleur = ConsoleColor.Cyan };
            var d1 = new Func<string, int>(c1.Compter);

            var c2 = new Compteur { Nom = "c2", Depart = 1, Arrivee = 30, Pause = 300, Couleur = ConsoleColor.White };
            var d2 = new Func<string, int>(c2.Compter);

            d1.BeginInvoke("message 1", new AsyncCallback(FinCompter), "Compteur 1");
            d2.BeginInvoke("message 2", new AsyncCallback(FinCompter), "Compteur 2");
            Console.WriteLine("Fin du programme");

            Console.ReadLine();
        }
        static void FinCompter(IAsyncResult ar)
        {
            var nom = ar.AsyncState.ToString();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("{0} a fini", nom);
        }
    }
    class Compteur
    {
        public string  Nom;
        public int Depart;
        public int Arrivee;
        public int Pause;
        public ConsoleColor Couleur;
        public int Compter(string message)
        {
            for (int i = Depart; i < Arrivee+1; i++)
            {
                Console.ForegroundColor = Couleur;
                Console.WriteLine("{0} - {1} ({2})", Nom, i, message);
                Thread.Sleep(Pause);
            }
            return 0;
        }
    }
}
