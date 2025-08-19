class Catch
{
    static void Main()
    {
        try 
        {
            int[] arr = { 1, 2, 3 };
            Console.WriteLine(arr[2]); // ✅ 가능 - 2번쨰 인덱스 - 3

            Console.WriteLine(arr[5]); // IndexOutOfRangeExecption 발생
        }
        catch (IndexOutOfRangeException e)
        {
            Console.WriteLine("배열 인덱스가 잘못되었습니다."); 
        }
        catch (Exception e)
        {
            Console.WriteLine("예상치 못한 오류: " + e.Message);
        }
    }
}