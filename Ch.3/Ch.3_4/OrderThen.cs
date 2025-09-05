using System;
using System.Collections.Generic;
using System.Linq;

public class Primers
{
    public string Team { get; set; }
    public int Games { get; set; }
    public int Wins { get; set; }
    public int Draws { get; set; }
    public int Losses { get; set; }
    public int GoalsFor { get; set; }
    public int GoalsAgainst { get; set; }
    public int GoalDifference => GoalsFor - GoalsAgainst;
    public int Points => Wins * 3 + Draws;

}

class Program
{
    static void Main()
    {
        var big4 = new List<Primers>
        {
            new Primers { Team = "Chelsea", Games = 3, Wins = 2, Draws = 1, Losses = 0, GoalsFor = 7, GoalsAgainst = 1},
            new Primers { Team = "Arsenal", Games = 2, Wins = 2, Draws = 0, Losses = 0, GoalsFor = 6, GoalsAgainst = 0},
            new Primers { Team = "Tottenham Hotspur", Games = 3, Wins = 2, Draws = 0, Losses = 1, GoalsFor = 5, GoalsAgainst = 1 },
            new Primers { Team = "Liverpool", Games = 2, Wins = 2, Draws = 0, Losses = 0, GoalsFor = 7, GoalsAgainst = 4}
        };

        var ranking = big4
            .OrderByDescending(t => t.Points)
            .ThenByDescending(t => t.GoalDifference)
            .ThenByDescending(t => t.GoalsFor)
            .ToList();

        Console.WriteLine("\n=== 2025/26 프리미어리그 Big4 ===");
        Console.WriteLine("{0,-4} | {1,-20} | {2,6} | {3,3} | {4,3} | {5,3} | {6,5} | {7,5} | {8,7} | {9,5}",
            "순위","팀","경기수","승","무","패","득점","실점","득실차","승점");


        for (int i = 0; i < ranking.Count; i++)
        {
            var t = ranking[i];
            Console.WriteLine("{0,-6} | {1,-21} | {2,9} | {3,4} | {4,4} | {5,4} | {6,7} | {7,7} | {8,10} | {9,5}",
                 i + 1, t.Team, t.Games, t.Wins, t.Draws, t.Losses, t.GoalsFor, t.GoalsAgainst, t.GoalDifference, t.Points
                );

        }
    }
}