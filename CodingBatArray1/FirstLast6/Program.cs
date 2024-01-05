namespace FirstLast6
{
	public class Program
	{
		public static bool FirstLast6(int[] nums)
		{
			bool output = false;

			if (nums[0] == 6)
			{
				output = true;
			}
			else if (nums[nums.Length - 1] == 6)
			{
				output = true;
			}

			return output;
		}
		static void Main(string[] args)
		{
			Console.WriteLine(FirstLast6(new int[3] { 1, 2, 6 }));
			Console.WriteLine(FirstLast6(new int[4] { 6, 1, 2, 3 }));
			Console.WriteLine(FirstLast6(new int[5] { 13, 6, 1, 2, 3 }));
		}
	}
}
