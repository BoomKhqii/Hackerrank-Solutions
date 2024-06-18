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
    public int Length { get; }
    public static int stringConstruction(string s)
    {
        int cost = 0;
        char[] product = s.ToCharArray();
        List<char> strComparison = new List<char>();

        int n = product.Length; 

        for(int i = 0; i < n; i++) {
            if (i == 0) {
                cost++;
                strComparison.Add(product[i]);
            } 
            else {
                int comparisonN = strComparison.Count()-1;
                for(int l = 0; l <= comparisonN; l++) {     
                    if (product[i] == strComparison[l])
                        break;
                    else if (product[i] != strComparison[l] && l == comparisonN) {
                        cost++;
                        strComparison.Add(product[i]);
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