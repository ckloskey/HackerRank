using System.Collections.Generic;
using System.Linq;
using System;

class Solution
{
    //https://www.hackerrank.com/challenges/kaprekar-numbers/problem
    // Complete the kaprekarNumbers function below.
    static bool kaprekarNumbers(long i)
    {
        bool isKaprekarNumbers = false;
        long ii = i * i;
        long digitCount = ii.ToString().Count();
        bool odd = digitCount % 2 == 1 ? true : false;
        long firstSetOfDigits = (long)Math.Floor(ii / (Math.Pow(10, Math.Ceiling((double)digitCount / 2))));
        long secondSetOfDigits = 0;
        try
        {
            secondSetOfDigits = odd == false ? ii % (10 * firstSetOfDigits) : ii % (long)Math.Round((double)100 * firstSetOfDigits, 0);
        }
        catch (DivideByZeroException)
        {
            if (ii == i)
            {
                isKaprekarNumbers = true;
            }
        }

        if (secondSetOfDigits + firstSetOfDigits == i)
        {
            isKaprekarNumbers = true;
        }
        return isKaprekarNumbers;
    }

    static void Main(string[] args)
    {
        int p = Convert.ToInt32(Console.ReadLine());

        int q = Convert.ToInt32(Console.ReadLine());

        List<int> kaprekarNumbersWithinRange = new List<int>();
        for (int i = p; i <= q; i++)
        {
            if (kaprekarNumbers(i) == true)
            {
                kaprekarNumbersWithinRange.Add(i);
            }
        }
        if (kaprekarNumbersWithinRange.Count == 0)
        {
            Console.WriteLine("INVALID RANGE");
        }
        else
        {
            Console.WriteLine(string.Join(" ", kaprekarNumbersWithinRange));
        }
        Console.ReadLine();
        Console.ReadKey();
    }
}
