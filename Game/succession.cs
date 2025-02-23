//using System;

//public class Character
//{
//    public string Name { get; set; } // 캐릭터 이름 속성
//    public int Health { get; set; }

//    // 캐릭터 공격 메서드
//    public void Attack()
//    {
//        Console.WriteLine($"{Name}가 공격!"); // 공격 메시지 출력
//    }
//}

//// Vehicle 클래스를 상속받는 Warrior 클래스 정의
//public class Worrior : Character
//{
//    // Worrior 클래스 전용 공격 메서드
//    public void Attack()
//    {
//        Console.WriteLine($"{Name}이 공격 자세를 취함"); // 공격 메서드 호출
//    }

//    public void Defend()
//    {
//        Console.WriteLine($"{Name}이 방어 자세를 취함"); // 방어 메서드 호출
//    }
//}

//public class Program
//{
 

//    public static void Main(string[] args)
//    {
//        Worrior worrior = new Worrior(); // Worrior 객체 생성
//        worrior.Name = "전사";
//        worrior.Attack();
//        worrior.Defend();
//    }
//}