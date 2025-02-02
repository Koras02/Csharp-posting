
//public record Person(string FirstName, string LastName)
//{
//    public required string[] PhonNumbers { get; init; }
//}
//public static class Program
//{
//    public static void Main()
//    {
//        Person person1 = new("Nancy", "Davolio") { PhonNumbers = new string[1] };
//        Console.WriteLine(person1);

//        Person person2 = person1 with { FirstName = "John" };
//        Console.WriteLine(person2);
//        Console.WriteLine(person1 == person2);

//        person2 = person1 with { PhonNumbers = new string[1] };
//        Console.WriteLine(person2);
//        Console.WriteLine(person1 == person2);

//        person2 = person1 with { };
//        Console.WriteLine(person1 == person2);
//    }
//}