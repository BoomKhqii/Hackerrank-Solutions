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
    public static void Display(List<int> arr)
    {
        foreach(int number in arr)
            Console.Write(number + " ");
        Console.WriteLine();
    }
    
    public static void InsertRemove(List<int> arr, int n, int i, int value)
    {
        arr.Insert(i, value);
        arr.RemoveAt(n);
    }
    
    public static void insertionSort2(int n, List<int> arr)
    {
        for(int smallNumber = 1; smallNumber < n; smallNumber++)
        {
            int holdNumber = arr[smallNumber];
            for(int bigNumber = smallNumber-1; bigNumber >= 0; bigNumber--)
            {
                if(arr[bigNumber] > holdNumber)
                    InsertRemove(arr, bigNumber+2, bigNumber, holdNumber);
                else if(holdNumber < arr[bigNumber] && bigNumber == 0)
                    InsertRemove(arr, bigNumber+2, 0, holdNumber);
            }
            Display(arr);
        }
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.insertionSort2(n, arr);
    }
}