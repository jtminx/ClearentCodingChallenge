namespace ClearentCodingChallenge
{
    public abstract class CreditCard
    {
        protected double amount;

        protected CreditCard (double amount)
        {
            this.amount = amount;
        }

        public abstract double CalculateInterest();
    }
}