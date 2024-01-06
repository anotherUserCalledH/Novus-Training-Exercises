using System.Text;

namespace PlusOut
{
	internal class Program
	{
		public static bool ContainsString(string inputString, string testString, int currentIndex)
		{
			bool output = false;

			for(int character = 0; character < testString.Length; character++)
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

		public static String PlusOut(string inputString, string testString)
		{
			StringBuilder outputString = new StringBuilder();

			for(int character = 0; character < inputString.Length; character++)
			{
				if(ContainsString(inputString, testString, character))
				{
					outputString.Append(testString);
					character += testString.Length - 1;
				}
				else
				{
					outputString.Append("+");
				}
			}

			return outputString.ToString();
		}
		static void Main(string[] args)
		{
			Console.WriteLine(PlusOut("12xy34", "xy"));
			Console.WriteLine(PlusOut("12xy34", "1"));
			Console.WriteLine(PlusOut("12xy34xyabcxy", "xy"));
		}
	}
}
