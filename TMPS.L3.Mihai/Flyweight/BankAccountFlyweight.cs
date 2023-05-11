using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMPS.L3.Mihai.Flyweight
{
    public class BankAccountFlyweight
    {
        public string AccountNumber { get; private set; }
        public double Balance { get; set; }

        public BankAccountFlyweight(string accountNumber, double balance)
        {
            AccountNumber = accountNumber;
            Balance = balance;
        }
    }
}
