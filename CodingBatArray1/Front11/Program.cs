namespace Front11
{
	internal class Program
	{
		public static int[] Front11(int[] a, int[] b)
		{
			int[] output = new int[2];

			if(a.Length > 0)
			{
				output[0] = a[0];
			}
			if(b.Length > 0)
			{
				output[1] = b[0];
			}

			return output;
		}

		public static string BuildOutput(int[] a, int[] b)
		{
			return string.Join(", ", Front11(a, b));
		}
		static void Main(string[] args)
		{
			Console.WriteLine(BuildOutput(new int[] { 1, 2, 3 }, new int[] { 7, 9, 8 }));
			Console.WriteLine(BuildOutput(new int[] { 1 }, new int[] { 2 }));
			Console.WriteLine(BuildOutput(new int[] { 2, 7 }, new int[] { }));

		}
	}
}
