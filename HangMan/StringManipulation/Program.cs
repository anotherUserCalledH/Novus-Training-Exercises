using Microsoft.VisualBasic;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Reflection.PortableExecutable;

namespace StringManipulation
{
	public class CharacterPosition
	{
		public string? nameOfWord { get; set; }
		public char? c { get; set; }
		public int pos { get; set; }
	}


	internal class Program
	{
		public static string[] ImportWords()
		{
			string? contents = null;
			string[] words;
			try
			{
				string path = @"Files/Words.txt";
				string fileName = Path.GetFileName(path);

				using (var inputReader = new StreamReader(path))
				{
					contents = inputReader.ReadToEnd();
				}

				words = contents.Split('\n', StringSplitOptions.RemoveEmptyEntries);
			}
			catch (IOException e)
			{
				Console.WriteLine(e.Message);
				words = null;
				Environment.Exit(1);
			}

			return words;
		}

		public static List<CharacterPosition> SearchWord(string wordToSearch, string inputLetter)
		{
			List<CharacterPosition> foundCharacters = new List<CharacterPosition>();

			inputLetter = inputLetter.ToLower();
			char letter = inputLetter[0];

			for (int index = 0; index < wordToSearch.Length; index++)
			{
				if (wordToSearch[index] == letter)
				{
					Console.WriteLine($"{letter} found at position {index}");
					foundCharacters.Add(new CharacterPosition() { nameOfWord = wordToSearch, c = letter, pos = index });
				}
			}

			return foundCharacters;
		}

		public static void PlayHangman()
		{
			string[] words = ImportWords();
			Random generator = new Random();
			int wordIndex = generator.Next(words.Length);

			string chosenWord = words[wordIndex].ToLower();
			List<CharacterPosition> wordCharacters = new List<CharacterPosition>();
			int guessesRemaining = 7;

			Console.WriteLine($"Let's play hangman. The word has {chosenWord.Length} letters.");

			while (guessesRemaining > 0)
			{
				Console.WriteLine("Enter a letter: ");
				string input = Console.ReadLine();

				List<CharacterPosition> foundCharacters = SearchWord(chosenWord, input);
				if (foundCharacters.Count != 0)
				{
					wordCharacters.AddRange(foundCharacters);
				}
				else
				{
					Console.WriteLine("Sorry, that was a bad guess.");
					guessesRemaining--;
					Console.WriteLine("Guesses remaining: " + guessesRemaining);
				}

				Console.WriteLine(wordCharacters.Count);
				int remainingLetters = chosenWord.Length - wordCharacters.Count;
				if (remainingLetters == 0)
				{
					Console.WriteLine("Congrats. You win");
				}
				else
				{
					Console.WriteLine("Number of letters left to guess: " + remainingLetters);
				}			
			}

			Console.WriteLine("The word was: " + chosenWord);

		}
		
		static void Main(string[] args)
		{
			/*			List<CharacterPosition> wordCharacters = new List<CharacterPosition>();

						string[] array = ImportWords();
						string inputLetter = "o";

						foreach (string word in array)
						{
							string wordToSearch = word.ToLower();
							SearchWord(wordToSearch, inputLetter);
						}*/

			PlayHangman();
		}
	}
}
