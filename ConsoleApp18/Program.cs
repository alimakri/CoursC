using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var centrale = new Centrale();
            centrale.Refroidir(3000);

            Console.ReadLine();
        }
    }
    class Centrale
    {
        public ArrayList ListePompes = new ArrayList();
        public List<Action<int>> LesRefroidir = new List<Action<int>> ();
        public Centrale()
        {
            var p1 = new PompeHydraulique();
            var p2 = new PompeHydraulique();
            var p3 = new PompeElectrique();
            var p4 = new PompeManuelle();
            ListePompes.Add(p1);
            ListePompes.Add(p2);
            ListePompes.Add(p3);
            ListePompes.Add(p4);

            LesRefroidir.Add(p1.Refroidir);
            LesRefroidir.Add(p2.Refroidir);
            LesRefroidir.Add(p3.Refroidir);
            LesRefroidir.Add(p4.Refroidir);
        }
        public void Refroidir(int temperature)
        {
            //foreach (object pompe in ListePompes)
            //{
            //    if (pompe is PompeHydraulique) ((PompeHydraulique)pompe).Refroidir();
            //    if (pompe is PompeElectrique) ((PompeElectrique)pompe).Refroidir();
            //}
            foreach(var d in LesRefroidir)
            {
                d.Invoke(temperature);
            }
        }
    }
    class PompeHydraulique
    {
        public void Refroidir(int temperature)
        {
            Console.WriteLine("Pompe hydraulique lancée !");
        }
    }
    class PompeElectrique
    {
        public void Refroidir(int temperature)
        {
            Console.WriteLine("Pompe electrique lancée !");
        }
    }
    class PompeManuelle
    {
        public void Refroidir(int temperature)
        {
            Console.WriteLine("Pompe manuelle lancée !");
        }
    }
}
