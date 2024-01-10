//Se da un numar n in baza 10 si un numar b. 1 < b < 17. Sa se converteasca si sa se afiseze numarul n in baza b.   

using System;

class Program
{
    static string ConvertToBase(int number, int baseToConvert)
    {
        if (baseToConvert < 2 || baseToConvert > 16)
        {
            return "Baza trebuie sa fie între 2 si 16.";
        }

        char[] digits = "0123456789ABCDEF".ToCharArray();

        string result = string.Empty;

        while (number > 0)
        {
            result = digits[number % baseToConvert] + result;
            number /= baseToConvert;
        }

        return result;
    }

    static void Main()
    {
        int n = 123; 
        int b = 8;   

        string convertedNumber = ConvertToBase(n, b);
        Console.WriteLine($"Numarul {n} in baza {b} este: {convertedNumber}");
    }
}
