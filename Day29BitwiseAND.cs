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

    public static int bitwiseAnd(int N, int K)
    {
        int max = 0;
        for (int i = 1, j = 2; i <= N; j++)
        {
            if (j >= N)
            {
                i++;
                j = i;
                continue;
            }

            string s1 = Convert.ToString(i), s2 = Convert.ToString(j);
            if ((Convert.ToInt32(s1) & Convert.ToInt32(s2)) < K && (Convert.ToInt32(s1) & Convert.ToInt32(s2)) > max)
            {
                max = Convert.ToInt32(Convert.ToInt32(s1) & Convert.ToInt32(s2));
                if (max == K) return max;
            }
        }
        return max;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int t = Convert.ToInt32(Console.ReadLine().Trim());

        for (int tItr = 0; tItr < t; tItr++)
        {
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int count = Convert.ToInt32(firstMultipleInput[0]);

            int lim = Convert.ToInt32(firstMultipleInput[1]);

            int res = Result.bitwiseAnd(count, lim);

            textWriter.WriteLine(res);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
