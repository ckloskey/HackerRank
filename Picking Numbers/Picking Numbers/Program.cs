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
    // Complete the pickingNumbers function below.
    static int pickingNumbers(int[] a)
    {
        Array.Sort(a);
        int currentCount = 0;
        int maxCount = 0;
        int i = 0;
        int keyValue = a[i];
        while (i < a.Length)
        {
            if (Math.Abs(a[i] - keyValue) <= 1)
            {
                currentCount++;
                i++;
            }
            else
            {
                if (currentCount > maxCount)
                {
                    maxCount = currentCount;
                }
                currentCount = 0;
                keyValue = a.Where(x => x > keyValue).First();
                i = Array.IndexOf(a, keyValue);
            }
        }
        return maxCount != 0 ? maxCount  : currentCount;
    }

    static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp));
        int result = pickingNumbers(a);

        //textWriter.WriteLine(result);
        Console.WriteLine(result);
        //textWriter.Flush();
        //textWriter.Close();
    }
}
