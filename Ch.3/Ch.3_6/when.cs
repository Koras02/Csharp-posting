using System;

class Program
{
    static void Main()
    {
        Console.WriteLine(GetPersonType(-1));
        Console.WriteLine(GetPersonType(0));
        Console.WriteLine(GetPersonType(5));
    }

    static string GetPersonType(int number) =>
        number switch
        {
            int n when n < 0 => "궁수",
            0 => "전사",
            int n when n > 0 => "마법사",
            _ => "캐릭터 없음"
        };
}