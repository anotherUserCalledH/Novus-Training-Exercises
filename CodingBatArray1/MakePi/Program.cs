namespace MakePi
{
	internal class Program
	{
		public static int[] MakePi()
		{
			int intPI = (int) Math.Truncate(Math.PI * 100);
			string stringPI = intPI.ToString();
			int[] output = new int[3];

			for(int loopVar = 0; loopVar < 3; loopVar++)
			{
				output[loopVar] = (int) Char.GetNumericValue(stringPI[loopVar]);
			}

			return output;
		}

		static void Main(string[] args)
		{
			Console.WriteLine(string.Join(", ", MakePi()));
		}
	}
}
