using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overriding
{
	public class AreaOfSquare
	{
		public virtual double Square(double a, double b)
		{
			Console.WriteLine("Calculate area of square power a^2");
			return Math.Pow(a, 2);
		}
	}
}
