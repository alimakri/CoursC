using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9_Exo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicule v;
            var auto = new Auto();
            var moto = new Moto();
            if (Console.ReadLine() == "A") v = auto; else v = moto;
            v.Rouler();

            Console.ReadLine();
        }
    }
    class Vehicule { public virtual void Rouler() { } }
    class Auto : Vehicule
    {
        public override void Rouler() { Console.WriteLine("L'auto roule !"); }
    }
    class Moto : Vehicule
    {
        public override void Rouler() { Console.WriteLine("La moto roule !"); }
    }
}
