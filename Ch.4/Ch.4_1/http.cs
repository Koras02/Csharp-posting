using System;
using System.Net.Http;
using System.Threading.Tasks;

public class Program
{
    public static async Task Main()
    {
        HttpClient client = new HttpClient();
        string result = await client.GetStringAsync("https://example.com/");
        Console.WriteLine(result.Substring(0, 100)); // 처음 100 글자 출력
    }
}