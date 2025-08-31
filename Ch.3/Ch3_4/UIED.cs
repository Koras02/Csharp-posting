using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var list1 = new[] { 1, 2, 3, 4 };
        var list2 = new[] { 3, 4, 5, 6};

        Console.WriteLine("\n=== 집합 연산 ===");
        Console.WriteLine("합집합: " + string.Join(",", list1.Union(list2)));
        Console.WriteLine("교집합: " + string.Join(",", list1.Intersect(list2)));
        Console.WriteLine("차집합: " + string.Join(",", list1.Except(list2)));
        Console.WriteLine("중복 제거: " + string.Join(",", new[] { 1, 2, 2, 3, 4, 4 }.Distinct()));
    }
}