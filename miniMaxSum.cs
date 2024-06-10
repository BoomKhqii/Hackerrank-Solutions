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


    public static void miniMaxSum(List<int> arr)
    {
        long minSum = 999999999999999999, maxSum = 0, generalSum = 0;
        int arr_Length = arr.Count;
        arr_Length--;
        
        for (int i = 0; i <= arr_Length; i++)
        {
            generalSum = 0;
            for(int j = 0; j <= arr_Length; j++)
            {
                if(i == j)
                    continue;
                generalSum += arr[j];
            }
            if(generalSum > maxSum)
            maxSum = generalSum;
            if(generalSum < minSum)
            minSum = generalSum;
        }
        Console.WriteLine("{0} {1}", minSum, maxSum);
    }
}

class Solution
{
    public static void Main(string[] args)
    {

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.miniMaxSum(arr);
    }
}
