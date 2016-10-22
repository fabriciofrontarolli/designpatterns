using System;

namespace NullObject.CurrencyConverters
{
    class EuroCurrencyConverter : ICurrencyConverter
    {
        public decimal ConvertToLocalCurrency(decimal amountInDollars)
        {
            return (amountInDollars * Convert.ToDecimal(1.13));
        }
    }
}