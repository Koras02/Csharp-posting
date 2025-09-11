using System;
using System.Threading.Tasks;

public class Program
{
    public static async Task<int> GetNumberAsync()
    {
        await Task.Delay(1000);
        return 42;
    }

    public static async Task Main()
    {
        Task<int> t1 = GetNumberAsync();
        Task<int> t2 = GetNumberAsync();

        int[] results = await Task.WhenAll(t1, t2);
        Console.WriteLine($"결과: {results[0]}, {results[1]}");
    }
}