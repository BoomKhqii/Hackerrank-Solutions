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
 public static List<int> climbingLeaderboard(List<int> ranked, List<int> player)
    { 
        List<int> newRank = new List<int>();
        ranked = ranked.Distinct().ToList();
        int rankCount = ranked.Count()-1;
        int currentRank = ranked.Count();

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