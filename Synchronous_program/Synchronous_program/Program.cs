class Program
{
    public static void Main(string[] args)
    {
        LongProcess();

        ShortProcess();
    }
    public static void LongProcess()
    {
        Console.WriteLine("LongProcess Started: Wait for 4 seconds");

        //some code that takes long execution time 
        System.Threading.Thread.Sleep(4000); // hold execution for 4 seconds

        Console.WriteLine("LongProcess Completed");
    }
    static void ShortProcess()
    {
        Console.WriteLine("ShortProcess Started");

        //do something here

        Console.WriteLine("ShortProcess Completed");
    }
}