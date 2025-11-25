class Program
{
    static void Main(string[] args)
    {
        BankAccount acc = new BankAccount("ACC123", 5000);

        Console.WriteLine("Account Number: " + acc.AccountNumber);

        acc.Deposit(2000);
        acc.Withdraw(1500);

        Console.WriteLine("Remaining Balance: " + acc.Balance);
    }
}
