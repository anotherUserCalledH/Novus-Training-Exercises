namespace BinarySearch
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Random generator = new Random();
			int randomNumber = (int)(generator.NextDouble() * 100);
			int guessesRemaining = 5;

			Console.WriteLine("A random number between 1 and 99 has been chosen");

			while (guessesRemaining > 0)
			{
				Console.WriteLine("Enter your guess: ");
				int guess = Int32.Parse(Console.ReadLine());

				if (guess == randomNumber)
				{
					Console.WriteLine("Congrats. You Guessed correctly.");
					break;
				}
				else if (guess < randomNumber)
				{
					Console.WriteLine("Too low");
				}
				else if (guess > randomNumber)
				{
					Console.WriteLine("Too high");
				}

				guessesRemaining--;
				Console.WriteLine($"You have {guessesRemaining} guesses remaining");
			}

			Console.WriteLine(randomNumber);
		}
	}
}
