using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.WriteLine("숫자를 입력하세요:");
            int num = int.Parse(Console.ReadLine()); // 예외 발생 가능
            Console.WriteLine($"입력한 숫자: {num}");
        }
   
        catch (FormatException e)
        {
            Console.WriteLine("숫자 형식이 아닙니다");

        }
        catch (OverflowException e) {
            Console.WriteLine("숫자가 너무 큽니다!");
        }
        finally
        {
            Console.WriteLine("프로그램 종료 전 반드 시 실행됩니다");
        }
    }
}