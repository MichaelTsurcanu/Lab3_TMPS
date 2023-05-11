using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMPS.L3.Mihai.Composite;

namespace TMPS.L3.Mihai.Decorator
{
    public abstract class BankAccountDecorator : BankAccountComponent
    {
        protected BankAccountComponent _component;

        public BankAccountDecorator(BankAccountComponent component)
        {
            _component = component;
        }

        public override void Add(BankAccountComponent account)
        {
            _component.Add(account);
        }

        public override void Remove(BankAccountComponent account)
        {
            _component.Remove(account);
        }

        public override void Display(int depth)
        {
            _component.Display(depth);
        }
    }
}
