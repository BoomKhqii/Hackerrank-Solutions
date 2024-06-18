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
    public static string timeConversion(string s)
    {
        string amPM = s.Substring(s.Length - 2);
        string milTime, milTime_2;

        int hourHand = Convert.ToInt32(s.Substring(0, 2));
        
        string string_HourHand = Convert.ToString(hourHand);
        
        if (amPM == "PM"){
            if(hourHand==12)
                hourHand = 12;
             else
                hourHand += 12;
            string_HourHand = Convert.ToString(hourHand);
            milTime = s.Substring(s.Length - 8);
            milTime_2 = milTime.Substring(0,milTime.Length-2);
            s = string_HourHand + milTime_2;
        } else if (amPM == "AM"){
            if (s.Substring(0, 2) == "12")
                string_HourHand = "00";
            else
                string_HourHand = s.Substring(0, 2);
            milTime = s.Substring(s.Length - 8);
            milTime_2 = milTime.Substring(0,milTime.Length-2);
            s = string_HourHand + milTime_2;
        }
        return s;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = Result.timeConversion(s);

        textWriter.WriteLine(result);
        textWriter.Flush();
        textWriter.Close();
    }
}