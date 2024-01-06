namespace SquirrelPlay
{
	internal class Program
	{
		public static bool SquirrelPlay(int temp, bool isSummer)
		{
			bool output = false;

			if(temp > 60)
			{
				if(isSummer & temp <= 100)
				{
					output = true;
				}
				else if(temp <= 90)
				{
					output = true;
				}
			}

			return output;
		}

		static void Main(string[] args)
		{
			Console.WriteLine(SquirrelPlay(70, false));
			Console.WriteLine(SquirrelPlay(95, false));
			Console.WriteLine(SquirrelPlay(95, true));
		}
	}
}
