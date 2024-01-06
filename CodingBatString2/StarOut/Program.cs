using System.Text;

namespace StarOut
{
	internal class Program
	{
		public static string StarOut(string str)
		{
			StringBuilder outputString = new StringBuilder();

			for (int character = 0; character < str.Length; character++)
			{
				if (str[character] == '*')
				{
					if (str[character + 1] == '*')
					{
						character += 2;
					}
					else
					{
						character++;
					}
				}
				else if (character == str.Length - 1)
				{
					outputString.Append(str[character]);
				}
				else if (str[character + 1] != '*')
				{
					outputString.Append(str[character]);
				}
			}

			return outputString.ToString();
		}

		static void Main(string[] args)
		{
			Console.WriteLine(StarOut("ab*cd"));
			Console.WriteLine(StarOut("ab**cd"));
			Console.WriteLine(StarOut("sm*eilly"));
		}
	}
}
