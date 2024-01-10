//(Element majoritate). Intr-un vector cu n elemente, un element m este element majoritate daca mai mult de n/2 din valorile vectorului sunt egale cu m (prin urmare, daca un vector are element majoritate acesta este unui singur).  Sa se determine elementul majoritate al unui vector (daca nu exista atunci se va afisa <nu exista>). (incercati sa gasiti o solutie liniara). 

using System;

class MajorityElement
{
    static int FindMajorityElement(int[] nums)
    {
        int candidate = 0;
        int count = 0;

        foreach (var num in nums)
        {
            if (count == 0)
            {
                candidate = num;
                count = 1;
            }
            else if (candidate == num)
            {
                count++;
            }
            else
            {
                count--;
            }
        }

        count = 0;
        foreach (var num in nums)
        {
            if (num == candidate)
            {
                count++;
            }
        }

        if (count > nums.Length / 2)
        {
            return candidate;
        }
        else
        {
            return -1; 
        }
    }

    public static void Main(string[] args)
    {
        int[] vector = { 3, 3, 4, 2, 4, 4, 2, 4, 4 }; 

        int result = FindMajorityElement(vector);
        if (result != -1)
        {
            Console.WriteLine($"Elementul majoritar este: {result}");
        }
        else
        {
            Console.WriteLine("Nu exista element majoritar in vector.");
        }
    }
}
