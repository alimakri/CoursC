using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var p1 = new Personne { Id = 1, Nom = "Einstein", DateNaissance = new DateTime(1920, 1, 1) };
            var p2 = new Personne { Id = 2, Nom = "Ramanujan", DateNaissance = new DateTime(1930, 1, 1) };
            var p3 = new Personne { Id = 2, Nom = "Marie Curie", DateNaissance = new DateTime(1940, 1, 1) };

            Personnes tableau = new Personnes();
            tableau.Add(p1);
            tableau.Add(p2);
            tableau.Add(p3);

            for (int i = 0; i < tableau.Count; i++)
            {
                var p = tableau[i];
                var age = (int)((DateTime.Now - p.DateNaissance).TotalDays / 365);
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
    class Personnes
    {
        private List<Personne> list = new List<Personne>();
        public void Add(Personne p)
        {
            list.Add(p);
        }
        public int Count
        {
            get
            {
                return list.Count;
            }
        }
        public Personne this[int i]
        {
            get
            {
                return list[i];
            }
        }
    }
}
