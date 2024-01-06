//Deteminati printr-o singura parcurgere, cea mai mica si cea mai mare valoare dintr-un vector si de cate ori apar acestea. 

using System;

class Program
{
    static void Main()
    {
        int[] vector = { 5, 2, 9, 2, 7, 5, 3, 8, 2, 6 }; 

        int min = vector[0];
        int max = vector[0];
        int countMin = 1;
        int countMax = 1;

        for (int i = 1; i < vector.Length; i++)
        {
            if (vector[i] < min)
            {
                min = vector[i];
                countMin = 1;
            }
            else if (vector[i] == min)
            {
                countMin++;
            }

            if (vector[i] > max)
            {
                max = vector[i];
                countMax = 1;
            }
            else if (vector[i] == max)
            {
                countMax++;
            }
        }

        Console.WriteLine($"Cea mai mica valoare este {min} si apare de {countMin} ori.");
        Console.WriteLine($"Cea mai mare valoare este {max} si apare de {countMax} ori.");
    }
}
