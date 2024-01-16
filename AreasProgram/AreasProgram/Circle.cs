using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreasProgram
{
	internal class Circle
	{
		public static double Area(double radius)
		{
			return Math.PI * Math.Pow(radius, 2);
		}

		public static double Perimeter(double radius)
		{
			return Math.PI * radius * 2;
		}
	}
}
