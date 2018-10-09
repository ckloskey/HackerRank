using System;

class Solution
{
    //https://www.hackerrank.com/challenges/the-grid-search/problem
    // Complete the gridSearch function below.
    static bool GridSearch(string[] G, string[] P)
    {
        int traverseDownG = -1;
        int traveseAcrossG = -1;
        for (int gRow = 0; gRow < G.Length; gRow++)
        {
            for (int gRowCharIndex = 0; gRowCharIndex <= G[gRow].Length - P[0].Length; gRowCharIndex++)
            {
                int traverseDownP = 0;
                int traverseAcrossP = 0;
                if (G[gRow][gRowCharIndex] == P[traverseDownP][traverseAcrossP])
                {
                    traveseAcrossG = gRowCharIndex;
                    traverseDownG = gRow;
                    while (G[traverseDownG][traveseAcrossG] == P[traverseDownP][traverseAcrossP])
                    {
                        if (traverseAcrossP == P[traverseDownP].Length - 1)
                        {
                            if (traverseDownP == P.Length - 1)
                            {
                                return true;
                            }
                            else
                            {
                                traverseAcrossP = 0;
                                traveseAcrossG = gRowCharIndex;
                                traverseDownG++;
                                traverseDownP++;
                            }
                        }
                        traverseAcrossP++;
                        traveseAcrossG++;
                    }
                }
            }
        }
        return false;
    }

    static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int t = Convert.ToInt32(Console.ReadLine());

        for (int tItr = 0; tItr < t; tItr++)
        {
            string[] RC = Console.ReadLine().Split(' ');

            int R = Convert.ToInt32(RC[0]);

            int C = Convert.ToInt32(RC[1]);

            string[] G = new string[R];

            for (int i = 0; i < R; i++)
            {
                string GItem = Console.ReadLine();
                G[i] = GItem;
            }

            string[] rc = Console.ReadLine().Split(' ');

            int r = Convert.ToInt32(rc[0]);

            int c = Convert.ToInt32(rc[1]);

            string[] P = new string[r];

            for (int i = 0; i < r; i++)
            {
                string PItem = Console.ReadLine();
                P[i] = PItem;
            }

            string result = GridSearch(G, P) == true ? "YES" : "NO";
            Console.WriteLine(result);
        }
        //textWriter.Flush();
        //textWriter.Close();
    }
}
