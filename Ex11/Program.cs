//Se da un numar natural n. Se cere sa se afiseze toate numerele prime mai mici sau egale cu n (ciurul lui Eratostene). 

using System;

class CiurulluiEratostene
{
    static void Main()
{
    Console.Write("Introduceti valoarea lui n: ");
    int n = int.Parse(Console.ReadLine());

    AfiseazaNumerePrime(n);
}

static void AfiseazaNumerePrime(int n)
{
    bool[] estePrim = new bool[n + 1];

    for (int i = 2; i <= n; i++)
    {
        estePrim[i] = true;
    }

    for (int p = 2; p * p <= n; p++)
    {
        if (estePrim[p] == true)
        {
            for (int i = p * p; i <= n; i += p)
            {
                estePrim[i] = false;
            }
        }
    }

    Console.WriteLine($"Numerele prime mai mici sau egale cu {n} sunt:");
    for (int i = 2; i <= n; i++)
    {
        if (estePrim[i])
        {
            Console.Write(i + " ");
        }
    }
}
}
