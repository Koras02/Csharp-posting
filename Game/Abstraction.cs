// 추상 클래스 GameCharacter 정의
public abstract class GameCharacter
{
    public abstract void Move(); // 이동 메서드 추상
}

// Hero 클래스는 GameCharacter를 상속 Move 메서드 구현
public class Hero : GameCharacter
{
    public override void Move()
    {
        Console.WriteLine("캐릭터가 앞으로 이동"); // 이동 메시지
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        GameCharacter hero = new Hero(); // Hero 객체 생성
        hero.Move();
    }
}