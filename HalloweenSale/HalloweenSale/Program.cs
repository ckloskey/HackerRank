using System.IO;
using System;

class Solution
{
    //https://www.hackerrank.com/challenges/halloween-sale/problem
    // Complete the howManyGames function below.
    static int howManyGames(int p, int d, int m, int s)
    {
        int count = 0;
        int spent = 0;
        while (spent <= s && spent + p <= s)
        {
            count++;
            spent = spent + p;
            p = p - d >= m ? p - d : m;
        }
        return count;
    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] pdms = Console.ReadLine().Split(' ');

        int p = Convert.ToInt32(pdms[0]);

        int d = Convert.ToInt32(pdms[1]);

        int m = Convert.ToInt32(pdms[2]);

        int s = Convert.ToInt32(pdms[3]);

        int answer = howManyGames(p, d, m, s);

        textWriter.WriteLine(answer);

        textWriter.Flush();
        textWriter.Close();
    }
}
