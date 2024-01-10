//Se da un vector cu n elemente si o pozitie din vector k. Se cere sa se stearga din vector elementul de pe pozitia k. Prin stergerea unui element, toate elementele din dreapta lui se muta cu o pozitie spre stanga. 

using System;

class MainClass
{
    public static void Main(string[] args)
    {
        int n = 5; 
        int k = 2; 

        int[] vector = { 1, 2, 3, 4, 5 }; 

        if (k < 0 || k >= n)
        {
            Console.WriteLine("Pozitia specificata nu este valida pentru acest vector.");
            return;
        }

        for (int i = k; i < n - 1; i++)
        {
            vector[i] = vector[i + 1];
        }

        n--; 

        Console.WriteLine("Vectorul rezultat dupa eliminarea elementului de pe pozitia " + k + ":");
        for (int i = 0; i < n; i++)
        {
            Console.Write(vector[i] + " ");
        }
    }
}
