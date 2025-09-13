namespace Hs_BaseModelsUtilities.Models.Domian.ValueObjects
{
    /// <summary>
    /// Phone Number Value Object
    /// </summary>
    public sealed class PhoneNumber : ValueObject
    {
        public string Number { get; }

        public PhoneNumber(string number)
        {
            if (string.IsNullOrWhiteSpace(number))
                throw new ArgumentException("Phone number cannot be empty.", nameof(number));
            Number = number;
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Number;
        }



    }

}
