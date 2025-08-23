class FuncDel
{
    static void Main()
    {
        Func<int, int, int> add = (a, b) => a + b;
        Console.WriteLine(add);

        Func<string, int> strLength = s => s.Length;
        Console.WriteLine(strLength("Hello, World!")); // 13
    }
}