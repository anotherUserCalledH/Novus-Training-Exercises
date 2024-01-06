namespace CatDog
{
	internal class Program
	{
		public static bool ContainsString(string inputString, string testString, int currentIndex)
		{
			bool output = false;

			for (int character = 0; character < testString.Length; character++)
			{
				if (inputString[currentIndex + character] == testString[character])
				{
					output = true;
				}
				else
				{
					output = false;
					break;
				}
			}

			return output;
		}
		public static bool CatDog(string str)
		{
			int dogCount = 0;
			int catCount = 0;
			for(int character = 0; character < str.Length; character++)
			{
				if(ContainsString(str, "cat", character))
				{
					catCount++;
					character = character + 3;
				}
				if(ContainsString(str, "dog", character))
				{
					dogCount++;
					character = character + 3;
				}
			}

			return dogCount == catCount;
		}
		static void Main(string[] args)
		{
			Console.WriteLine(CatDog("catdog"));
			Console.WriteLine(CatDog("catcat"));
			Console.WriteLine(CatDog("1cat1cadodog"));
		}
	}
}
