//Se da un vector s (vectorul in care se cauta) si un vector p (vectorul care se cauta). Determinati de cate ori apare p in s. De ex. Daca s = [1,2,1,2,1,3,1,2,1] si p = [1,2,1] atunci p apare in s de 3 ori. (Problema este dificila doar daca o rezolvati cu un algoritm liniar). 

using System;

class Program
{
    static void Main()
    {
        int[] s = { 1, 2, 1, 2, 1, 3, 1, 2, 1};
        int[] p = { 1, 2, 1 };

        int count = CountOccurrences(s, p);
        Console.WriteLine($"Numarul de aparitii ale vectorului p in vectorul s este: {count}");
    }

    static int CountOccurrences(int[] s, int[] p)
    {
        int count = 0;
        for (int i = 0; i <= s.Length - p.Length; i++)
        {
            bool found = true;
            for (int j = 0; j < p.Length; j++)
            {
                if (s[i + j] != p[j])
                {
                    found = false;
                    break;
                }
            }
            if (found)
            {
                count++;
            }
        }
        return count;
    }
}
