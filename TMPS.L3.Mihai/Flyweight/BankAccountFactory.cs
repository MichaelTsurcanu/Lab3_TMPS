using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMPS.L3.Mihai.Flyweight
{
    public class BankAccountFactory
    {
        private Dictionary<string, BankAccountFlyweight> _accounts = new Dictionary<string, BankAccountFlyweight>();

        public BankAccountFlyweight GetAccount(string accountNumber)
        {
            if (!_accounts.ContainsKey(accountNumber))
            {
                _accounts.Add(accountNumber, new BankAccountFlyweight(accountNumber, 0.0));
            }

            return _accounts[accountNumber];
        }
    }
}
