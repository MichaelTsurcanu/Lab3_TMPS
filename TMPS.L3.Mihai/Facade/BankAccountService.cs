using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMPS.L3.Mihai.Facade
{
    public class BankAccountService
    {
        public void Deposit(BankAccount account, double amount)
        {
            account.Balance += amount;
        }

        public void Withdraw(BankAccount account, double amount)
        {
            if (account.Balance >= amount)
            {
                account.Balance -= amount;
            }
            else
            {
                throw new InvalidOperationException("Insufficient funds.");
            }
        }

        public double CheckBalance(BankAccount account)
        {
            return account.Balance;
        }
    }
}
