namespace Inheritance
{
	public class Program
	{
		static void Main(string[] args)
		{
			Account myAccount = new Account();
			double currentAmount;
			currentAmount = myAccount.SetAccountBalance(1000.00);
			Console.WriteLine($"current amount : {currentAmount}");

			currentAmount = myAccount.WithdrawFromAccount(200.00);
			Console.WriteLine($"current amount : {currentAmount}");

			currentAmount = myAccount.GetAccountBalance();
			Console.WriteLine($"current amount : {currentAmount}");

			Console.ReadLine();
		}
	}
}
