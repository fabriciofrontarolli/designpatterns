using System;

namespace NullObject.CurrencyConverters
{
    public class BrazilianCurrencyConverter : ICurrencyConverter
    {
        public decimal ConvertToLocalCurrency(decimal amountInDollars)
        {
            return (amountInDollars * Convert.ToDecimal(3.492));
        }
    }
}