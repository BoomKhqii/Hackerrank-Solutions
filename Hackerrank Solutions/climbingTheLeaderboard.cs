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
     * Complete the 'climbingLeaderboard' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts following parameters:
     *  1. INTEGER_ARRAY ranked
     *  2. INTEGER_ARRAY player
     */

/*
    private static int newRank(ref int currentRank, ref int i)
    {
        currentRank--;
        int resultRank = currentRank;
        //currentRank = 0;
        i++;
        return resultRank;
    }*/

    public static List<int> climbingLeaderboard(List<int> ranked, List<int> player)
    { 
        List<int> newRank = new List<int>();
        ranked = ranked.Distinct().ToList();
        int rankCount = ranked.Count()-1;
        int currentRank = ranked.Count();
        /*
        5
        10 20 40 50 100
        5 25 50 120

        6 4 2 1

        5 < 10      ++  6   6
        25 > 10     --  5
        25 > 20     --  4
        25 < 40     ==  4   4     
        50 > 40     --  3 
        50 == 50    --  2   2
        120 > 100   --  1   1
        */
        for(int i = 0; i < player.Count(); rankCount--) {
            if(player[i] < ranked[rankCount]) {
                if(i == 0) {
                    currentRank++;
                }
                i++;
                rankCount++;
                newRank.Add(currentRank);
            } else if(player[i] > ranked[rankCount]) {
                currentRank--;
                if(rankCount == 0){
                    newRank.Add(currentRank);
                    break;
                }
            } else if(player[i] == ranked[rankCount]){
                if (i == 0) {
                    newRank.Add(currentRank);
                    i++;
                    continue;
                }
                currentRank--;
                i++;
                newRank.Add(currentRank);
            }
        }
        return newRank;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int rankedCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> ranked = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(rankedTemp => Convert.ToInt32(rankedTemp)).ToList();

        int playerCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> player = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(playerTemp => Convert.ToInt32(playerTemp)).ToList();

        List<int> result = Result.climbingLeaderboard(ranked, player);

        textWriter.WriteLine(String.Join("\n", result));

        textWriter.Flush();
        textWriter.Close();
    }
}