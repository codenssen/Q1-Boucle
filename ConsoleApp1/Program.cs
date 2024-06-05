using System;

class MainClass
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Entrer une première limite : ");
        int limit1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Entrer une seconde limite : ");
        int limit2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Entrer un entier : ");
        int entier = Convert.ToInt32(Console.ReadLine());

        int maximum = 0, minimum = 0;


        if (limit1 > limit2 )
        {
            maximum = limit1;
            minimum = limit2;
        }
        else
        {
            maximum = limit2;
            minimum = limit1;
        }

        if (entier < minimum)
        {
            Console.WriteLine($"Votre entier {entier} est inférieur au minimum {minimum}");
        }
        else if (entier > maximum)
        {
            Console.WriteLine($"Votre entier {entier} est supérieur au maximum {maximum}");
        } else
        {
            Console.WriteLine($"Votre entier est inclus dans les deux limites");
        }

    }
}