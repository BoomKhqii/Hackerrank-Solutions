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
	
	Input (stdin)
	6
	7 1 3 4 1 7
	Your Output (stdout)
	-5
	Expected Output
	3

	Debug output
	a[i] == a[j]: 0 5
	a[i] == a[j]: 1 4
	j >= len: 2 6
	j >= len: 3 6
	j >= len: 4 6
	j >= len: 5 6

	 */
	public static int minimumDistances(List<int> a)
	{
		int minD = int.MaxValue;
		int currentMinD;
		int len = a.Count;

		for (int i = 0, j = 1; i < len; j++)
		{
			if (j >= len)
			{
				Console.WriteLine("j >= len: " + i + " " + j);
				i++;
				j = i;
				continue;
			}
			else if (a[j] == int.MaxValue) continue;

			if (a[i] == a[j])
			{
				Console.WriteLine("a[i] == a[j]: " + i + " " + j);
				currentMinD = Math.Abs(i - j);
				a[j] = int.MaxValue;

				if (currentMinD < minD)
					minD = currentMinD;

				i++;
				j = i;
				continue;
			}
		}

		if (minD == int.MaxValue) minD = -1;

		return minD;
	}
}

class Solution
{
	public static void Main(string[] args)
	{
		TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

		int n = Convert.ToInt32(Console.ReadLine().Trim());

		List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

		int result = Result.minimumDistances(a);

		textWriter.WriteLine(result);

		textWriter.Flush();
		textWriter.Close();
	}
}