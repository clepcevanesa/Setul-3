//Se da un vector cu n elemente, o valoare e si o pozitie din vector k. Se cere sa se insereze valoarea e in vector pe pozitia k. Primul element al vectorului se considera pe pozitia zero. 

using System;

class Program
{
    static void Main()
    {
        Console.Write("Introduceti lungimea vectorului: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int[] vector = new int[n]; 

        Console.WriteLine("Introduceti elementele vectorului:");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Elementul {i}: ");
            vector[i] = Convert.ToInt32(Console.ReadLine());
        }

        // Citirea valorii si poziției pentru inserare
        Console.Write("Introduceti valoarea de inserat: ");
        int e = Convert.ToInt32(Console.ReadLine());

        Console.Write("Introduceti pozitia pentru inserare: ");
        int k = Convert.ToInt32(Console.ReadLine());

        // Verificarea poziției valide pentru inserare
        if (k < 0 || k > n)
        {
            Console.WriteLine("Pozitia de inserare nu este valida.");
        }
        else
        {
            // Realizarea spațiului pentru noua valoare
            Array.Resize(ref vector, vector.Length + 1);

            // Mutarea elementelor pentru a face loc pentru noua valoare
            for (int i = vector.Length - 1; i > k; i--)
            {
                vector[i] = vector[i - 1];
            }

            // Inserarea valorii la poziția k
            vector[k] = e;

            // Afisarea vectorului actualizat
            Console.WriteLine("Vectorul actualizat:");
            for (int i = 0; i < vector.Length; i++)
            {
                Console.Write(vector[i] + " ");
            }
        }
    }
}
