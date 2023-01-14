using System;
public class Program
{
    public static void Main()
    {
        DateTime dt1 = new DateTime(2022, 12, 8, 14, 45, 0);
        //DateTime dt1 = new DateTime(Year, Month, Date, Hours, Minutes, Seconds);

        //Display date using 12 - hour clock format
        Console.WriteLine("Complete date: " + dt1.ToString());
        //(Same as above) Console.WriteLine("Complete date: " + dt1);

        // Get date-only portion of date, without its time.
        DateTime dateOnly = dt1.Date;

        Console.WriteLine("Short Date: " + dateOnly.ToString("d"));

        Console.WriteLine("Display date using 24-hour clock format:");

        Console.WriteLine(dt1.ToString("g"));
        Console.WriteLine(dt1.ToString("MM/dd/yyyy HH:mm"));
    }
}
