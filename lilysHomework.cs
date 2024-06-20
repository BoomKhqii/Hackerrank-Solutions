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

    /*
     * Complete the 'lilysHomework' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    // error in the swap function
    /*
    public static void Swap<int>(IList<int> arr, int i, int length) {
        int tmp = arr[i];
        arr[i] = arr[length];
        list[length] = tmp;
    }
    */

    public static int lilysHomework(List<int> arr)
    {
        int length = arr.Count() - 1;
        int swaps = 0;

        /*
             Swap      Result
                    [7, 15, 12, 3]
            3 7     [3, 15, 12, 7]
            7 15    [3, 7, 12, 15]
            
            3, 4, 2, 5, 1
            1, 4, 2, 5, 3
            1, 3, 2, 5, 4
            1, 3, 2, 5, 4
            1, 3, 2, 4, 5

            3, 4, 2, 5, 1
            1, 4, 2, 5, 3
            1, 2, 4, 5, 3
            1, 2, 3, 5, 4
            1, 2, 3, 4, 5

            3, 4, 2, 5, 1
            
         */

        for (int i = 0; i <= length; i++) {
            if (arr[i] > arr[length]) {
                swaps++;

                int tmp = arr[i];
                arr[i] = arr[length];
                arr[length] = tmp;
            } else if () {

            }
        }
        return swaps;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        int result = Result.lilysHomework(arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}