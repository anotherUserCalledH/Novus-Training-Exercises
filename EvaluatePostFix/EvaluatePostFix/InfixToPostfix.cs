using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EvaluatePostFix
{
	internal class InfixToPostfix
	{
		private static int GetPrecedence(char inputOperator)
		{
			switch (inputOperator)
			{
				case '+':
					return 0;
				case '-':
					return 0;
				case '*':
					return 1;
				case '/':
					return 1;
				default:
					return -1;
			}
		}

		private static bool IsOperator(char inputChar)
		{
			return (inputChar == '*' || inputChar == '/' || inputChar == '+' || inputChar == '-');
		}

		private static bool IsOperand(char inputChar)
		{
			bool isDigit = false;
			if ('0' <= inputChar && '9' >= inputChar) { isDigit = true; }

			return isDigit;
		}

		public static string ConvertToPostfix(string infixExpression)
		{
			StringBuilder outputExpression = new StringBuilder("");
			Stack<char> stack1 = new Stack<char>();
			char[] charArray = infixExpression.ToCharArray();

			for (int i = 0; i < charArray.Length; i++)
			{
				if (charArray[i] == ' ' || charArray[i] == ',')
				{
					continue;
				}
				else if (IsOperator(charArray[i]))
				{
					char currentOperator = charArray[i];

					if (stack1.Count > 0)
					{
						char previousOperator = stack1.Peek();
						while (GetPrecedence(previousOperator) >= GetPrecedence(currentOperator))
						{
							outputExpression.Append(stack1.Pop());
							outputExpression.Append(" ");

							if (stack1.Count == 0) { break; }
							previousOperator = stack1.Peek();
						}
					}
					stack1.Push(currentOperator);
				}
				else if (IsOperand(charArray[i]))
				{
					while (i < charArray.Length && IsOperand(charArray[i]))
					{
						outputExpression.Append(charArray[i]);
						i++;
					}
					outputExpression.Append(" ");
					i--;
				}
			}

			while (stack1.Count > 0)
			{
				outputExpression.Append(stack1.Pop());
				outputExpression.Append(" ");

			}

			return outputExpression.ToString();
		}
	}
}
