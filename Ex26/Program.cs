//Se dau doua numere naturale foarte mari (cifrele unui numar foarte mare sunt stocate intr-un vector - fiecare cifra pe cate o pozitie). Se cere sa se determine suma, diferenta si produsul a doua astfel de numere. 

using System;
using System.Collections.Generic;

class BigNumbersOperations
{
    static List<int> Add(List<int> num1, List<int> num2)
    {
        int carry = 0;
        int maxSize = Math.Max(num1.Count, num2.Count);
        List<int> result = new List<int>();

        for (int i = 0; i < maxSize || carry > 0; i++)
        {
            int digit1 = i < num1.Count ? num1[i] : 0;
            int digit2 = i < num2.Count ? num2[i] : 0;

            int sum = digit1 + digit2 + carry;
            carry = sum / 10;
            result.Add(sum % 10);
        }

        return result;
    }

    static List<int> Subtract(List<int> num1, List<int> num2)
    {
        int borrow = 0;
        List<int> result = new List<int>();

        for (int i = 0; i < num1.Count; i++)
        {
            int digit1 = num1[i];
            int digit2 = i < num2.Count ? num2[i] : 0;

            int diff = digit1 - digit2 - borrow;
            if (diff < 0)
            {
                diff += 10;
                borrow = 1;
            }
            else
            {
                borrow = 0;
            }

            result.Add(diff);
        }

        while (result.Count > 1 && result[result.Count - 1] == 0)
        {
            result.RemoveAt(result.Count - 1);
        }

        return result;
    }

    static List<int> Multiply(List<int> num1, List<int> num2)
    {
        int m = num1.Count, n = num2.Count;
        List<int> result = new List<int>(new int[m + n]);

        for (int i = m - 1; i >= 0; i--)
        {
            for (int j = n - 1; j >= 0; j--)
            {
                int mul = num1[i] * num2[j];
                int sum = mul + result[i + j + 1];

                result[i + j] += sum / 10;
                result[i + j + 1] = sum % 10;
            }
        }

        int firstNonZero = 0;
        while (firstNonZero < result.Count - 1 && result[firstNonZero] == 0)
        {
            firstNonZero++;
        }

        return result.GetRange(firstNonZero, result.Count - firstNonZero);
    }

    static void Main()
    {
        List<int> number1 = new List<int> { 9, 9, 9 }; 
        List<int> number2 = new List<int> { 1, 0, 0 }; 

        List<int> sum = Add(number1, number2);
        List<int> difference = Subtract(number1, number2);
        List<int> product = Multiply(number1, number2);

        Console.WriteLine("Suma:");
        sum.ForEach(Console.Write);
        Console.WriteLine();

        Console.WriteLine("Diferenta:");
        difference.ForEach(Console.Write);
        Console.WriteLine();

        Console.WriteLine("Produsul:");
        product.ForEach(Console.Write);
        Console.WriteLine();
    }
}
