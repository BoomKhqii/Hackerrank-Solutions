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

    public static void insertionSort1(int n, List<int> arr)
    {
        int value = arr[n-1];                   
        for(int i = n-1, j = n-2; j >= 0 && i >=0 && n >= 0; i--, j--, n--)
        {
            if(arr[j] > value)
                InsertRemove(arr, n, i, arr[j]);
            else if (value > arr[j])
            {
                InsertRemove(arr, n, i, value);
                Display(arr);
                break;
            }
            Display(arr);
            if (value < arr[j] && j == 0)
            {
                InsertRemove(arr, n, j, value);
                Display(arr);
                break;
            }
        }
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.insertionSort1(n, arr);
    }
}