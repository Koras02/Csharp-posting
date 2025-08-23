class LinQ
{
    static void Main()
    {
        var numbers = new List<int> { 1, 2, 3, 4, 5 };

        // Func 사용
        var squares = numbers.Select(x => x * x);
        foreach (var n in squares)
            Console.WriteLine(n);

        // Action
        numbers.ForEach(n => Console.WriteLine($"값: {n}"));
    }
}