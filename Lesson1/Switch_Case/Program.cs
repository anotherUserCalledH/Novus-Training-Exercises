namespace Switch_Case
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int x = 0;
			Console.Write("Enter a positive number: ");
			x = Convert.ToInt16(Console.ReadLine());
			if(x >= 0)
			{
				switch(x)
				{
					case 0:
						Console.WriteLine("The value of x is zero");
						break;
					case 1:
						Console.WriteLine("The value of x is one");
						break;
					case 2:
						Console.WriteLine("The value of x is two");
						break;
					case 3:
						Console.WriteLine("The value of x is three");
						break;
					case 4:
						Console.WriteLine("The value of x is four");
						break;
					case 5:
						Console.WriteLine("The value of x is five");
						break;
					default:
						Console.WriteLine("The value of x is greater than five");
						break;
				}
			}
			Console.WriteLine("Hello, World!");
		}
	}
}
