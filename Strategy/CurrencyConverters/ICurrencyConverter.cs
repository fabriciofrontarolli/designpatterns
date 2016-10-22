namespace Strategy.CurrencyConverters
{
    public interface ICurrencyConverter
    {
        decimal ConvertToLocalCurrency(decimal amountInDollar);
    }
}