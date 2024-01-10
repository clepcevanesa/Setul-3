//Se dau doi vectori v1 si v2. Se cere sa determine intersectia, reuniunea, si diferentele v1-v2 si v2 -v1 (implementarea operatiilor cu multimi). Elementele care se repeta vor fi scrise o singura data in rezultat. 
//Aceleasi cerinte ca si la problema anterioara dar de data asta elementele din v1 respectiv v2  sunt in ordine strict crescatoare. 

using System;
using System.Collections.Generic;

class Program
{
    static int[] Intersection(int[] v1, int[] v2)
    {
        List<int> intersection = new List<int>();
        int i = 0, j = 0;

        while (i < v1.Length && j < v2.Length)
        {
            if (v1[i] == v2[j])
            {
                intersection.Add(v1[i]);
                i++;
                j++;
            }
            else if (v1[i] < v2[j])
            {
                i++;
            }
            else
            {
                j++;
            }
        }

        return intersection.ToArray();
    }

    static int[] Union(int[] v1, int[] v2)
    {
        List<int> union = new List<int>();
        int i = 0, j = 0;

        while (i < v1.Length && j < v2.Length)
        {
            if (v1[i] == v2[j])
            {
                union.Add(v1[i]);
                i++;
                j++;
            }
            else if (v1[i] < v2[j])
            {
                union.Add(v1[i]);
                i++;
            }
            else
            {
                union.Add(v2[j]);
                j++;
            }
        }

        while (i < v1.Length)
        {
            union.Add(v1[i]);
            i++;
        }

        while (j < v2.Length)
        {
            union.Add(v2[j]);
            j++;
        }

        return union.ToArray();
    }

    static int[] Difference(int[] v1, int[] v2)
    {
        List<int> difference = new List<int>();
        int i = 0, j = 0;

        while (i < v1.Length && j < v2.Length)
        {
            if (v1[i] == v2[j])
            {
                i++;
                j++;
            }
            else if (v1[i] < v2[j])
            {
                difference.Add(v1[i]);
                i++;
            }
            else
            {
                j++;
            }
        }

        while (i < v1.Length)
        {
            difference.Add(v1[i]);
            i++;
        }

        return difference.ToArray();
    }

    static void Main()
    {
        int[] v1 = { 1, 3, 5, 7, 9 };
        int[] v2 = { 3, 5, 7, 8, 10 };

        int[] intersect = Intersection(v1, v2);
        int[] union = Union(v1, v2);
        int[] difference1 = Difference(v1, v2);
        int[] difference2 = Difference(v2, v1);

        Console.WriteLine("Intersectia: " + string.Join(", ", intersect));
        Console.WriteLine("Reuniunea: " + string.Join(", ", union));
        Console.WriteLine("Diferenta v1 - v2: " + string.Join(", ", difference1));
        Console.WriteLine("Diferenta v2 - v1: " + string.Join(", ", difference2));
    }
}
