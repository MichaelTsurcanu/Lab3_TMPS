using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMPS.L3.Mihai.Composite
{
    public abstract class BankAccountComponent
    {
        public string? AccountNumber { get; set; }
        public double Balance { get; set; }

        public abstract void Add(BankAccountComponent account);
        public abstract void Remove(BankAccountComponent account);
        public abstract void Display(int depth);
    }
}
