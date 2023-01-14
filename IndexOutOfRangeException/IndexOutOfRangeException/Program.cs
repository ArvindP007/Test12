public class Program
{
    public static void Main(string[] args)
    {
        int[] arr = new int[5] { 10, 30, 25, 45, 65 };
        try
        {
            Console.WriteLine(arr[0]);
            Console.WriteLine(arr[1]);
            Console.WriteLine(arr[2]);
            Console.WriteLine(arr[3]);
            Console.WriteLine(arr[4]);
            Console.WriteLine(arr[5]); // throws IndexOutOfRange exception
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: {0}", ex.Message);
        }
    }

}
