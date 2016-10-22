using System;

namespace Strategy.CurrencyConverters
{
    public class BrazilianCurrencyConverter : ICurrencyConverter
    {
        public decimal ConvertToLocalCurrency(decimal amountInDollars)
        {
            return (amountInDollars * Convert.ToDecimal(3.492));
        }
    }
}