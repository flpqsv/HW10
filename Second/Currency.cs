using System;
using System.Linq;

namespace Second
{

    internal partial class CurrencyConverter
    {
        private class Currency
        {
            public bool ValidateCurrency(ref string currency)
            {
                while (!DoesCurrencyExist(currency))
                {
                    Console.WriteLine("Do you want to try again? Yes/No");

                    if (Console.ReadLine()?.ToLower() == "yes")
                    {
                        Console.WriteLine("Please enter your currency again: ");
                        currency = Console.ReadLine();
                    }
                    else
                    {
                        return false;
                    }
                }

                return true;
            }

            private static bool DoesCurrencyExist(string currency)
            {
                var currencyConverter = new CurrencyConverter();

                var result = CurrencyConverter.CurrencyRate.Keys.Any(key => key.Equals(currency.ToUpper()));

                if (!result)
                {
                    Console.WriteLine($"Unfortunately, we do not support currency '{currency}'.");
                }

                return result;
            }
        }
    }
}