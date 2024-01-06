namespace DoubleChar
{
	internal class Program
	{
		public static string DoubleChar(String inputString)
		{
			int outputLength = inputString.Length * 2;
			char[] output = new char[outputLength];

			for(int character = 0; character < outputLength; character++)
			{
				output[character] = inputString[character / 2];
			}

			string outputString = new string(output);

			return outputString;
		}

		static void Main(string[] args)
		{
			Console.WriteLine(DoubleChar("The"));
			Console.WriteLine(DoubleChar("AAbb"));
			Console.WriteLine(DoubleChar("Hi-There"));
		}
	}
}
