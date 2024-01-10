//MergeSort. Sortati un vector folosind metoda MergeSort.

using System;

class MergeSortExample
{
    static void Merge(int[] arr, int left, int middle, int right)
    {
        int n1 = middle - left + 1;
        int n2 = right - middle;

        int[] LeftArray = new int[n1];
        int[] RightArray = new int[n2];

        for (int i = 0; i < n1; ++i)
            LeftArray[i] = arr[left + i];
        for (int j = 0; j < n2; ++j)
            RightArray[j] = arr[middle + 1 + j];

        int indexLeft = 0, indexRight = 0;

        int mergedIndex = left;

        while (indexLeft < n1 && indexRight < n2)
        {
            if (LeftArray[indexLeft] <= RightArray[indexRight])
            {
                arr[mergedIndex] = LeftArray[indexLeft];
                indexLeft++;
            }
            else
            {
                arr[mergedIndex] = RightArray[indexRight];
                indexRight++;
            }
            mergedIndex++;
        }

        while (indexLeft < n1)
        {
            arr[mergedIndex] = LeftArray[indexLeft];
            indexLeft++;
            mergedIndex++;
        }

        while (indexRight < n2)
        {
            arr[mergedIndex] = RightArray[indexRight];
            indexRight++;
            mergedIndex++;
        }
    }

    static void Sort(int[] arr, int left, int right)
    {
        if (left < right)
        {
            int middle = left + (right - left) / 2;

            Sort(arr, left, middle);
            Sort(arr, middle + 1, right);

            Merge(arr, left, middle, right);
        }
    }

    static void PrintArray(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n; ++i)
            Console.Write(arr[i] + " ");
        Console.WriteLine();
    }

    public static void Main(string[] args)
    {
        int[] arr = { 12, 11, 13, 5, 6, 7 };
        Console.WriteLine("Vectorul initial:");
        PrintArray(arr);

        Sort(arr, 0, arr.Length - 1);

        Console.WriteLine("\nVectorul sortat:");
        PrintArray(arr);
    }
}
