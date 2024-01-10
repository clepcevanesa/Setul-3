//Se da un vector de n numere naturale. Determinati cel mai mare divizor comun al elementelor vectorului.

using System;

class Program
{
    static int CalculateGCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }

    static int FindGCDOfArray(int[] arr)
    {
        int result = arr[0];
        int length = arr.Length;

        for (int i = 1; i < length; i++)
        {
            result = CalculateGCD(result, arr[i]);
        }

        return result;
    }

    static void Main()
    {
        int[] numbers = { 24, 36, 48, 60 };

        Console.WriteLine("Numerele din vector:");
        foreach (int num in numbers)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();

        int gcd = FindGCDOfArray(numbers);
        Console.WriteLine("Cel mai mare divizor comun al numerelor este: " + gcd);
    }
}
