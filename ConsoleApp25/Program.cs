using System;

class Personne
{
    // Partie static
    public static int Count = 0;

    // Partie dynamic
    public string Nom = null;
    public int Age = 0;
    public Personne()
    {
        Count++;
    }
}

class MonApplication
{
    public static void Main()
    {
        var p1 = new Personne();

        Console.WriteLine(p1.Nom);
        Console.WriteLine(p1.Age);

        var p2 = new Personne { Nom = "Marie", Age = 25 };
        Console.WriteLine(Personne.Count);
        Console.ReadLine();
    }
}