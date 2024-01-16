using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShapeGUI
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void calculateAreaSquare_Click(object sender, EventArgs e)
		{
			try
			{
				float width = float.Parse(textBoxSquareWidth.Text);
				float height = float.Parse(textBoxSquareHeight.Text);
				float area = width * height;

				string message = "The area is: " + area.ToString();
				MessageBox.Show(message);
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
		}

		private void calculatePerimeterSquare_Click(object sender, EventArgs e)
		{
			try
			{
				double width = double.Parse(textBoxSquareWidth.Text);
				double height = double.Parse(textBoxSquareHeight.Text);
				double perimeter = (2 * height) + (2 * width);

				string message = "The perimeter is: " + perimeter.ToString();
				MessageBox.Show(message);
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
		}

		private void calculateAreaCircle_Click(object sender, EventArgs e)
		{
			try
			{
				double radius = double.Parse(textBoxCircleRadius.Text);
				double area = Math.PI * Math.Pow(radius, 2);

				string message = "The area is: " + area.ToString();
				MessageBox.Show(message);
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
		}

		private void calculatePerimeterCircle_Click(object sender, EventArgs e)
		{
			try
			{
				double radius = double.Parse(textBoxCircleRadius.Text);
				double perimeter = Math.PI * radius * 2;

				string message = "The area is: " + perimeter.ToString();
				MessageBox.Show(message);
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
		}

		public static bool TriangleIsValid(double sideA, double sideB, double sideC)
		{
			bool isValid = false;

			if (sideA + sideB > sideC)
			{
				isValid = true;
			}

			return isValid;
		}

		public static double TrianglePerimeter(double sideA, double sideB, double sideC)
		{
			double perimeter = -1;

			if (TriangleIsValid(sideA, sideB, sideC))
			{
				perimeter = sideA + sideB + sideC;
			}

			return perimeter;
		}

		private void calculateAreaTriangle_Click(object sender, EventArgs e)
		{
			try
			{
				double sideA = double.Parse(textBoxSideA.Text);
				double sideB = double.Parse(textBoxSideB.Text);
				double sideC = double.Parse(textBoxSideC.Text);
				double area = 0;

				if (TriangleIsValid(sideA, sideB, sideC))
				{
					double semiPerimeter = TrianglePerimeter(sideA, sideB, sideC) / 2.0;
					area = Math.Sqrt(semiPerimeter * (semiPerimeter - sideA) * (semiPerimeter - sideB) * (semiPerimeter - sideC));
				}

				string message = "The area is: " + area.ToString();
				MessageBox.Show(message);
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
		}

		private void calculatePerimeterTriangle_Click(object sender, EventArgs e)
		{
			try
			{
				double sideA = double.Parse(textBoxSideA.Text);
				double sideB = double.Parse(textBoxSideB.Text);
				double sideC = double.Parse(textBoxSideC.Text);
				double perimeter = 0;

				if (TriangleIsValid(sideA, sideB, sideC))
				{
					perimeter = sideA + sideB + sideC;
				}

				string message = "The perimeter is: " + perimeter.ToString();
				MessageBox.Show(message);
			}
			catch(Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
		}
	}
}
