using System.Text;

namespace WordEnds
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

		public static string WordEnds(string inputString, string testString)
		{
			StringBuilder outputString = new StringBuilder();

			for(int character = 0; character < inputString.Length; character++)
			{
				if(ContainsString(inputString, testString, character))
				{
					int beforeChar = character - 1;
					if(beforeChar > 0) { outputString.Append(inputString[beforeChar]); }
					int afterChar = character + testString.Length;
					if(afterChar < inputString.Length) { outputString.Append(inputString[afterChar]); }
					character += testString.Length - 1;
				}
			}

			return outputString.ToString();
		}
		static void Main(string[] args)
		{
			Console.WriteLine(WordEnds("abcXY123XYijk", "XY"));
			Console.WriteLine(WordEnds("XY123XY", "XY"));
			Console.WriteLine(WordEnds("XY1XY", "XY"));
		}
	}
}
