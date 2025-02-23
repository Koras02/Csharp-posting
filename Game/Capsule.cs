//// GameShop 클래스 정의
//public class GameShop
//{
//    private decimal balance; // 잔액을 보호하기 위한 private로 설정

//    // 예금을 위한 메서드
//    public void Deposit(decimal amount)
//    {
//        if (amount > 0)
//        {
//            // 예금액이 0보다 큰경우 잔엑애 예금액 추가
//            balance += amount;
//            Console.WriteLine($"예금액: {amount}, 현재 잔액: {balance}"); // 잔액 출력
//        }
//    }

//    // 현재 잔액 반환 메서드
//    public decimal GetBalance()
//    {
//        return balance; // 잔액 반환
//    }
//}

//public class Program
//{
//    public static void Main(string[] args)
//    {
//        GameShop account = new GameShop(); // GameShop 객체 생성
//        account.Deposit(3000); // 2000원 예금
//        Console.WriteLine($"잔액: { account.GetBalance()}원");
//    }
//}