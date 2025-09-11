using System;
using System.Threading.Tasks;

public class Program
{
    public static async Task<int> GetNumberAsync()
    {
        await Task.Delay(1000); // 1초 대기 (비동기)
        return 42;
    }

    public static async Task ExampleAsync()
    {
        Console.WriteLine("작업 시작");
        int result = await GetNumberAsync(); // 이곳에서 비동기 대기
        Console.WriteLine($"결과: {result}");
    }

    public static async Task Main()
    {
        await ExampleAsync();
    }
}