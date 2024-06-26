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
    public static List<int> breakingRecords(List<int> scores)
    {
        List<int> result = new List<int>();
        int highest = -1; 
        int lowest = int.MaxValue;
        int highSum = 0;
        int lowSum = 0;
        int length = scores.Count();

        for(int i = 0; i <length; i++)
        {
            if(scores[i] > highest)
            {
                highest = scores[i];
                highSum++;
            }
            if(lowest > scores[i])
            {
                lowest = scores[i];
                lowSum++;
            }
            Console.WriteLine("before {0} {1}",highSum,lowSum);
            if(i==0)
            {
                highSum--;
                lowSum--;
            }
            Console.WriteLine("{0} {1}",highest,lowest);
            Console.WriteLine("{0} {1}",highSum,lowSum);
        }
        result.Add(highSum);
        result.Add(lowSum);
        return result;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> scores = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(scoresTemp => Convert.ToInt32(scoresTemp)).ToList();

        List<int> result = Result.breakingRecords(scores);

        textWriter.WriteLine(String.Join(" ", result));

        textWriter.Flush();
        textWriter.Close();
    }
}