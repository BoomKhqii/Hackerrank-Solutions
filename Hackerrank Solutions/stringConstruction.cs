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
     * Complete the 'stringConstruction' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts STRING s as parameter.
     */

    public static int stringConstruction(string s)
    {
        int cost = 0;
        char[] str = s.ToCharArray();
        List<char> strComparison = new List<char>();

        int n = str.Length; 


        for(int i = 0; i <= n-1; i++) {
            if (i == 0) {
                cost++;
                strComparison.Add(str[i]);
            }
            else {
                for(int l = 1; l <= n; l++) {
                    if(str[i] == strComparison[l]) {
                        cost++;
                    } else {
                        strComparison.Add(str[i]);
                    }
                }
            }
        }
        return cost;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int q = Convert.ToInt32(Console.ReadLine().Trim());

        for (int qItr = 0; qItr < q; qItr++)
        {
            string s = Console.ReadLine();

            int result = Result.stringConstruction(s);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}