class Lamda
{
    static void Main()
    {
        // Normal Method
        int Square(int x)
        {
            return x * x;
        }

            // Lamda Method
            Func<int, int> square = x => x * x;

        Console.WriteLine(square(5));
    }

}