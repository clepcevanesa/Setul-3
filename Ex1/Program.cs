//Calculati suma elementelor unui vector de n numere citite de la tastatura. Rezultatul se va afisa pe ecran.

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Introduceti lungimea vectorului:");
        int lungime;
        while (!int.TryParse(Console.ReadLine(), out lungime) || lungime <= 0)
        {
            Console.WriteLine("Introduceti o lungime valida (un numar intreg pozitiv):");
        }

        int[] vector = new int[lungime];

        for (int i = 0; i < lungime; i++)
        {
            Console.WriteLine($"Introduceti elementul {i + 1} din {lungime}:");
            while (!int.TryParse(Console.ReadLine(), out vector[i]))
            {
                Console.WriteLine($"Introduceti un numar valid pentru elementul {i + 1} din {lungime}:");
            }
        }

        int suma = 0;
        for (int i = 0; i < lungime; i++)
        {
            suma += vector[i];
        }

        Console.WriteLine($"Suma elementelor vectorului este: {suma}");
    }
}
