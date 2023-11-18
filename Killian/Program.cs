using System;

namespace ConsoleApp3
{
    class Program
    {
        public static void Main()
        {
            int joueur = 0;
            int Bot = 0;
            string[] PPC = { "Pi", "Pa", "Ci" };


            while (joueur <= 2 || Bot <= 2)
            {

                Console.WriteLine("Pierre, Papier, Ciseaux !");
                string ReponseP1 = Console.ReadLine();
                int i = new Random().Next(0, 3);
                string ReponseP2 = PPC[i];

                // Bien trouvé !
                if (ReponseP1 == PPC[0] && ReponseP2 == PPC[1] || ReponseP1 == PPC[1] && ReponseP2 == PPC[2] || ReponseP1 == PPC[2] && ReponseP2 == PPC[0])
                {
                    Bot++;
                    Console.WriteLine("{0} point(s) pour moi !", Bot);
                    joueur = 0;
                }
                else if (ReponseP1 == PPC[0] && ReponseP2 == PPC[2] || ReponseP1 == PPC[1] && ReponseP2 == PPC[0] || ReponseP1 == PPC[2] && ReponseP2 == PPC[1])
                {
                    joueur++;
                    Console.WriteLine("{0} point(s) pour toi !", joueur);
                    Bot = 0;
                }
                else
                {
                    Console.WriteLine("Moi aussi !");
                }

            }

            if (joueur == 3)
            {
                Console.WriteLine("BRAVO TU AS GAGNER LA PARTI !");
                Console.ReadLine();
            }
            else
            {

                Console.WriteLine("YOU...LOSE... MUAHAHAHA!");
                Console.ReadLine();
            }

        }





    }

    /*  class Game              Pas fais
      {

          class Joueur
          {
              public static string PPC(string a)
              {

                  string Pi = "Pierre";
                  string Pa = "Papier";
                  string Ci = "Ciseaux";



                  return a;
              }

          }



      }

  */
}
