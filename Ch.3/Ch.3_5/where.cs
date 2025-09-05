public class Human
{
    public virtual void Speak() => Console.WriteLine("나는 인간이야");
}

public class Hungry : Human
{
    public override void Speak() => Console.WriteLine("나 배고파");
}

public class Sleep : Human
{
    public override void Speak() => Console.WriteLine("나 졸려");
}

// 제네릭 클래스에 제약 조건 추가
public class Action<T> where T : Human, new()
{
    public void MakeSound()
    {
        T human = new T(); // new() 연산자로 객체 생성 가능
        human.Speak(); // Human 제약 덕분에 Speak 호출 가능
    }
}


public class Where
{
    static void Main(string[] args)
    {
        var human1 = new Action<Hungry>();
        human1.MakeSound(); // 나 배고파

        var human2 = new Action<Sleep>();
        human2.MakeSound(); // 나 졸려
    }
}
