using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace AreasProgram
{
	[TestFixture]
	internal class Test
	{
		[Test]
		public void CalculateCircleAreaTest()
		{
			double expectedValue = 78.54;
			double actualValue = Math.Round(Circle.Area(5),2);

			ClassicAssert.AreEqual(expectedValue, actualValue);
		}

		[Test]
		public void CalculateCirclePerimeterTest()
		{
			double expectedValue = 31.42;
			double actualValue = Math.Round(Circle.Perimeter(5), 2);

			ClassicAssert.AreEqual(expectedValue, actualValue);
		}

		[Test]
		public void CalculateTriangleAreaTest()
		{
			double expectedValue = 34.2;
			double actualValue = Math.Round(Triangle.Area(12, 6, 15), 2);

			ClassicAssert.AreEqual(expectedValue, actualValue);
		}

		[Test]
		public void CalculateTrianglePerimeterTest()
		{
			double expectedValue = 18;
			double actualValue = Math.Round(Triangle.Perimeter(5, 6, 7), 2);

			ClassicAssert.AreEqual(expectedValue, actualValue);
		}

		[Test]
		public void CalculateRectangleAreaTest()
		{
			double expectedValue = 24;
			double actualValue = Math.Round(Rectangle.Area(4, 6));

			ClassicAssert.AreEqual(expectedValue, actualValue);
		}

		[Test]
		public void CalculateRectanglePerimeterTest()
		{
			double expectedValue = 20;
			double actualValue = Math.Round(Rectangle.Perimeter(4, 6));

			ClassicAssert.AreEqual(expectedValue, actualValue);
		}

	}
}
