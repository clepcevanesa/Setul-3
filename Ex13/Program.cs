//Sortare prin insertie. Implementati algoritmul de sortare <Insertion Sort>. 

using System;

class InsertionSort
{
    static void Main(string[] args)
    {
        int[] arr = { 12, 11, 13, 5, 6 };

        Console.WriteLine("Array original:");
        PrintArray(arr);

        Sort(arr);

        Console.WriteLine("\nArray sortat:");
        PrintArray(arr);
    }

    static void Sort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 1; i < n; ++i)
        {
            int key = arr[i];
            int j = i - 1;

            while (j >= 0 && arr[j] > key)
            {
                arr[j + 1] = arr[j];
                j = j - 1;
            }
            arr[j + 1] = key;
        }
    }

    static void PrintArray(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n; ++i)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
    }
}
