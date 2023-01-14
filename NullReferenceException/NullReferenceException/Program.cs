public class Program
{
	public static void Main()
	{
		Student std = null;
		Display(std);

		std = new Student() { FirstName = "Arvind", LastName = "Patkal" };
		Display(std);
	}

	public static void Display(Student std)
	{
		Console.WriteLine("Student Info:");
		Console.WriteLine(std?.FirstName); //use ?. operator 
		Console.WriteLine(std?.LastName); // use ?. operator
	}
}

public class Student
{
	public int Id { get; set; }
	public string FirstName { get; set; }
	public string LastName { get; set; }
}