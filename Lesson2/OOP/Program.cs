namespace OOP
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Calculator calc = new Calculator();
			int x = 3;
			int y = 5;
			int sum = 0;
			sum = calc.Add(x, y);

			Console.WriteLine($"The numbers are {x} and {y}");
			Console.WriteLine($"The sum is: {calc.Add(x,y)}");
			Console.WriteLine($"The difference is: {calc.Subtract(x, y)}");
			Console.WriteLine($"The product is: {calc.Multiply(x, y)}");
			Console.WriteLine($"The quotient is: {calc.Divide(x,y)}");

		}
	}
}
