﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Version2();
            Console.ReadLine();
        }
        static void Version1()
        {
            Console.WriteLine("Donnez un nombre");
            string op1Str = Console.ReadLine();
            int op1;
            if (int.TryParse(op1Str, out op1))
            {
                Console.WriteLine("Donnez un autre nombre");
                string op2Str = Console.ReadLine(); int op2;
                if (int.TryParse(op2Str, out op2))
                {
                    op2 = int.Parse(op2Str);
                    Console.WriteLine(op1 + op2);
                }
            }
        }
        static void Version2()
        {
            int op1 = Conversion("Donnez un premier nombre");
            int op2 = Conversion("Donnez un deuxième nombre");
            Console.WriteLine(op1 + op2);
        }
        static int Conversion(string message)
        {
            bool estConverti = false; int op = 0; string opStr;
            while (!estConverti)
            {
                Console.WriteLine(message);
                opStr = Console.ReadLine();
                estConverti = int.TryParse(opStr, out op);
            }
            return op;
        }
    }
}
