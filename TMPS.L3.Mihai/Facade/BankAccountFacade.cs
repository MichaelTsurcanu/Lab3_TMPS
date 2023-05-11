using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMPS.L3.Mihai.Facade
{
    public class BankAccountFacade
    {
        private BankAccountService _service = new BankAccountService();

        public void Deposit(string accountNumber, double amount)
        {
            BankAccount account = FindAccount(accountNumber);
            _service.Deposit(account, amount);
            Console.WriteLine("Deposited {0:C} to account {1}. New balance is {2:C}.", amount, accountNumber, account.Balance);
        }

        public void Withdraw(string accountNumber, double amount)
        {
            BankAccount account = FindAccount(accountNumber);
            _service.Withdraw(account, amount);
            Console.WriteLine("Withdrew {0:C} from account {1}. New balance is {2:C}.", amount, accountNumber, account.Balance);
        }

        public void CheckBalance(string accountNumber)
        {
            BankAccount account = FindAccount(accountNumber);
            double balance = _service.CheckBalance(account);
            Console.WriteLine("Account {0} balance: {1:C}", accountNumber, balance);
        }

        private BankAccount FindAccount(string accountNumber)
        {
            // code to find the account in a database or other data source
            return new BankAccount(accountNumber, 0.0);
        }
    }
}
