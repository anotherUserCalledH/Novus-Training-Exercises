using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
	public class Account : Person
	{
		public double GetAccountBalance()
		{
			return CurrentAccount;
		}

		public double SetAccountBalance(double amount)
		{
			CurrentAccount = CurrentAccount + amount;
			return CurrentAccount;
		}

		public double WithdrawFromAccount(double amountToWithdraw)
		{
			CurrentAccount = CurrentAccount - amountToWithdraw;
			return CurrentAccount;
		}
	}
}
