namespace Functionblock
{
	public class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Enter a number: ");
			double input = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine(CalculateSquare(input));
		}

		public static double CalculateSquare(double input)
		{
			return input * input;
		}
	}
}
