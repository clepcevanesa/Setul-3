//Se dau doi vectori. Se cere sa se determine ordinea lor lexicografica (care ar trebui sa apara primul in dictionar). 

using System;

class Program
{
    static void Main()
    {
        char[] vector1 = { 'a', 'b', 'c' };
        char[] vector2 = { 'a', 'd', 'e' };

        int comparatie = ComparareLexicografica(vector1, vector2);

        if (comparatie < 0)
        {
            Console.WriteLine("Vectorul 1 apare primul in ordinea lexicografica.");
        }
        else if (comparatie > 0)
        {
            Console.WriteLine("Vectorul 2 apare primul in ordinea lexicografica.");
        }
        else
        {
            Console.WriteLine("Cei doi vectori sunt identici in ordinea lexicografica.");
        }
    }

    static int ComparareLexicografica(char[] vector1, char[] vector2)
    {
        int lungimeMinima = Math.Min(vector1.Length, vector2.Length);

        for (int i = 0; i < lungimeMinima; i++)
        {
            if (vector1[i] != vector2[i])
            {
                return vector1[i].CompareTo(vector2[i]);
            }
        }

        return vector1.Length.CompareTo(vector2.Length);
    }
}
