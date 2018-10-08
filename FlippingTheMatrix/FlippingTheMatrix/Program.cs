using System.IO;
using System;

class Solution
{
    //https://www.hackerrank.com/challenges/flipping-the-matrix/problem
    // Complete the flippingMatrix function below.
    static int flippingMatrix(int[][] matrix)
    {
        int sum = 0;
        for (int i = 0; i < matrix.Length / 2; i++)
        {
            for (int j = 0; j < matrix.Length / 2; j++)
            {
                sum += Math.Max(
                    Math.Max(matrix[i][j], matrix[i][matrix.Length - 1 - j]),
                    Math.Max(matrix[matrix.Length - 1 - i][j], matrix[matrix.Length - 1 - i][matrix.Length - 1 - j])
                    );
            }
        }
        return sum;
    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int q = Convert.ToInt32(Console.ReadLine());

        for (int qItr = 0; qItr < q; qItr++)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[][] matrix = new int[2 * n][];

            for (int i = 0; i < 2 * n; i++)
            {
                matrix[i] = Array.ConvertAll(Console.ReadLine().Split(' '), matrixTemp => Convert.ToInt32(matrixTemp));
            }

            int result = flippingMatrix(matrix);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
