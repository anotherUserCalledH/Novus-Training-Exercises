namespace Make2
{
	internal class Program
	{
		public static int[] Make2(int[] a, int[] b)
		{
			int[] output = new int[2];

			for(int index = 0; index < 2; index++)
			{
				if(index <  a.Length)
				{
					output[index] = a[index];
				}
				else if(index < b.Length)
				{
					output[index] = b[index - a.Length];
				}	
			}

			return output;
		}
		static void Main(string[] args)
		{
			Console.WriteLine(string.Join(", ", Make2(new int[2] { 4, 5 }, new int[3] {1, 2, 3})));
			Console.WriteLine(string.Join(", ", Make2(new int[1] { 4 }, new int[3] { 1, 2, 3 })));
			Console.WriteLine(string.Join(", ", Make2(new int[0], new int[2] { 1, 2 })));
		}
	}
}
