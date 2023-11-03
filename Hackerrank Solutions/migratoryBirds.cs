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
    public static int migratoryBirds(List<int> arr)
    {
        int one = 0;
        int two = 0;
        int three = 0;
        int four = 0;
        int five = 0;
        int length = arr.Count();
        int result = 0;
        
        for(int i = 0; i < length; i++)
        {
            if(arr[i] == 1)
                one++;
            else if(arr[i] == 2)
                two++;
            else if(arr[i] == 3)
                three++;
            else if(arr[i] == 4)
                four++;
            else if(arr[i] == 5)
                five++;
        }

        int[] birds = { one, two, three, four, five };
        
        int high = 0;
        for(int i = 0; i < 5; i++)
        {
            if(birds[i] > high)
                high = birds[i]; 
        }
        
        if(high == one)
            return 1;
        else if(high == two)
            return 2;
        else if(high == three)
            return 3;
        else if(high == four)
            return 4;
        else if(high == five)
            return 5;
        return result;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int arrCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        int result = Result.migratoryBirds(arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}