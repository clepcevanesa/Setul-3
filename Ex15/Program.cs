//Modificati un vector prin eliminarea elementelor care se repeta, fara a folosi un alt vector. 

using System;

class Program
{
    static void Main()
    {
        int[] vector = { 1, 2, 2, 3, 4, 4, 5, 5, 6 };

        Console.WriteLine("Vectorul initial:");
        PrintVector(vector);

        int newSize = RemoveDuplicates(vector);

        Console.WriteLine("\nVectorul fara elemente duplicate:");
        for (int i = 0; i < newSize; i++)
        {
            Console.Write(vector[i] + " ");
        }
    }

    static int RemoveDuplicates(int[] arr)
    {
        if (arr.Length == 0 || arr.Length == 1)
        {
            return arr.Length;
        }

        int newSize = 1;

        for (int i = 1; i < arr.Length; i++)
        {
            int j;
            for (j = 0; j < newSize; j++)
            {
                if (arr[i] == arr[j])
                {
                    break;
                }
            }

            if (j == newSize)
            {
                arr[newSize] = arr[i];
                newSize++;
            }
        }

        return newSize;
    }

    static void PrintVector(int[] arr)
    {
        foreach (var item in arr)
        {
            Console.Write(item + " ");
        }
    }
}
