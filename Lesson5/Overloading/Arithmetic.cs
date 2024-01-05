using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloading
{
	public class Arithmetic
	{
		public int Add(int a, int b)
		{
			Console.WriteLine("Adding integers");
			return a + b;
		}

		public double Add(double a, double b)
		{
			Console.WriteLine("Adding doubles");
			return a + b;
		}
	}
}
