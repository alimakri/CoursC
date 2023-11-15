using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var p1 = new Personne { Id = 1, Nom = "Einstein", DateNaissance = new DateTime(1920, 1, 1) };
            var p2 = new Personne { Id = 2, Nom = "Ramanujan", DateNaissance = new DateTime(1930, 1, 1) };
            var p3 = new Personne { Id = 2, Nom = "Marie Curie", DateNaissance = new DateTime(1940, 1, 1) };

            List<Personne> tableau = new List<Personne>();
            tableau.Add(p1);
            tableau.Add(p2);
            tableau.Add(p3);



            foreach(Personne p in tableau)
            {
                var age = (int) ((DateTime.Now - p.DateNaissance).TotalDays / 365);
                Console.WriteLine("{0} {1} ans", p.Nom, age);
            }

            Console.ReadLine();
        }
    }
    class Personne
    {
        public int Id;
        public string Nom;
        public DateTime DateNaissance;
        public override string ToString()
        {
            return Nom;
        }
    }
}
