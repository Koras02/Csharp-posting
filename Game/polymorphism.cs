//// Animal 클래스 정의
//public class  Animal
//{
//    // 기본 Speak 메서드 정의
//    public virtual void Speak()
//    {
//        Console.WriteLine("동물이 소리냄"); // 기본 동작
//    }
//}

//// Dog 클래스는 Animal 클래스를 상속 받아 Speak 메서드를 오버라이드함
//public class Dog : Animal
//{
//    public string Name { get; set; }
//    public override void Speak()
//    {
//        Console.WriteLine("멍멍!"); // 소리냄
//    }
//}

//// Cat 클래스는 Animal 클래스를 상속 받아 Speak 메서드를 오버라이드함
//public class Cat: Animal
//{
//    public string Name { get; set; }

//    public override void Speak()
//    {
//        Console.WriteLine($"야옹!"); // 고양이 소리
//    }
//}

//public class Program
//{
//    public static void Main(string[] args)
//    {
//        Animal myDog = new Dog { Name = "강아지" }; // Dog 객체 생성
//        Animal myCat = new Cat { Name = "고양이" }; // Cat 객체 생성

//        myCat.Speak(); // Cat 객체의 Speak 메서드 호출
//        myDog.Speak(); // Dog 객체의 Speak 메서드 호출 
//    }
//}