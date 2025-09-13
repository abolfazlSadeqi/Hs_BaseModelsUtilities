namespace Hs_BaseModelsUtilities.Models.Domian.ValueObjects
{
    /// <summary>
    /// Money Value Object
    /// </summary>
    public sealed class Money : ValueObject
    {
        public decimal Amount { get; }
        public string Currency { get; }

        public Money(decimal amount, string currency = "USD")
        {
            if (amount < 0) throw new ArgumentException("Amount cannot be negative.");
            Amount = amount;
            Currency = currency;
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Amount;
            yield return Currency;
        }



    }

}
