using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluatePostFix
{
	public class EvalPostfix
	{
		public int Operation(char anOperator, int operand1, int operand2)
		{
			switch (anOperator)
			{
				case '/':
					return operand1 / operand2;
				case '*':
					return operand1 * operand2;
				case '+':
					return operand1 + operand2;
				case '-':
					return operand1 - operand2;
			}

			return 0;
		}

		public bool CheckIsDigit(char character)
		{
			bool isDigit = false;
			if ('0' <= character && '9' >= character) { isDigit = true; }

			return isDigit;
		}

		public int Evaluate(string expression)
		{
			Stack stack1 = new Stack();
			char[] charArray = expression.ToCharArray();
			int operand1, operand2;

			for (int i = 0; i < charArray.Length; i++)
			{
				if (charArray[i] == ' ' || charArray[i] == ',')
				{
					continue;
				}
				else if (charArray[i] == '*' || charArray[i] == '/' || charArray[i] == '+' || charArray[i] == '-')
				{
					operand2 = Convert.ToInt32(stack1.Pop());
					operand1 = Convert.ToInt32(stack1.Pop());
					stack1.Push(Operation(charArray[i], operand1, operand2));
				}
				else if (CheckIsDigit(charArray[i]))
				{
					int operand = 0;
					while (i < charArray.Length && CheckIsDigit(charArray[i]))
					{
						operand = (operand * 10) + (charArray[i] - '0');
						i++;
					}

					i--;

					stack1.Push(operand);
				}
			}

			return Convert.ToInt32(stack1.Pop());

		}
	}
}
