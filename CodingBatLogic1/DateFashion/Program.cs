namespace DateFashion
{
	internal class Program
	{
		public const int NO = 0, MAYBE = 1, YES = 2;

		public static int DateFashion(int you, int date)
		{
			int result = 0;

			if(you >= 8 || date >= 8)
			{
				result = YES;
			}
			else if(you > 2 && date > 2)
			{
				result = MAYBE;
			}
			else
			{
				result = NO;
			}

			return result;
		}
		static void Main(string[] args)
		{
			Console.WriteLine(DateFashion(5, 10));
			Console.WriteLine(DateFashion(5, 2));
			Console.WriteLine(DateFashion(5, 5));
		}
	}
}
