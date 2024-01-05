namespace Overriding
{
	public class Program
	{
		static void Main(string[] args)
		{
			AreaOfShapes areaSquare = new AreaOfShapes();
			double a = 10.0d;
			double b = 10.0d;
			double area = 0.0;
			area = areaSquare.Square(a, b);
			Console.WriteLine($"Area of square: {area}");
		}
	}
}
