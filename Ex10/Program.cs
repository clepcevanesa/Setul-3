//Cautare binara. Se da un vector cu n elemente sortat in ordine crescatoare. Se cere sa se determine pozitia unui element dat k. Daca elementul nu se gaseste in vector rezultatul va fi -1.

using System;

class Program
{
    static int BinarySearch(int[] arr, int k)
    {
        int left = 0;
        int right = arr.Length - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (arr[mid] == k)
            {
                return mid;
            }

            if (arr[mid] < k)
            {
                left = mid + 1;
            }

            else
            {
                right = mid - 1;
            }
        }

        return -1;
    }

    static void Main()
    {
        int[] vector = { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 };
        int cautat = 12;

        int rezultat = BinarySearch(vector, cautat);

        if (rezultat != -1)
        {
            Console.WriteLine($"Elementul {cautat} a fost gasit la pozitia {rezultat}.");
        }
        else
        {
            Console.WriteLine($"Elementul {cautat} nu a fost gasit în vector.");
        }
    }
}
