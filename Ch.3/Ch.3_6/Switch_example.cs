using System;

class Program
{
    static void Main()
    {
        object obj = 5.54;

        // switch 표현식 호출
        string typeDescription = GetTypeDescription(obj);
        Console.WriteLine(typeDescription);
    }

    // switch 표현식 method
    static string GetTypeDescription(object obj) =>
     obj switch
     {
         int i => $"정수: {i}",
         string s => $"문자열: {s}",
         double c => $"소수점: {c}",
         _ => "알 수 없는 타입입니다."
     };
}