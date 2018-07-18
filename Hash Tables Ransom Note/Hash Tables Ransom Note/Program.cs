using System.Collections.Generic;
using System;

class Solution
{
    //https://www.hackerrank.com/challenges/ctci-ransom-note/problem
    static void checkMagazine(string[] magazine, string[] note)
    {
        Dictionary<string, int> magazineWords = new Dictionary<string, int>();
        foreach (string word in magazine)
        {
            if (!magazineWords.ContainsKey(word))
            {
                magazineWords.Add(word, 1);
            }
            else
            {
                magazineWords[word] += 1;
            }
        }
        foreach (string word in note)
        {
            if (magazineWords.ContainsKey(word) && (magazineWords[word] > 0))
            {
                magazineWords[word] -= 1;
            }
            else
            {
                Console.WriteLine("No");
                return;
            }
        }
        Console.WriteLine("Yes");
    }

    static void Main(string[] args)
    {
        string[] mn = Console.ReadLine().Split(' ');

        int m = Convert.ToInt32(mn[0]);

        int n = Convert.ToInt32(mn[1]);

        string[] magazine = Console.ReadLine().Split(' ');

        string[] note = Console.ReadLine().Split(' ');

        if (n > m)
        {
            Console.WriteLine("No");
        }
        else
        {
            checkMagazine(magazine, note);
        }
    }
}