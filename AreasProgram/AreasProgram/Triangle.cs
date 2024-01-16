using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreasProgram
{
	internal class Triangle
	{
		public static bool TriangleIsValid(double sideA, double sideB, double sideC)
		{
			bool isValid = false;

			if (sideA + sideB > sideC)
			{
				isValid = true;
			}

			return isValid;
		}
		public static double Area(double sideA, double sideB, double sideC)
		{
			double area = -1;

			if (TriangleIsValid(sideA, sideB, sideC))
			{
				double semiPerimeter = Perimeter(sideA, sideB, sideC) / 2.0;
				area = Math.Sqrt(semiPerimeter * (semiPerimeter - sideA) * (semiPerimeter - sideB) * (semiPerimeter - sideC));
			}

			return area;
		}
		public static double Perimeter(double sideA, double sideB, double sideC)
		{
			double perimeter = -1;

			if (TriangleIsValid(sideA, sideB, sideC))
			{
				perimeter = sideA + sideB + sideC;
			}

			return perimeter;
		}
	}
}
