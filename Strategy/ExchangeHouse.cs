using Strategy.CurrencyConverters;

namespace Strategy
{
    public class ExchangeHouse
    {
        private ICurrencyConverter currencyConverter;

        public void SetCurrency(ICurrencyConverter currencyConverter)
        {
            this.currencyConverter = currencyConverter;
        }

        public decimal CashConvertedCurrency(decimal amountInDollar)
        {
            return currencyConverter.ConvertToLocalCurrency(amountInDollar);
        }
    }
}