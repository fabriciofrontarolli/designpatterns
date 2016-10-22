namespace NullObject.CurrencyConverters
{
    public class NullCurrencyConverter: ICurrencyConverter
    {
        private static NullCurrencyConverter nullCurrencyConverter;

        private NullCurrencyConverter()
        {
        }

        public static NullCurrencyConverter GetNullCurrencyConverter()
        {
            //Using Singleton - Not necessary to have multiple instances of the same class with no behaviour
            return nullCurrencyConverter = (nullCurrencyConverter ?? new NullCurrencyConverter());
        }

        public decimal ConvertToLocalCurrency(decimal amountInDollars)
        {
            // Null representation will have to calculation
            return 0;
        }
    }
}