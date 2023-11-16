using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Train t1 = new Train();
            t1.LesWagons = new List<Wagon>();

            int max = 6;
            // Version 1
            //Wagon wagon1 = new Wagon();
            //wagon1.Classe = 1;
            //Wagon wagon2 = new Wagon();
            //wagon2.Classe = 2;
            //Wagon wagon3 = new Wagon();
            //wagon3.Classe = 2;
            //Wagon wagon4 = new Wagon();
            //wagon4.Classe = 2;
            //Wagon wagon5 = new Wagon();
            //wagon5.Classe = 2;
            //t1.LesWagons.Add(wagon1);
            //t1.LesWagons.Add(wagon2);
            //t1.LesWagons.Add(wagon3);
            //t1.LesWagons.Add(wagon4);
            //t1.LesWagons.Add(wagon5);

            // Version 2
            Wagon wagon;
            for (int i = 0; i < 5; i++)
            {
                wagon = new Wagon();
                wagon.LesCompartiments = new List<Compartiment>();  
                t1.LesWagons.Add(wagon);
            }
            t1.LesWagons[0].Classe = 1;

            foreach (var w in t1.LesWagons)
            {
                for (int i = 0; i < 20; i++)
                {
                    var c = new Compartiment();
                    c.LesCouchettes = new List<Couchette>();
                    w.LesCompartiments.Add(c);
                }
            }
            int nCouchettes = 0;
            foreach (var w in t1.LesWagons)
            {
                foreach (var c in w.LesCompartiments)
                {
                    if (w.Classe == 1) max = 4; else max = 6;
                    for (int i = 0; i < max; i++)
                    {
                        c.LesCouchettes.Add(new Couchette());
                        nCouchettes++;
                    }
                }
            }
            Console.WriteLine("Il y a {0} couchettes !", nCouchettes);
            Console.ReadLine();
        }
    }
    class Train
    {
        public List<Wagon> LesWagons;
    }
    class Wagon
    {
        public int Classe = 2;
        public List<Compartiment> LesCompartiments;
    }
    class Compartiment
    {
        public List<Couchette> LesCouchettes;
    }
    class Couchette { }
}
