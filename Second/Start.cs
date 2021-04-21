using System;
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
        private static readonly Dictionary<string, double> CurrencyRate = new Dictionary<string, double>
            {{"USD", 1}, {"GBP", 0.71},{"EUR", 0.9}, {"UAH", 27.85}, {"RUB", 76.34}};

        private class MainActions
        {
            public static void Main(string[] args)
            { 
                var converter = new Converter();

                while (true)
                {
                    Converter.ChooseCurrency();
                }
            }
        }
    }
}