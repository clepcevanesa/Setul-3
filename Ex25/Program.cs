//(Interclasare) Se dau doi vector sortati crescator v1 si v2. Construiti un al treilea vector ordonat crescator format din toate elementele din  v1 si v2. Sunt permise elemente duplicate. 

using System;

class Program
{
    static void Main()
    {
        int[] v1 = { 1, 3, 5, 7, 9 };
        int[] v2 = { 2, 4, 6, 8, 10 };

        int[] mergedArray = MergeArrays(v1, v2);

        Console.WriteLine("Vectorul interclasat este:");
        foreach (int num in mergedArray)
        {
            Console.Write(num + " ");
        }
    }

    static int[] MergeArrays(int[] v1, int[] v2)
    {
        int n1 = v1.Length;
        int n2 = v2.Length;
        int[] mergedArray = new int[n1 + n2];

        int i = 0, j = 0, k = 0;

        while (i < n1 && j < n2)
        {
            if (v1[i] <= v2[j])
            {
                mergedArray[k++] = v1[i++];
            }
            else
            {
                mergedArray[k++] = v2[j++];
            }
        }

        while (i < n1)
        {
            mergedArray[k++] = v1[i++];
        }

        while (j < n2)
        {
            mergedArray[k++] = v2[j++];
        }

        return mergedArray;
    }
}
