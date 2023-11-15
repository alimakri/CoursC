using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var veste = new Vetement { Nom = "Blazer", Taille = 50 };
            veste.Essayer();

            var pantalon = new Vetement { Nom = "Jean", Taille = 42 };
            pantalon.Essayer("ceinture noire");

            Console.ReadLine();
        }
    }
    class Vetement
    {
        public string Nom;
        public int Taille;
        public void Essayer()
        {
            Console.WriteLine("J'essaie un(e) {0} de taille {1}",
                Nom, Taille);
        }
        public void Essayer(string accessoire)
        {
            Console.WriteLine("J'essaie un(e) {0} de taille {1} avec une {2}",
        Nom, Taille, accessoire);
        }
    }
}
