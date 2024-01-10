//Se dau doi vectori v1 si v2. Se cere sa determine intersectia, reuniunea, si diferentele v1-v2 si v2 -v1 (implementarea operatiilor cu multimi). Elementele care se repeta vor fi scrise o singura data in rezultat. 
//Aceleasi cerinte ca si la problema anterioara dar de data asta elementele sunt stocate ca vectori cu valori binare (v[i] este 1 daca i face parte din multime si este 0 in caz contrar).

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int[] v1 = { 1, 1, 0, 1, 0, 1 }; 
        int[] v2 = { 0, 1, 1, 0, 1, 0 }; 

        HashSet<int> intersection = GetIntersection(v1, v2);
        HashSet<int> unionSet = GetUnion(v1, v2);
        HashSet<int> difference1 = GetDifference(v1, v2);
        HashSet<int> difference2 = GetDifference(v2, v1);

        Console.WriteLine("Intersectia: {" + string.Join(", ", intersection) + "}");
        Console.WriteLine("Reuniunea: {" + string.Join(", ", unionSet) + "}");
        Console.WriteLine("Diferenta v1 - v2: {" + string.Join(", ", difference1) + "}");
        Console.WriteLine("Diferenta v2 - v1: {" + string.Join(", ", difference2) + "}");
    }

    static HashSet<int> GetIntersection(int[] v1, int[] v2)
    {
        HashSet<int> set1 = ConvertToSet(v1);
        HashSet<int> set2 = ConvertToSet(v2);

        set1.IntersectWith(set2);
        return set1;
    }

    static HashSet<int> GetUnion(int[] v1, int[] v2)
    {
        HashSet<int> set1 = ConvertToSet(v1);
        HashSet<int> set2 = ConvertToSet(v2);

        set1.UnionWith(set2);
        return set1;
    }

    static HashSet<int> GetDifference(int[] v1, int[] v2)
    {
        HashSet<int> set1 = ConvertToSet(v1);
        HashSet<int> set2 = ConvertToSet(v2);

        set1.ExceptWith(set2);
        return set1;
    }

    static HashSet<int> ConvertToSet(int[] vector)
    {
        HashSet<int> set = new HashSet<int>();

        for (int i = 0; i < vector.Length; i++)
        {
            if (vector[i] == 1)
            {
                set.Add(i);
            }
        }

        return set;
    }
}
