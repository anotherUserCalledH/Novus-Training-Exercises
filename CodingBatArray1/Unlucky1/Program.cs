namespace Unlucky1
{
	internal class Program
	{
		public static bool IsUnlucky(int[] nums, int index)
		{
			return (nums[index] == 1 && nums[index + 1] == 3);
		}
		public static bool Unlucky1(int[] nums)
		{
			int firstIndex = 0;
			int secondIndex = 1;
			int penultIndex = nums.Length - 2;

			bool output = false;

			if(IsUnlucky(nums, firstIndex) || IsUnlucky(nums, penultIndex) || IsUnlucky(nums, secondIndex))
			{
				output = true;
			}

			return output;
		}
		static void Main(string[] args)
		{
			Console.WriteLine(Unlucky1(new int[4] { 1, 3, 4, 5 }));
			Console.WriteLine(Unlucky1(new int[5] { 2, 1, 3, 4, 5 }));
			Console.WriteLine(Unlucky1(new int[3] { 1, 1, 1 }));
		}
	}
}
