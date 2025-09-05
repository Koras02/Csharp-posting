public class Students
{
    public string Name;
    public string Class;
    public int Speed;



    class Program
    {
        static void Main()
        {
            var students = new List<Students>
        {
            new Students { Name="Kim", Class="A", Speed=80},
            new Students { Name="James", Class="A", Speed=80},
            new Students { Name="Park", Class="B", Speed=90},
            new Students { Name="James", Class="B", Speed=75}
        };

            var query = from s in students
                        let grade = s.Speed >= 90 ? "과속" : "통과"
                        select new { s.Name, s.Speed, Grade = grade };
            Console.WriteLine("\n==== 전방에 80km 과속단속 구간입니다. ===");
            foreach (var s in query)
                Console.WriteLine($"{s.Name} - {s.Speed} - {s.Grade}");
        }
    }
}