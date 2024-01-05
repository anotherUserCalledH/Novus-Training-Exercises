namespace ForEach
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] number = { 2, 4, 6, 8, 10 };
			foreach(int val in number){ Console.WriteLine(val); }
			Console.WriteLine("Hello, World!");
		}
	}
}