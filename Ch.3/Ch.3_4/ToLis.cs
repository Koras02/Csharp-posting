using System;
using System.Linq;

class Program
{
  static void Main()
    {
        var numbers = Enumerable.Range(1, 10);

        // 지연 실행
        var query = numbers.Where(n => n > 5);

        // 즉시 실행
        var list = query.ToList();

        Console.WriteLine("\n=== 지연 실행 vs 즉시 실행 ===");
        Console.WriteLine("Query 결과: " + string.Join(",", query));
        Console.WriteLine("List 결과: " + string.Join(",", list));
    }
}