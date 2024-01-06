namespace BlueTicket
{
	internal class Program
	{
		public static int BlueTicket(int a, int b, int c)
		{
			int ab = a + b;
			int bc = b + c;
			int ac = a + c;

			int result = 0;
			if(ab == 10 || bc == 10 || ac == 10)
			{
				result = 10;
			}
			else if(ab - bc == 10 || ab - ac == 10)
			{
				result = 5;
			}

			return result;
		}

		static void Main(string[] args)
		{
			Console.WriteLine(BlueTicket(9, 1, 0));
			Console.WriteLine(BlueTicket(9, 2, 0));
			Console.WriteLine(BlueTicket(6, 1, 4));
		}
	}
}
