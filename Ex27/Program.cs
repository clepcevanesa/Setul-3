// Se da un vector si un index in vectorul respectiv. Se cere sa se determine valoarea din vector care va fi pe pozitia index dupa ce vectorul este sortat. 

using System;

class Program
{
    static void Main()
    {
        int[] vector = { 9, 4, 7, 2, 5 };

        int index = 2;

        Array.Sort(vector);

        Console.WriteLine("Vectorul sortat:");
        foreach (int num in vector)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();

        Console.WriteLine($"Valoarea de la pozitia {index} dupa sortare este: {vector[index]}");
    }
}
