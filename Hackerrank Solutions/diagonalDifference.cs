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

class Result
{

    public static int diagonalDifference(List<List<int>> arr)
    {
        int length = arr.Count;
        length -= 1;
        int primaryDiagonal = 0, secondaryDiagonal = 0;
        
        Console.WriteLine(length);
        
        for(int n = 0, m = 0; n <= length; n++, m++){
            primaryDiagonal += (arr[n][m]);
        }
        for (int n = 0, m = length; n<= length; n++, m-- )
        {
            secondaryDiagonal += (arr[n][m]);
        }
        Console.WriteLine(primaryDiagonal);
        Console.WriteLine(secondaryDiagonal);
        int result = primaryDiagonal - secondaryDiagonal;
        int result_Final = Math.Abs(result);
        return result_Final;
         
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<List<int>> arr = new List<List<int>>();

        for (int i = 0; i < n; i++)
        {
            arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
        }

        int result = Result.diagonalDifference(arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}