
using System;

class Finally
{
    static void Main()
    {
        try
        {
            System.IO.StreamReader sr = new System.IO.StreamReader("test.txt");
            Console.WriteLine(sr.ReadToEnd());
            sr.Close();
        }
        catch (Exception e)
        {
            Console.WriteLine("파일 읽기 오류: " + e.Message);
        }
        finally
        {
            Console.WriteLine("파일 처리 종료 (자원 해제)");
        }

    }
}