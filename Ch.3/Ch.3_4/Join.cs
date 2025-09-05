using System;
using System.Collections.Generic;
using System.Linq;

public class Students
{
    public string Name;
    public string Class;
    public int Score;
}

class Program
{
     static void Main()
    {
        var students = new List<Students>
        {
            new Students { Name="Kim", Class="A", Score=90},
            new Students { Name="James", Class="A", Score=95},
            new Students { Name="Park", Class="B", Score=85},
            new Students { Name="James", Class="B", Score=80},

        };

        var awards = new List<(string Name, string Award)>
        {
            ("Kim", "Math Olympiad"),
        };

        var joinQuery = from s in students
                        join a in awards on s.Name equals a.Name into gj
                        from sub in gj.DefaultIfEmpty()
                        select new { s.Name, s.Score, Award = sub.Award ?? "None" };

        Console.WriteLine("\n== 학생 & 수상 정보 ===");
        foreach (var item in joinQuery)
            Console.WriteLine($"{item.Name} - {item.Score}, Award: {item.Award}");

    }
}