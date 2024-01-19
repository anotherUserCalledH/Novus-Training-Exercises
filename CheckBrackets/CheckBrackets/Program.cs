using System.Collections;

namespace CheckBrackets
{
	internal class Program
	{
		public static bool IsOpeningBracket(char bracket)
		{
			return (bracket == '[' || bracket == '{' || bracket == '(');
		}

		public static bool CheckBracketsMatch(char openingBracket, char closingBracket)
		{
			bool bracketsMatch = false;

			switch (openingBracket)
			{
				case '[':
					if (closingBracket == ']') { bracketsMatch = true; }
					break;
				case '{':
					if (closingBracket == '}') { bracketsMatch = true; }
					break;
				case '(':
					if (closingBracket == ')') { bracketsMatch = true; }
					break;
			}

			return bracketsMatch;
		}

		public static bool CheckBrackets(string[] input)
		{
			bool bracketsAreValid = false;

			Stack<string> stack1 = new Stack<string>();

			foreach (string bracket in input)
			{
				if (IsOpeningBracket(bracket[0]))
				{
					stack1.Push(bracket);
				}
				else if (stack1.Count == 0)
				{
					bracketsAreValid = false;
					break;
				}
				else
				{
					string previousBracket = stack1.Pop();
					if (CheckBracketsMatch(previousBracket[0], bracket[0]))
					{
						bracketsAreValid = true;
					}
					else
					{
						bracketsAreValid = false;
						break;
					}
				}
			}
			return bracketsAreValid;
		}

		static void Main(string[] args)
		{
			string[] inputString = { "(", "[", "]", "{", "}", ")" };
			string[] inputString2 = { "(", "[", "[", "]", ")" };

			Console.WriteLine(CheckBrackets(inputString));
			Console.WriteLine(CheckBrackets(inputString2));
		}
	}
}
