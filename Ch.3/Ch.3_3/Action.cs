class Action
{
    static void Main()
    {
        Action<string> print = msg => Console.WriteLine(msg);
        print("Hello!");

        Action<int, int> multiply = (a, b) => Console.WriteLine(a * b);
        multiply(4, 5); // 20
    }
}