using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMPS.L3.Mihai.Facade
{
    public class BankAccount
    {
        public string AccountNumber { get; private set; }
        public double Balance { get; set; }

        public BankAccount(string accountNumber, double balance)
        {
            AccountNumber = accountNumber;
            Balance = balance;
        }
    }
}
