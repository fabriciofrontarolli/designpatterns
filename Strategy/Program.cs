using Strategy.CurrencyConverters;
using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            var exchangeHouse = new ExchangeHouse();
            ICurrencyConverter currencyConverter = null;

            while (true)
            {
                #region Getting Amount in Dollars and Currency to Convert
                Console.WriteLine("Enter how much Dollars you have");
                Console.WriteLine(Environment.NewLine);

                var amountInDollar = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("Which Currency do you need ?");
                Console.WriteLine("Type 'EUR' for Euro");
                Console.WriteLine(Environment.NewLine);
                Console.WriteLine("Type 'BRL' for Brazilian Real");
                Console.WriteLine(Environment.NewLine);

                var currency = Console.ReadLine().ToUpper();
                #endregion

                #region Getting Specific Converter
                switch (currency)
                {
                    case "BRL":
                        currencyConverter = new BrazilianCurrencyConverter();
                        break;
                    case "EUR":
                        currencyConverter = new EuroCurrencyConverter();
                        break;

                    default:
                        Console.WriteLine("Oops.. Not a valid option!");
                        break;
                }
                #endregion
                
                exchangeHouse.SetCurrency(currencyConverter);
                var exchangedMoney = exchangeHouse.CashConvertedCurrency(amountInDollar);

                Console.WriteLine(string.Format("You now have {0} in {1}", exchangedMoney.ToString("C"), currency));
                Console.WriteLine(Environment.NewLine);
            }
        }
    }
}