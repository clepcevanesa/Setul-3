//Reverse. Se da un vector nu n elemente. Se cere sa se inverseze ordinea elementelor din vector. Prin inversare se intelege ca primul element devine ultimul, al doilea devine penultimul etc.

using System;

class Program
{
    static void Main()
    {
        int[] vector = { 1, 2, 3, 4, 5 };

        Console.WriteLine("Vectorul initial:");
        AfisareVector(vector);

        InverseazaVector(vector);

        Console.WriteLine("\nVectorul dupa inversare:");
        AfisareVector(vector);
    }

    static void InverseazaVector(int[] arr)
    {
        int lungime = arr.Length;
        for (int i = 0; i < lungime / 2; i++)
        {
            int temp = arr[i];
            arr[i] = arr[lungime - i - 1];
            arr[lungime - i - 1] = temp;
        }
    }

    static void AfisareVector(int[] arr)
    {
        foreach (int element in arr)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();
    }
}
