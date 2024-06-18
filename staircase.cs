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
    public static void staircase(int n)
    {
        int x = n;
        x--;
        for (int i = 1, j = x; i <= n; i++, j--)
        {
            string space = new string(' ', j);
            string staircase = new string('#', i);
            Console.WriteLine(space + staircase);
        }
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());
 
        Result.staircase(n);
    }
}
