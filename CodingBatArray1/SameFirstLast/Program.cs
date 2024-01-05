namespace SameFirstLast
{
	internal class Program
	{
		public static bool SameFirstLast(int[] nums)
		{
			bool output = false;

			if(nums.Length >= 1)
			{
				if (nums[0] == nums[nums.Length - 1])
				{
					output = true;
				}
			}

			return output;
		}
		static void Main(string[] args)
		{
			Console.WriteLine(SameFirstLast(new int[3] { 1, 2, 3 }));
			Console.WriteLine(SameFirstLast(new int[4] { 1, 2, 3, 1 }));
			Console.WriteLine(SameFirstLast(new int[3] { 1, 2, 1 }));
		}
	}
}
