using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11Bis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Version 1
            Dictionary<string, Vol> vols = new Dictionary<string, Vol>();
            vols.Add("Sétif", new Vol { Origine = "Lyon", Destination = "Sétif", Horaire = new DateTime(2023, 11, 22, 6, 0, 0) });
            vols.Add("Singapour", new Vol { Origine = "Lyon", Destination = "Singapour", Horaire = new DateTime(2023, 12, 5, 6, 0, 0) });
            vols.Add("Tanger", new Vol { Origine = "Lyon", Destination = "Tanger", Horaire = new DateTime(2023, 12, 8, 6, 0, 0) });

            // Demande de destination
            Console.Write("Destination : ");
            var destination = Console.ReadLine();

            // Résultat - Version 1
            var vol = vols[destination];
            Console.WriteLine("Un vol est prévu le {0} pour aller à {1}", vol.Horaire, vol.Destination);

            Console.ReadLine();
        }
    }
    class Vol
    {
        public string Origine;
        public string Destination;
        public string Numero;
        public DateTime Horaire;
    }
}
