
namespace TMPS.L3.Mihai.Composite
{
    public class BankAccountGroup : BankAccountComponent
    {
        private List<BankAccountComponent> _accounts = new List<BankAccountComponent>();

        public override void Add(BankAccountComponent account)
        {
            _accounts.Add(account);
        }

        public override void Remove(BankAccountComponent account)
        {
            _accounts.Remove(account);
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + " Group " + AccountNumber + " " + Balance);

            foreach (BankAccountComponent account in _accounts)
            {
                account.Display(depth + 2);
            }
        }
    }
}
