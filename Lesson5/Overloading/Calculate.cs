using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloading
{
	public class Calculate : Arithmetic
	{
		public float Add(float a, float b)
		{
			Console.WriteLine("Adding floats");
			return a + b;
		}

		public string Add(string a, string b)
		{
			Console.WriteLine("Adding strings");
			return "Hello " + a + " " + b;
		}
	}
}
