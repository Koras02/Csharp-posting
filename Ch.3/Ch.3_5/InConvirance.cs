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


// 반공변성(in) 인터페이스
public interface IConsumer<in T>
{
    void Consume(T item);
}

public class HumanConsumer : IConsumer<Human>
{
    public void Consume(Human a) => a.Speak();
}

class Program
{
    static void Main()
    {
        Console.WriteLine("[반공변성(in) 테스트]");

        IConsumer<Human> humanConsumer = new HumanConsumer();

        IConsumer<Hungry> hungryConsumer = humanConsumer;
        IConsumer<Sleep> sleepConsumer = humanConsumer;

        hungryConsumer.Consume(new Hungry()); // 출력: 나 배고파
        sleepConsumer.Consume(new Sleep()); // 출력: 나 졸려
    }
}