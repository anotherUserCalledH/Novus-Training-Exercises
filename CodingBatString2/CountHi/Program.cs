namespace CountHi
{
	internal class Program
	{
		public static int CountHi(String inputString)
		{
			int hiCounter = 0;

			for(int character = 0; character < inputString.Length; character++)
			{
				if (inputString[character] == 'h' && inputString[character + 1] == 'i')
				{
					hiCounter++;
					character++;
				}
			}

			return hiCounter;
		}
		static void Main(string[] args)
		{
			Console.WriteLine(CountHi("abc hi ho"));
			Console.WriteLine(CountHi("ABChi hi"));
			Console.WriteLine(CountHi("hihi"));
		}
	}
}
