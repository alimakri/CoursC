using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IContrat1 asie = new Continent();
            int nbPays = asie.NombreElements();
        }
    }
    class Continent : IContrat1
    {
        public int NombreElements() { return 5; }
    }
    class Pays : IContrat1
    {
        public int NombreElements() { return 100; }
    }
    interface IContrat1
    {
        int NombreElements();
    }
    class Ville : IContrat1
    {
        public int NombreElements() { return 1000; }
    }
}
