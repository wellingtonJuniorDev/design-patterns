namespace GOF.Strutcturals._Facade.RealWorld
{
    public class Bank
    {
        public bool HasSufficientSavings(Customer customer, int amount)
        {
            Console.WriteLine($"Check bank for {customer.Name}");
            return true;
        }
    }

    public class Credit
    {
        public bool HasGoodCredit(Customer customer)
        {
            Console.WriteLine($"Check credit for {customer.Name}");
            return true;
        }
    }

    public class Loan
    {
        public bool HasNoBadLoans(Customer customer)
        {
            Console.WriteLine($"Check loans for {customer.Name}");
            return true;
        }
    }

    public record Customer(string Name);
}
