namespace Interfaces
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Rectangle rectangle1 = new Rectangle();
			Circle circle1 = new Circle();


			double a = 10.0;
			double b = 20.0;
			double c = 1.0;
			double area = 0.0;
			double perimeter = 0.0;
			rectangle1.Height = a;
			rectangle1.Width = b;
			circle1.Radius = c;
			Triangle triangle1 = new Triangle(50, 30, 40);


			perimeter = rectangle1.Perimeter();
			area = rectangle1.Area();
			Console.WriteLine($"Area of rectangle is: {area}");
			Console.WriteLine($"Perimeter of rectangle is: {perimeter}");
			Console.WriteLine();
			perimeter = circle1.Perimeter();
			area = circle1.Area();
			Console.WriteLine($"Area of circle is: {area}");
			Console.WriteLine($"Perimeter of circle is: {perimeter}");
			perimeter = triangle1.Perimeter();
			area = triangle1.Area();
			Console.WriteLine($"Area of triangle is: {area}");
			Console.WriteLine($"Perimeter of triangle is: {perimeter}");


		}
	}
}
