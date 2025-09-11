using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("작업 시작");
        await Task.Delay(1000); // 1초 대기 (비동기)
        Console.WriteLine("작업 완료");
    }
}