//Se dau doi vectori v1 si v2. Se cere sa determine intersectia, reuniunea, si diferentele v1-v2 si v2 -v1 (implementarea operatiilor cu multimi). Elementele care se repeta vor fi scrise o singura data in rezultat. 

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] v1 = { 1, 2, 3, 4, 5 };
        int[] v2 = { 3, 4, 5, 6, 7 };

        var intersect = v1.Intersect(v2).ToArray();
        var union = v1.Union(v2).ToArray();
        var diff1 = v1.Except(v2).ToArray();
        var diff2 = v2.Except(v1).ToArray();

        Console.WriteLine("Intersectia: {" + string.Join(", ", intersect) + "}");
        Console.WriteLine("Reuniunea: {" + string.Join(", ", union) + "}");
        Console.WriteLine("Diferenta v1 - v2: {" + string.Join(", ", diff1) + "}");
        Console.WriteLine("Diferenta v2 - v1: {" + string.Join(", ", diff2) + "}");
    }
}
