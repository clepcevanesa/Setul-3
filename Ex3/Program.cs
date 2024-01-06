//Sa se determine pozitiile dintr-un vector pe care apar cel mai mic si cel mai mare element al vectorului. Pentru extra-credit realizati programul efectuand 3n/2 comparatii (in cel mai rau caz). 

using System;

class Program
{
    static void FindMinMaxPositions(int[] arr)
    {
        int n = arr.Length;
        int minPos = 0, maxPos = 0;

        for (int i = 0; i < n - 1; i += 2)
        {
            int smallerIndex = i;
            int largerIndex = i + 1;

            if (arr[i] > arr[i + 1])
            {
                smallerIndex = i + 1;
                largerIndex = i;
            }

            // Verific minimul
            if (arr[smallerIndex] < arr[minPos])
            {
                minPos = smallerIndex;
            }

            // Verific maximul
            if (arr[largerIndex] > arr[maxPos])
            {
                maxPos = largerIndex;
            }
        }

        if (n % 2 != 0)
        {
            if (arr[n - 1] < arr[minPos])
            {
                minPos = n - 1;
            }
            else if (arr[n - 1] > arr[maxPos])
            {
                maxPos = n - 1;
            }
        }

        Console.WriteLine($"Pozitia celui mai mic element: {minPos}");
        Console.WriteLine($"Pozitia celui mai mare element: {maxPos}");
    }

    static void Main()
    {
        int[] vector = { 3, 7, 1, 9, 4, 6, 8, 2, 5 }; 

        FindMinMaxPositions(vector);
    }
}
