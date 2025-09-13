using System;
using System.Collections.Generic;

namespace Hs_BaseModelsUtilities.Models.Domian.ValueObjects
{
    /// <summary>
    /// Email Value Object
    /// </summary>
    public sealed class Email : ValueObject
    {
        public string Address { get; }

        public Email(string address)
        {
            if (string.IsNullOrWhiteSpace(address) || !address.Contains("@"))
                throw new ArgumentException("Invalid email address.", nameof(address));
            Address = address;
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Address.ToLowerInvariant();
        }
    }




}
