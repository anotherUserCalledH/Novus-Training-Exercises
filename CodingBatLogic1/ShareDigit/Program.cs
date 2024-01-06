namespace ShareDigit
{
	internal class Program
	{
		public static bool ShareDigit(int a, int b)
		{
			int aFirstDigit = a / 10;
			int bFirstDigit = b / 10;
			int aSecondDigit = a % 10;
			int bSecondDigit = b % 10;

			bool output = false;

			if(aFirstDigit == bFirstDigit || aFirstDigit == bSecondDigit)
			{
				output = true;
			}
			else if(aSecondDigit == bFirstDigit || aSecondDigit == bSecondDigit)
			{
				output = true;
			}

			return output;

		}

		static void Main(string[] args)
		{
			Console.WriteLine(ShareDigit(12, 23));
			Console.WriteLine(ShareDigit(12, 43));
			Console.WriteLine(ShareDigit(12, 44));
		}
	}
}
