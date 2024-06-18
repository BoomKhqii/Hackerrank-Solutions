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
    public static void plusMinus(List<int> arr)
    {
        int length = arr.Count();
        (decimal positive, decimal negative, decimal zeros) = (0, 0, 0);
        (decimal resultPositive, decimal resultNegative, decimal resultZeros) = (0, 0, 0);

        for(int i = 0; i < length; i++) {
            if(arr[i] > 0)
                positive++;
            else if (arr[i] < 0)
                negative++;
            else
                zeros++;
        }
        resultPositive = positive / length;
        Console.WriteLine(resultPositive);
        resultNegative = negative / length;
        Console.WriteLine(resultNegative);
        resultZeros = zeros / length;
        Console.WriteLine(resultZeros);

    }
}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.plusMinus(arr);
    }
}