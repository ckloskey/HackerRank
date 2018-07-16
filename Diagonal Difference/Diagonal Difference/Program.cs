using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution
{
    //https://www.hackerrank.com/challenges/diagonal-difference/problem
    static int diagonalDifference(int[][] a)
    {
        int forwardSum = 0;
        int backwardSum = 0;
        int backwardStart = a.Length - 1;
        for (int i = 0; i < a.Length; i++)
        {
            forwardSum = forwardSum += a[i][i];
            backwardSum = backwardSum += a[i][backwardStart];
            backwardStart--;
        }
        return Math.Abs(forwardSum - backwardSum);
    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[][] a = new int[n][];

        for (int i = 0; i < n; i++)
        {
            a[i] = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp));
        }

        int result = diagonalDifference(a);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
