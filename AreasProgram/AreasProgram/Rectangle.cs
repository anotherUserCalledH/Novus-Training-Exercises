using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreasProgram
{
	internal class Rectangle
	{
		public static double Area(double height, double width)
		{
			return height * width;
		}

		public static double Perimeter(double height, double width)
		{
			return (2 * height) + (2 * width);
		}
	}
}
