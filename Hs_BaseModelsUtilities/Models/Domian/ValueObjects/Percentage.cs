using System;
using System.Collections.Generic;

namespace Hs_BaseModelsUtilities.Models.Domian.ValueObjects
{
    /// <summary>
    /// Percentage Value Object
    /// </summary>
    public sealed class Percentage : ValueObject
    {
        public decimal Value { get; }

        public Percentage(decimal value)
        {
            if (value < 0 || value > 100)
                throw new ArgumentException("Percentage must be between 0 and 100.");
            Value = value;
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }



    }

}
