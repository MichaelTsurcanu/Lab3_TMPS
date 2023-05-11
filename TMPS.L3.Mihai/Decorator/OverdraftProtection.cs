using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMPS.L3.Mihai.Composite;

namespace TMPS.L3.Mihai.Decorator
{
    public class OverdraftProtection : BankAccountDecorator
    {
        public OverdraftProtection(BankAccountComponent component) : base(component) { }

        public override void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + " Overdraft Protection");
            _component.Display(depth + 2);
        }
    }
}
