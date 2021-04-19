using System;
using System.Collections.Generic;

namespace Second
{

    internal partial class CurrencyConverter
    {
        private class Converter
        {
            public void ChooseCurrency()
            {
                while (true)
                {
                    var currencyClass = new Currency();

                    Console.WriteLine("Hello! Please choose your currency: ");
                    var userCurrency = Console.ReadLine();

                    if (!currencyClass.ValidateCurrency(ref userCurrency))
                    {
                        return;
                    }

                    Console.WriteLine("Please choose the second currency: ");
                    var secondCurrency = Console.ReadLine();

                    if (!currencyClass.ValidateCurrency(ref secondCurrency))
                    {
                        return;
                    }

                    if (userCurrency.ToUpper() == secondCurrency.ToUpper())
                    {
                        Console.WriteLine("Please indicate different currencies.");
                        return;
                    }

                    Console.WriteLine("Thank you. Please indicate the sum you'd like to convert: ");
                    var sum = Console.ReadLine();

                    if (!decimal.TryParse(sum, out decimal firstCurrency))
                    {
                        Console.WriteLine("Error: you can enter only numbers in this field.");
                        break;
                    }
                    else if (decimal.Parse(sum) <= 0)
                    {
                        Console.WriteLine($"Error: the sum cannot be under 0.");
                        break;
                    }

                    decimal result = Convert(ref userCurrency, ref firstCurrency, ref secondCurrency);
                    Console.WriteLine($"Your sum in {secondCurrency.ToUpper()} is {result}.");
                }
            }

            private decimal Convert(ref string userCurrency, ref decimal firstCurrency, ref string secondCurrency)
            {
                var currencyConverter = new CurrencyConverter();

                decimal first = 0;
                foreach (KeyValuePair<string, decimal> x in CurrencyRate)
                {
                    if (userCurrency.ToUpper() == x.Key)
                    {
                        first = x.Value;
                    }
                }

                decimal second = 0;
                foreach (KeyValuePair<string, decimal> x in CurrencyRate)
                {
                    if (secondCurrency.ToUpper() == x.Key)
                    {
                        second = x.Value;
                    }
                }

                decimal result = firstCurrency / first * second;

                return result;
            }
        }
    }
}