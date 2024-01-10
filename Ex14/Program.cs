//Interschimbati elementele unui vector in asa fel incat la final toate valorile egale cu zero sa ajunga la sfarsit. (nu se vor folosi vectori suplimentari - operatia se va realiza inplace cu un algoritm eficient - se va face o singura parcugere a vectorului). 

using System;

class Program
{
    static void Main()
    {
        int[] vector = { 6, 0, 8, 0, 0, 3, 0, 9, 0 };

        RearrangeZeros(vector);

        Console.WriteLine("Vectorul cu zerourile la sfarsit:");
        foreach (var element in vector)
        {
            Console.Write(element + " ");
        }
    }

    static void RearrangeZeros(int[] nums)
    {
        int index = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != 0)
            {
                int temp = nums[index];
                nums[index] = nums[i];
                nums[i] = temp;
                index++;
            }
        }
    }
}
