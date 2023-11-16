using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_ConsoleApp17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();

            //for (int i = 0; i < 1000000; i++)
            //{
            //    Console.WriteLine(i);
            //    File.AppendAllText(@"d:\grosFichier1.txt", " ksjhfk sqhf klqshflkj qshflk jsqhfdlk hqslkdfh qslkj fhkljsqdhf jklsqdhfjkl hskljfhsqkdlfhklsqjhdf kqsh");
            //}
            //for (int i = 0; i < 3000000; i++)
            //{
            //    Console.WriteLine(i);
            //    File.AppendAllText(@"d:\grosFichier2.txt", " ksjhfk sqhf klqshflkj qshflk jsqhfdlk hqslkdfh qslkj fhkljsqdhf jklsqdhfjkl hskljfhsqkdlfhklsqjhdf kqsh");
            //}
            Lecture l1 = new Lecture();
            Lecture l2 = new Lecture();

            // Version 1
            //stopwatch.Start();
            //l1.Lire(@"d:\grosFichier1.txt");
            //l2.Lire(@"d:\grosFichier2.txt");
            //stopwatch.Stop();

            // Verion 2
            var d1 = new Action<string>(l1.Lire);
            var d2 = new Action<string>(l1.Lire);
            stopwatch.Start();
            d1.BeginInvoke(@"d:\grosFichier1.txt", null, null);
            d1(@"d:\grosFichier1.txt");
            stopwatch.Stop();

            Console.WriteLine("Elapsed Time is {0} ms", stopwatch.ElapsedMilliseconds);
            Console.ReadLine();
        }
    }
    class Lecture
    {
        public void Lire(string fichier)
        {
            string s = File.ReadAllText(fichier);
        }
    }
}
