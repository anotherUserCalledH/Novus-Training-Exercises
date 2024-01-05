namespace HelloName
{
	internal class Program
	{
		public static string HelloName(string? name)
		{
			return "Hello " + name;
		}
		static void Main(string[] args)
		{
			Console.WriteLine("Enter a name:");
			string? name = Console.ReadLine();
			Console.WriteLine(HelloName(name));
		}
	}
}
