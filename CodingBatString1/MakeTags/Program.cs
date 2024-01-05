namespace MakeTags
{
	internal class Program
	{
		public static string MakeTags(string tag, string text)
		{
			return tag + text + tag;
		}
		static void Main(string[] args)
		{
			Console.WriteLine("Enter a html tag: ");
			string htmlTag = Console.ReadLine();
			Console.WriteLine("Enter some text: ");
			string text = Console.ReadLine();
			Console.WriteLine(MakeTags(htmlTag, text));
		}
	}
}
