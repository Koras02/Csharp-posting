// 델리게이트 선언
public delegate void Notify(string msg);


class Publisher
{
    // 이벤트 선언
    public event Notify OnPublish;

    public void DoSomething()
    {
        Console.WriteLine("작업 실행 중....");
        // 이벤트 발생함
        OnPublish?.Invoke("작업 완료!");
    }
}


class Subscriber
{
    public void HandleEvent(string msg)
    {
        Console.WriteLine("구독자가 받은 메시지입니다!:" + msg);
    }
}

class Program
{
    static void Main()
    {
        Publisher pub = new Publisher();
        Subscriber sub = new Subscriber();

        // 이벤트 구독
        pub.OnPublish += sub.HandleEvent;

        pub.DoSomething();
    }
}