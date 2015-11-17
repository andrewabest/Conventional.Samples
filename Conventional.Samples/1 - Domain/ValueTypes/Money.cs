namespace Conventional.Samples.Domain.ValueTypes
{
    public class Money
    {
        protected Money(decimal amount)
        {
            Amount = amount;
        }

        public static Money Create(decimal amount)
        {
            return new Money(amount);
        }

        public static Money Empty()
        {
            return new Money(0);
        }

        public decimal Amount { get; private set; }
    }
}