using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMPS.L3.Mihai.Composite
{
    internal class BankAccount : BankAccountComponent
    {
        public BankAccount(string accountNumber, double balance)
        {
            AccountNumber = accountNumber;
            Balance = balance;
        }

        public override void Add(BankAccountComponent account)
        {
            Console.WriteLine("Cannot add to a leaf node.");
        }

        public override void Remove(BankAccountComponent account)
        {
            Console.WriteLine("Cannot remove from a leaf node.");
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + " " + AccountNumber + " " + Balance);
        }
    }
}
