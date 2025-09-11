using System;
using System.Threading.Tasks;

public class Program
{ 
  // Task<T> 사용 
  public static async Task<int> ComputeTaskAsync()
  {
        await Task.Delay(500); // 비동기 대기
        return 100;
  }
  
  // ValueTask<T> 사용 
  public static async ValueTask<int> ComputeValueTaskAsync(bool quick)
  {
        if (quick)
            return 50; // 즉시 완료되는 값
        await Task.Delay(500);
        return 150;
  }

  public static async Task Main()
  {
        int taskResult = await ComputeTaskAsync();
        Console.WriteLine($"Task 결과: {taskResult}");

        int valueTaskResult = await ComputeValueTaskAsync(true);
        Console.WriteLine($"valueTask 결과: {valueTaskResult}");
  }
   
}