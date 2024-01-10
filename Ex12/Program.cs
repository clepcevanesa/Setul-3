//Sortare selectie. Implementati algoritmul de sortare <Selection Sort>. 

using System;

class SelectionSortExample
{
    static void SelectionSort(int[] arr)
    {
        int n = arr.Length;

        for (int i = 0; i < n - 1; i++)
        {
            int minIndex = i;
            for (int j = i + 1; j < n; j++)
            {
                if (arr[j] < arr[minIndex])
                {
                    minIndex = j;
                }
            }

            if (minIndex != i)
            {
                int temp = arr[i];
                arr[i] = arr[minIndex];
                arr[minIndex] = temp;
            }
        }
    }

    static void Main()
    {
        int[] array = { 64, 25, 12, 22, 11 };
        Console.WriteLine("Array before sorting:");
        PrintArray(array);

        SelectionSort(array);

        Console.WriteLine("\nArray after sorting:");
        PrintArray(array);
    }

    static void PrintArray(int[] arr)
    {
        foreach (var item in arr)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}
