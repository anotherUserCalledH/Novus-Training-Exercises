namespace CigarParty
{
	internal class Program
	{
		public static bool CigarParty(int cigars, bool isWeekend)
		{
			bool output = false;

			if(cigars >= 40)
			{
				if(isWeekend)
				{
					output = true;
				}
				if(cigars <= 60)
				{
					output = true;
				}
			}
			else
			{
				output = false;
			}

			return output;
		}

		static void Main(string[] args)
		{
			Console.WriteLine(CigarParty(30, false));
			Console.WriteLine(CigarParty(50, false));
			Console.WriteLine(CigarParty(70, true));
		}
	}
}
