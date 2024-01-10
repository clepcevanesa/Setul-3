//Sortare bicriteriala. Se dau doi vectori de numere intregi E si W, unde E[i] este un numar iar W[i] este un numar care reprezinta ponderea lui E[i]. Sortati vectorii astfel incat elementele lui E sa fie in in ordine crescatoare iar pentru doua valori egale din E, cea cu pondere mai mare va fi prima. 

using System;

class SortareBicriteriala
{
    static void Main()
    {
        int[] E = { 5, 2, 8, 5, 1 };
        int[] W = { 3, 6, 2, 9, 7 };

        if (E.Length != W.Length)
        {
            Console.WriteLine("Vectorii au lungimi diferite.");
            return;
        }

        Tuple<int, int>[] pairs = new Tuple<int, int>[E.Length];

        for (int i = 0; i < E.Length; i++)
        {
            pairs[i] = Tuple.Create(E[i], W[i]);
        }

        Array.Sort(pairs, (x, y) =>
        {
            int compareE = x.Item1.CompareTo(y.Item1);
            if (compareE != 0)
            {
                return compareE;
            }

            return y.Item2.CompareTo(x.Item2);
        });

        for (int i = 0; i < E.Length; i++)
        {
            E[i] = pairs[i].Item1;
            W[i] = pairs[i].Item2;
        }

        Console.WriteLine("Vectorul sortat dupa criteriile specificate:");
        for (int i = 0; i < E.Length; i++)
        {
            Console.WriteLine($"E[{i}] = {E[i]}, W[{i}] = {W[i]}");
        }
    }
}
