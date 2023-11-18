using System;

public class Program
{
    public static string jeuOrdi(int rand)
    {
        string botResp = "";
        if (rand == 1)
        {
            botResp = "p";
        }
        else if (rand == 2)
        {
            botResp = "f";
        }
        else if (rand == 3)
        {
            botResp = "c";
        }
        return botResp;
    }
    public static string strReturn(string str)
    {
        if (str == "p")
        {
            str = "¨Pierre";
        }
        else if (str == "f")
        {
            str = "Feuille";
        }
        else if (str == "c")
        {
            str = "Ciseau";
        }
        return str;
    }

    public static void Main()
    {
        int pointsUser = 0;
        int pointBot = 0;
        bool jeu = true;
        string userRespStr = "";
        string botRespStr = "";

        while (jeu)
        {
            // jeu bot
            Random rand = new Random();
            int randNum = rand.Next(1, 4);
            string botResp = jeuOrdi(randNum);
            // jeu utilisateur
            Console.WriteLine("Pierre (p), feuille(f) ou ciseaux(c) ?.");
            string userResp = Console.ReadLine();
            userResp = userResp.ToLower();
            while (userResp != "p" && userResp != "f" && userResp != "c")
            {
                Console.WriteLine("Pierre (p), feuille(f) ou ciseaux(c) ?.");
                userResp = Console.ReadLine();
                userResp = userResp.ToLower();
            }
            userRespStr = strReturn(userResp);
            botRespStr = strReturn(botResp);

            if (userResp == botResp)
            {
                Console.WriteLine("{0} VS {1}", userRespStr, botRespStr);
                Console.WriteLine("Égalité !");
                Console.WriteLine("Vous {0} - {1} Ordi", pointsUser, pointBot);
            }
            else if ((userResp == "p" && botResp == "f") || (userResp == "f" && botResp == "c") || (userResp == "c" && botResp == "p"))
            {
                pointsUser++;
                pointBot = 0;
                Console.WriteLine("{0} VS {1}", userRespStr, botRespStr);
                Console.WriteLine("Vous {0} - {1} Ordi", pointsUser, pointBot);
            }
            else
            {
                pointBot++;
                pointsUser = 0;
                Console.WriteLine("{0} VS {1}", userRespStr, botRespStr);
                Console.WriteLine("Vous {0} - {1} Ordi", pointsUser, pointBot);
            }
            if (pointsUser == 3)
            {
                Console.WriteLine("Vous avez gagné !");
                jeu = false;
            }
            else if (pointBot == 3)
            {
                Console.WriteLine("Vous avez perdu !");
                jeu = false;
            }
            // Génant !
            //Console.Clear();

            // A ajouter
            Console.ReadLine();
        }

    }
}
