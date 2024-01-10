//Rotire. Se da un vector cu n elemente. Rotiti elementele vectorului cu o pozitie spre stanga. Prin rotire spre stanga primul element devine ultimul, al doilea devine primul etc. 

using System;

class Program
{
    static void Main()
    {
        int n;
        Console.Write("Introduceti dimensiunea vectorului: ");
        while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
        {
            Console.Write("Introduceti o valoare valida pentru dimensiune: ");
        }

        int[] vector = new int[n];
        Console.WriteLine("Introduceti elementele vectorului:");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Elementul {i + 1}: ");
            while (!int.TryParse(Console.ReadLine(), out vector[i]))
            {
                Console.Write($"Introduceti un numar valid pentru elementul {i + 1}: ");
            }
        }

        RotateLeft(vector);

        Console.WriteLine("Vectorul rotit spre stanga cu o pozitie:");
        foreach (int element in vector)
        {
            Console.Write($"{element} ");
        }
    }

    static void RotateLeft(int[] arr)
    {
        if (arr.Length <= 1)
        {
            return;
        }

        int temp = arr[0];
        for (int i = 0; i < arr.Length - 1; i++)
        {
            arr[i] = arr[i + 1];
        }
        arr[arr.Length - 1] = temp;
    }
}
