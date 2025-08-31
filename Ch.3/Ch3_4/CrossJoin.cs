using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var colors = new[] { "Red", "Blue" };
        var sizes = new[] { "s", "M" };

        var products = from c in colors
                       from s in sizes
                       select new { Color = c, Size = s };

        Console.WriteLine("\n== 색상+사이즈 조합 ===");
        foreach (var p in products)
            Console.WriteLine($"{p.Color} - {p.Size}");
    }
}