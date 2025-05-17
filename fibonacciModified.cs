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
using System.Numerics;

class Result
{
    public static BigInteger fibonacciModified(BigInteger t1, BigInteger t2, int n)
    {
        BigInteger output = 0;
        for (int i = 2; i < n; i++)
        {
            output = t1 + Power(t2);
            t1 = t2;
            t2 = output;
        }

        return output;
    }

    public static BigInteger Power(BigInteger n) { return n * n; }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        BigInteger t1 = Convert.ToInt32(firstMultipleInput[0]);

        BigInteger t2 = Convert.ToInt32(firstMultipleInput[1]);

        int n = Convert.ToInt32(firstMultipleInput[2]);

        BigInteger result = Result.fibonacciModified(t1, t2, n);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}