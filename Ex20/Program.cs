//Se dau doua siraguri de margele formate din margele albe si negre, notate s1, respectiv s2. Determinati numarul de suprapuneri (margea cu margea) a unui sirag peste celalalt astfel incat margelele suprapuse au aceeasi culoare. Siragurile de margele se pot roti atunci cand le suprapunem. 

using System;

class Program
{
    static int NumarSuprapuneri(string s1, string s2)
    {
        int count = 0;
        int m = s1.Length;
        int n = s2.Length;

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (s1[i] == s2[j])
                {
                    int k = 0;
                    while (i + k < m && j + k < n && s1[i + k] == s2[j + k])
                    {
                        k++;
                        count++;
                    }
                }
            }
        }
        return count;
    }

    static void Main()
    {
        string sirag1 = "ABCDAB";
        string sirag2 = "BCDABC";

        int rezultat = NumarSuprapuneri(sirag1, sirag2);

        Console.WriteLine($"Numarul de suprapuneri este: {rezultat}");
    }
}
