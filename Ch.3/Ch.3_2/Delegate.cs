// 델리게이트 선언
public delegate void MyDelegate(string message);


// 클래스 선언
class Program
{
    static void Main()
    {
        // 델리게이트 변수에 메서드 등록
        MyDelegate myDel = printMessage;

        // 호출
        myDel("Hello Delegate!");
    }

    static void printMessage(string msg)
    {
        Console.WriteLine(msg);
    }
}