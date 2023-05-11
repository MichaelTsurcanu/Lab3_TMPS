using TMPS.L3.Mihai.Composite;
using TMPS.L3.Mihai.Decorator;
using TMPS.L3.Mihai.Flyweight;
using TMPS.L3.Mihai.Facade;

public class Program
{
    public static void Main()
    {
        BankAccountComponent account1 = new TMPS.L3.Mihai.Composite.BankAccount("123456", 1000.0);
        BankAccountComponent account2 = new TMPS.L3.Mihai.Composite.BankAccount("789012", 5000.0);
        BankAccountComponent account3 = new BankAccountGroup()
        {
            AccountNumber = "345678",
            Balance = 0.0
        };
        account3.Add(account1);
        account3.Add(account2);

        Console.WriteLine("Before Overdraft Protection:");
        account3.Display(0);

        BankAccountComponent account3WithProtection = new OverdraftProtection(account3);

        Console.WriteLine("\nAfter Overdraft Protection:");
        account3WithProtection.Display(0);

        BankAccountFacade facade = new BankAccountFacade();

        //Flyweight
        BankAccountFactory factory = new BankAccountFactory();

        BankAccountFlyweight acc1 = factory.GetAccount("123456");
        Console.WriteLine("Account 1 balance: {0}", acc1.Balance);

        BankAccountFlyweight acc2 = factory.GetAccount("123456");
        Console.WriteLine("Account 2 balance: {0}", acc2.Balance);

        account1.Balance += 1000.0;

        Console.WriteLine("Account 1 balance: {0}", acc1.Balance);
        Console.WriteLine("Account 2 balance: {0}", acc2.Balance);
    }
}
