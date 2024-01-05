using System.Text;

namespace StartWord
{
	internal class Program
	{
		public static string GetNewString(string input1, string input2)
		{
			StringBuilder output = new StringBuilder();
			output.Append(input1[0]);
			for(int loopVar = 1; loopVar < input2.Length; loopVar++)
			{
				if (input1[loopVar] == input2[loopVar])
				{
					output.Append(input1[loopVar]);
				}
			}

			return output.ToString();
		}
		static void Main(string[] args)
		{
			Console.WriteLine(GetNewString("hippo", "hi"));
			Console.WriteLine(GetNewString("hippo", "xip"));
			Console.WriteLine(GetNewString("hippo", "i"));
		}
	}
}
