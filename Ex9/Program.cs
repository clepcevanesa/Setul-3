//Rotire k. Se da un vector cu n elemente. Rotiti elementele vectorului cu k pozitii spre stanga.

using System;

class Program
{
    static void RotateLeft(int[] arr, int k)
    {
        int n = arr.Length;
        k = k % n; 

        ReverseArray(arr, 0, k - 1);
        ReverseArray(arr, k, n - 1);
        ReverseArray(arr, 0, n - 1);
    }

    static void ReverseArray(int[] arr, int start, int end)
    {
        while (start < end)
        {
            int temp = arr[start];
            arr[start] = arr[end];
            arr[end] = temp;
            start++;
            end--;
        }
    }

    static void Main()
    {
        int[] vector = { 1, 2, 3, 4, 5 };
        int k = 3;

        Console.WriteLine("Vectorul initial:");
        PrintArray(vector);

        RotateLeft(vector, k);

        Console.WriteLine($"\nVectorul rotit la stanga cu {k} pozitii:");
        PrintArray(vector);
    }

    static void PrintArray(int[] arr)
    {
        foreach (var element in arr)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();
    }
}
