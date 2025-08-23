public delegate void myDel(string msg);

class Program
{
    static void Main()
    {
        myDel del = PrintA;
        del += PrintB;

        del("테스트");
    }

    static void PrintA(string msg) => Console.WriteLine("A: " + msg);
    static void PrintB(string msg) => Console.WriteLine("B: " + msg);

}