namespace GOF.Strutcturals._Facade.RealWorld
{
    public class Mortgage
    {
        private readonly Bank bank = new();
        private readonly Loan loan = new();
        private readonly Credit credit = new();

        public bool IsElegible(Customer customer, int amount)
        {
            Console.WriteLine("{0} applies for {1:C} loan\n", customer.Name, amount);

            var elegible = true;

            if (
                !bank.HasSufficientSavings(customer, amount)
                || !loan.HasNoBadLoans(customer)
                || !credit.HasGoodCredit(customer)
            )
            {
                elegible = false;
            }

            return elegible;
        }

    }
}
