using System;

class Program
{
    static void Main()
    {
        object value = 123;

        if (value is not string)
        {
            Console.WriteLine("문자열이 아님");
        }
    }
}