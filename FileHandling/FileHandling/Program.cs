using System;
using System.IO;


class Program
{
	public static void Main()
	{
		string fileName = @"mytest.txt";
		string[] ArrLines;
		int n, i, l, m = 1;

		Console.WriteLine("\n Read last n number of lines from a file  :");
		Console.WriteLine("-----------------------------------------------\n");

		if (File.Exists(fileName))
		{
			File.Delete(fileName);
		}
		Console.WriteLine(" Input number of lines to write in the file  :");
		n = Convert.ToInt32(Console.ReadLine());
		ArrLines = new string[n];
		Console.WriteLine(" Input {0} strings below :\n", n);
		for (i = 0; i < n; i++)
		{
			Console.Write(" Input line {0} : ", i + 1);
			ArrLines[i] = Console.ReadLine();
		}
		System.IO.File.WriteAllLines(fileName, ArrLines);

		Console.Write("\n Input last how many numbers of lines you want to display  :");
		l = Convert.ToInt32(Console.ReadLine());
		m = l;
		if (l >= 1 && l <= n)
		{
			Console.WriteLine("\n The content of the last {0} lines of the file {1} is : \n", l, fileName);
			if (File.Exists(fileName))
			{
				for (i = n - l; i < n; i++)
				{
					string[] lines = File.ReadAllLines(fileName);
					Console.WriteLine(" The last no {0} line is : {1} \n", m, lines[i]);
					m--;
				}
			}
		}
		else
		{
			Console.WriteLine(" Please input the correct line no.");
		}

		Console.WriteLine();
	}
}
