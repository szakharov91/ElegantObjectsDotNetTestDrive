namespace ElegantObjectsDotNetTestDrive
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's test drive these Elegant Objects...");

            // Create bank account with initial balance
            IAccount account = new BankAccount<Money>(new Money(100m));

            // Deposit money to account
            account = account.Deposit(new Money(50m));
            Console.WriteLine($"Balance after deposit: {account.Balance().ToString()}");

            // Withdraw money from account
            account = account.Withdraw(new Money(30m));
            Console.WriteLine($"Balance after withdrawal: {account.Balance().ToString()}");

            // trying to withdraw more than we have in our account
            try
            {
                account = account.Withdraw(new Money(150m));
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            Console.ReadLine();
        }
    }
}
