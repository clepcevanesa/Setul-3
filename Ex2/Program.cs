//Se da un vector cu n elemente si o valoare k. Se cere sa se determine prima pozitie din vector pe care apare k. Daca k nu apare in vector rezultatul va fi -1. 

using System;

class Program
{
    static int GasestePrimaPozitie(int[] vector, int k)
    {
        for (int i = 0; i < vector.Length; i++)
        {
            if (vector[i] == k)
            {
                return i; // returnează prima poziție a valorii k găsită în vector
            }
        }
        return -1; // returnează -1 dacă valoarea k nu apare în vector
    }

    static void Main()
    {
        int[] vector = { 4, 7, 2, 9, 5, 1 }; 
        int k = 5; 

        int primaPozitie = GasestePrimaPozitie(vector, k);

        if (primaPozitie != -1)
        {
            Console.WriteLine($"Valoarea {k} apare prima data la pozitia {primaPozitie} in vector.");
        }
        else
        {
            Console.WriteLine($"Valoarea {k} nu apare in vector.");
        }
    }
}
