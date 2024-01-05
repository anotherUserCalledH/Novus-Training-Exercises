using System.Text;

namespace WithoutX
{
	internal class Program
	{
		public static string WithoutX(string input)
		{
			int substringStart = 0;
			int substringLength = input.Length;

			if (input[substringStart] == 'x')
			{
				substringStart++;
				substringLength--;
			}
			if (input[input.Length - 1] == 'x')
			{
				substringLength--;
			}

			return input.Substring(substringStart, substringLength);
		}
		static void Main(string[] args)
		{
			Console.WriteLine(WithoutX("xHix"));
			Console.WriteLine(WithoutX("Hi"));
			Console.WriteLine(WithoutX("Hxix"));
		}
	}
}
