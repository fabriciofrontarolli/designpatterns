namespace NullObject.CurrencyConverters
{
    public interface ICurrencyConverter
    {
        decimal ConvertToLocalCurrency(decimal amountInDollar);
    }
}