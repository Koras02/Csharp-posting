using System;
public class Magic
{
   public static void Main()
    {
        // 캐릭터 정보 출력 
        string characterName = "마법사";
        int characterLevel = 1;

        Console.WriteLine($"캐릭터 이름: {characterName}");
        Console.WriteLine($"레벨:  {characterLevel}");

        Console.WriteLine("\n배운 마법 기술:");
        CastFireball();
        CastSpell("고블린");

        // 아이템 정보 출력
        var item = GetItem();
        var (itemName, itemPrice) = item; // 튜플 분해
        Console.WriteLine($"\n흭득한 아이템: {itemName}, 가격: {itemPrice}");
    }

    // 마법 기술 메서드
    public static void CastFireball()
    {
        Console.WriteLine("Fireball Created!");
    }

    public static void CastSpell(string enemyType)
    {
        switch(enemyType)
        {
            case "Goblin":
                CastFireball();
                break;
            case "Dragon":
                // 다른 마법 사용
                break;
            default:
                Console.WriteLine("No Speel available");
                break;
        }
    }

    // 아이템의 이름과 가격을 함께 전달

    // 아이템 정보를 분해해 각각의 값을 사용
    public static(string, int) GetItem()
    {
        return ("포션", 50);
    }
}