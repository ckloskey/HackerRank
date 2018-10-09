using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;

class Solution
{
    //https://www.hackerrank.com/challenges/manasa-and-stones/problem
    // Complete the stones function below.
    static int[] stones(int n, int a, int b)
    {
        HashSet<int> allPermutations = new HashSet<int>();
        for (int i = 0; i < n; i++)
        {
            int permutation = (a * ((n - 1) - i) + (b * i));
            if (!allPermutations.Contains(permutation))
            {
                allPermutations.Add(permutation);
            }
        }
        return allPermutations.OrderBy(x => x).ToArray();
    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int T = Convert.ToInt32(Console.ReadLine());

        for (int TItr = 0; TItr < T; TItr++)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int a = Convert.ToInt32(Console.ReadLine());

            int b = Convert.ToInt32(Console.ReadLine());

            int[] result = stones(n, a, b);

            textWriter.WriteLine(string.Join(" ", result));
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
