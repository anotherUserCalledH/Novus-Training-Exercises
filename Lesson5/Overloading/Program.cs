namespace Overloading
{
	public class Program
	{
		static void Main(string[] args)
		{
			Calculate calculate1 = new Calculate();
			int a = 1;
			int b = 2;
			float c = 3.0f;
			float d = 4.0f;
			double e = 5.0d;
			double f = 6.0d;
			String firstName = "Joe";
			String lastName = "Bloggs";
			Console.WriteLine($"Add int: {calculate1.Add(a, b)}");
			Console.WriteLine($"Add float: {calculate1.Add(c, d)}");
			Console.WriteLine($"Add double: {calculate1.Add(e, f)}");
			Console.WriteLine($"Add string: {calculate1.Add(firstName, lastName)}");
		}
	}
}
