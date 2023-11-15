using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var elephant1 = new Elephant { Nom = "Babar" };
            Elephant.Nombre++;

            Elephant elephant2 = new Elephant();
            elephant1.Nom = "Dumbo";
            Elephant.Nombre++;

            Cheval cheval1 = new Cheval();
            cheval1.Nom = "Jolly Jumper";
            Console.WriteLine("le cheval s'appelle {0} et l'éléphant s'appelle {1}",
                cheval1.Nom, elephant1.Nom);
            Console.WriteLine("Il y a {0} éléphant(s)", Elephant.Nombre);
            cheval1.Courir();

            Animal x = null;
            Animal cheval2 = new Cheval { Nom = "Petit tonnerrre" };
            Animal elephant3 = new Elephant { Nom = "Heraclus" };
            var saisie = Console.ReadLine();
            if (saisie.ToUpper() == "C")
                x = cheval2;
            else
                x = elephant3;
            x.Courir();

            Console.Read();
        }
    }
    class Cheval : Animal
    {
        public override void Courir()
        {
            Console.WriteLine("ça galope !");
        }
    }
    class Elephant : Animal
    {
        public static int Nombre = 0;
        public override void Courir()
        {
            Console.WriteLine("ça piétine !");
        }
    }
    class Animal
    {
        public string Nom;
        public virtual void Courir()
        {
        }
    }
}
