namespace Front11
{
	internal class Program
	{
		public static int[] Front11(int[] a, int[] b)
		{
			int[] output;

			if(a.Length < 1)
			{
				output = new int[] { b[0]};
			}
			else if(b.Length < 1)
			{
				output = new int[] { a[0] };
			}
			else
			{
				output = new int[2];
				output[0] = a[0];
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
			Console.WriteLine(BuildOutput(new int[] { 1, 7 }, new int[] { }));

		}
	}
}
