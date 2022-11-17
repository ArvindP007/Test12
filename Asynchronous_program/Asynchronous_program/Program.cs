class Program
{
    public static async Task Main(string[] args)
    {
        LongProcess();

        ShortProcess();

        Console.ReadKey();
    }

    public static async void LongProcess()
    {
        Console.WriteLine("LongProcess Started");

        await Task.Delay(4000); // hold execution for 4 seconds

        Console.WriteLine("LongProcess Completed");

    }

    public static void ShortProcess()
    {
        Console.WriteLine("ShortProcess Started");
        //do something here

        Console.WriteLine("ShortProcess Completed");
    }
}




