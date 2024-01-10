//Se da un polinom de grad n ai carui coeficienti sunt stocati intr-un vector. Cel mai putin semnificativ coeficient este pe pozitia zero in vector. Se cere valoarea polinomului intr-un punct x. 

using System;

class Program
{
    static double ValoarePolinom(double[] coeficienti, double x)
    {
        double rezultat = 0;

        for (int i = 0; i < coeficienti.Length; i++)
        {
            rezultat += coeficienti[i] * Math.Pow(x, i);
        }

        return rezultat;
    }

    static void Main()
    {
        double[] coeficienti = { 7, -5, 3, 2 };

        double x = 2;

        double valoare = ValoarePolinom(coeficienti, x);

        Console.WriteLine($"Valoarea polinomului in punctul {x} este: {valoare}");
    }
}
