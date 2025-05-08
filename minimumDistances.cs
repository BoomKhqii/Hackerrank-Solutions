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
	public static int minimumDistances(List<int> a)
	{
		int minD = -1, currentMinD;

		for (int i = 0, j = 1; i < a.Count; j++)
		{
			if (j >= a.Count)
			{
				j = ++i;
				continue;
			}

			if (a[i] == a[j])
			{
				currentMinD = Math.Abs(i - j);
				if (currentMinD < minD || minD == -1)
					minD = currentMinD;

				j = ++i;
			}
		}

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