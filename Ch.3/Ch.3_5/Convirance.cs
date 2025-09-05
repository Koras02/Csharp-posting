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

// 공변성(out) 
public interface IProducer<out T>
{
    T Produce();
}

// Hungry  생산
public class HungryProducer : IProducer<Hungry>
{
    public Hungry Produce() => new Hungry();
}

class Program
{
    static void Main()
    {
        Console.WriteLine("[공변성(out) 테스트]");

        IProducer<Hungry> hungryFactory = new HungryProducer();
        IProducer<Human> humanFactory = hungryFactory; // ✅ 공변성 덕분에 업스케일링 가능

        Human human = humanFactory.Produce();
        human.Speak(); // 나 배고파
    }
}