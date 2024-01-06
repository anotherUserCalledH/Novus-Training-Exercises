namespace SumLimit
{
	internal class Program
	{
		public static int SumLimit(int a, int b)
		{
			int sum = a + b;
			if(sum.ToString().Length > a.ToString().Length)
			{
				sum = a;
			}

			return sum;
		}
		static void Main(string[] args)
		{
			Console.WriteLine(SumLimit(2, 3));
			Console.WriteLine(SumLimit(8, 3));
			Console.WriteLine(SumLimit(8, 1));
		}
	}
}
