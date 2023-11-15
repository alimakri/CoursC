using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Version 1
            //List<Vol> vols = new List<Vol>();
            //vols.Add(new Vol { Origine = "Lyon", Destination = "Sétif", Horaire = new DateTime(2023, 11, 22, 6, 0, 0) });
            //vols.Add(new Vol { Origine = "Lyon", Destination = "Singapour", Horaire = new DateTime(2023, 12, 5, 6, 0, 0) });
            //vols.Add(new Vol { Origine = "Lyon", Destination = "Tanger", Horaire = new DateTime(2023, 12, 8, 6, 0, 0) });

            // Version 2
            List<Vol> vols = new List<Vol>
            {
                new Vol { Origine = "Lyon", Destination = "Sétif", Horaire = new DateTime(2023, 11, 22, 6, 0, 0) },
                new Vol { Origine = "Lyon", Destination = "Singapour", Horaire = new DateTime(2023, 12, 5, 6, 0, 0) },
                new Vol { Origine = "Lyon", Destination = "Tanger", Horaire = new DateTime(2023, 12, 8, 6, 0, 0) }
            };

            // Demande de destination
            Console.Write("Destination : ");
            var destination = Console.ReadLine();

            // Résultat - Version 1
            //foreach (var vol in vols)
            //{
            //    if (vol.Destination.ToUpper() == destination.ToUpper())
            //    {
            //        Console.WriteLine("Un vol est prévu le {0} pour aller à {1}", vol.Horaire, vol.Destination);
            //    }
            //}

            // Résultat - Version Linq
            var volTrouve = vols.First(vol => vol.Destination.ToUpper() == destination.ToUpper());
            Console.WriteLine("Un vol est prévu le {0} pour aller à {1}", volTrouve.Horaire, volTrouve.Destination);

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
