using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
	internal class Triangle : IShape
	{
		public Triangle(double Side1, double Side2, double Side3)
		{
			this.Side1 = Side1;
			this.Side2 = Side2;
			this.Side3 = Side3;
		}
		public double Side1 { get; set; }
		public double Side2 { get; set; }
		public double Side3 { get; set; }

		public double Area()
		{
			double semiPerimeter = Perimeter() / 2.0;
			return Math.Sqrt(semiPerimeter * (semiPerimeter - Side1) * (semiPerimeter - Side2) * (semiPerimeter - Side3));
		}
		public double Perimeter()
		{
			return Side1 + Side2 + Side3;
		}
	}
}
