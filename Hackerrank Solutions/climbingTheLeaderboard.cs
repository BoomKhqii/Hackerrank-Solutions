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
    public void valid(int currentRank, List<int> ranked, int l, int i) {
        currentRank = 0;
        l = 0;
        i++;
    }
    */
    private static int GetRank(ref int currentRank, ref int l, ref int i)
    {
        currentRank++;
        int resultRank = currentRank;
        currentRank = 0;
        l = 0;
        i++;
        return resultRank;
    }

    public static List<int> climbingLeaderboard(List<int> ranked, List<int> player)
    {
        /* 
        100 100 50 40 20 10
        5 25 50 120
        */
        int currentRank = 0;
        List<int> rank = new List<int>();
        int playerCount = player.Count();
        int rankCount = ranked.Count()-1;
        int lastRank = -1;

        for(int i = 0, l = 0; i < playerCount; l++, lastRank++) {

            if(l == ranked.Count()) {
                rank.Add(GetRank(ref currentRank, ref l, ref i));
                continue;
            }
            
            if(player[i] < ranked[l] && ranked[lastRank] != ranked[l]) {
                currentRank++;
            } else if (player[i] < ranked[l] && l == rankCount) {
                rank.Add(GetRank(ref currentRank, ref l, ref i));
            } else if (player[i] > ranked[l]) {
                rank.Add(GetRank(ref currentRank, ref l, ref i));
            } else if(player[i] == ranked[l]) {
                rank.Add(GetRank(ref currentRank, ref l, ref i));
            }
        }
        return rank;
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