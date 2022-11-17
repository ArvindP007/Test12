class Program
{
    /*
    public static async Task Main(string[] args)
    {
        Task<int> result = LongProcess();

        ShortProcess();

        var val = await result; // wait untile get the return value

        ShortProcess();

        Console.WriteLine("Result: {0}", val);

        Console.ReadKey();
    }

    static async Task<int> LongProcess()
    {
        Console.WriteLine("LongProcess Started");

        await Task.Delay(4000); // hold execution for 4 seconds

        Console.WriteLine("LongProcess Completed");

        return 10;
    }

    static void ShortProcess()
    {
        Console.WriteLine("ShortProcess Started");

        //do something here

        Console.WriteLine("ShortProcess Completed");
    }
    */

    public static async Task Main(string[] args)
    {
        Task<int> result1 = LongProcess1();
        Task<int> result2 = LongProcess2();

        //do something here
        Console.WriteLine("After two long processes.");

        int val2 = await result2; // wait untile get the return value
        DisplayResult(val2);

        int val1 = await result1; // wait untile get the return value
        DisplayResult(val1);

        Console.ReadKey();
    }

    static async Task<int> LongProcess1()
    {
        Console.WriteLine("LongProcess 1 Started");

        await Task.Delay(4000); // hold execution for 4 seconds

        Console.WriteLine("LongProcess 1 Completed");

        return 10;
    }

    static async Task<int> LongProcess2()
    {
        Console.WriteLine("LongProcess 2 Started");

        await Task.Delay(2000); // hold execution for 4 seconds

        Console.WriteLine("LongProcess 2 Completed");

        return 20;
    }

    static void DisplayResult(int val)
    {
        Console.WriteLine(val);
    }
}