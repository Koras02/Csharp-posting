using System;

class MyCustomException : Exception
{
    public MyCustomException(string message) : base(message) { }
}

class Program
{
    static void CheckAge(int age)
    {
        if (age < 18)
        {
            throw new MyCustomException("만 19세 미만 이상을 구매할 수 없습니다");
        }
    }

   static void Main()
    {
        try
        {
            CheckAge(15);
            Console.WriteLine("구매 가능"); // 19세 이상 일시 출력
        } 
        catch (MyCustomException e)
        {
            Console.WriteLine("사용자 정의 예외 발생:" + e.Message);
        }
    }
}