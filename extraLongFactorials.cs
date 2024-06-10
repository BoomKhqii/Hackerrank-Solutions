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
    public static BigInteger extraLongFactorials(BigInteger n)
    {
        if (n == 0)
            return 1;
        BigInteger temp_result = n*extraLongFactorials(n-1);
        
        return temp_result;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        BigInteger n = Convert.ToInt32(Console.ReadLine().Trim());
        
        BigInteger result = Result.extraLongFactorials(n);

        Console.WriteLine(result);
        
    }
}