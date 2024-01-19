namespace EvaluatePostFix
{
	internal class Program
	{
		static void Main(string[] args)
		{
			EvalPostfix evaluator = new EvalPostfix();
			string infixExpression;

			Console.Write("Insert an Infix expression: ");
			infixExpression = Console.ReadLine();

			if (!string.IsNullOrWhiteSpace(infixExpression))
			{
				string postfixExpression = InfixToPostfix.ConvertToPostfix(infixExpression);
				Console.WriteLine($"Postfix expression is: {postfixExpression}");
				int answer = evaluator.Evaluate(postfixExpression);
				Console.WriteLine($"Answer is: {answer}");
			}
			else
			{
				Console.WriteLine("Invalid input");
			}			
		}
	}
}
