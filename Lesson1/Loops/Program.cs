namespace Loops
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int upperBound = 100;
			int lowerBound = 3;

			for(int loopVar = lowerBound; loopVar < upperBound; loopVar = loopVar + 2)
			{
				Console.WriteLine(loopVar);
			}
		}
	}
}
