using System.Text;

namespace WithoutX2
{
	internal class Program
	{
		public static string WithoutX2(string input)
		{
			StringBuilder output = new StringBuilder(input);

			if (input[0] == 'x')
			{
				output.Remove(0, 1);
			}
			if (input[1] == 'x')
			{
				output.Remove(1, 1);
			}

			return output.ToString();
		}
		static void Main(string[] args)
		{
			Console.WriteLine(WithoutX2("xHi"));
			Console.WriteLine(WithoutX2("Hxi"));
			Console.WriteLine(WithoutX2("Hi"));
		}
	}
}
