using System.Collections.Generic;
using System.Threading.Channels;

namespace Second
{
    //2. Написать программу "Конвертор валют". Программа должна поддерживать не менее 5 валют, 
    //Конвертация должна быть доступна из любой валюты в любую.
    //Пару валют и сумму для конвертации указывает пользователь. Rate валют можете брать тот, что сейчас на текущий момент, 
    //решить с использованием классов, предусмотреть все негативные кейсы, не нужно использовать реальные rates в runtime!)

    internal partial class CurrencyConverter
    {
        private static readonly Dictionary<string, decimal> CurrencyRate = new Dictionary<string, decimal>();

        private class MainActions
        {
            public static void Main(string[] args)
            {
                AddDefaultCurrency();
            
                var converter = new Converter();

                while (true)
                {
                    converter.ChooseCurrency();
                }
            }

            private static void AddDefaultCurrency()
            {
                CurrencyRate.Add("USD", 1);
                CurrencyRate.Add("GBP", 0.71m);
                CurrencyRate.Add("EUR", 0.9m);
                CurrencyRate.Add("UAH", 27.85m);
                CurrencyRate.Add("RUB", 76.34m);
            }
        }
    }
}