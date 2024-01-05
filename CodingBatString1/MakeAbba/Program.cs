namespace MakeAbba
{
	internal class Program
	{
		public static string MakeAbba(String a, String b)
		{
			return a + b + b + a;
		}
		static void Main(string[] args)
		{
			Console.WriteLine("Enter a word:");
			string a = Console.ReadLine();
			Console.WriteLine("Enter another word:");
			string b = Console.ReadLine();
			Console.WriteLine(MakeAbba(a, b));
		}
	}
}
