using System;
using System.Collections.Generic;

namespace Second
{

    internal partial class CurrencyConverter
    {
        private class Converter
        {
            public static void ChooseCurrency()
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

                    if (string.Equals(userCurrency, secondCurrency, StringComparison.CurrentCultureIgnoreCase))
                    {
                        Console.WriteLine("Please indicate different currencies.");
                        return;
                    }

                    Console.WriteLine("Thank you. Please indicate the sum you'd like to convert: ");
                    var sum = Console.ReadLine();

                    if (!double.TryParse(sum, out double firstCurrency))
                    {
                        Console.WriteLine("Error: you can enter only numbers in this field.");
                        break;
                    }
                    else if (double.Parse(sum) <= 0)
                    {
                        Console.WriteLine($"Error: the sum cannot be under 0.");
                        break;
                    }

                    var result = Convert(ref userCurrency, ref firstCurrency, ref secondCurrency);
                    Console.WriteLine($"Your sum in {secondCurrency.ToUpper()} is {result}.");
                }
            }

            private static double Convert(ref string userCurrency, ref double firstCurrency, ref string secondCurrency)
            {
                var currencyConverter = new CurrencyConverter();

                double first = 0;
                foreach (var x in CurrencyRate)
                {
                    if (userCurrency.ToUpper() == x.Key)
                    {
                        first = x.Value;
                    }
                }

                double second = 0;
                foreach (var (key, value) in CurrencyRate)
                {
                    if (secondCurrency.ToUpper() == key)
                    {
                        second = value;
                    }
                }

                var result = firstCurrency / first * second;

                return result;
            }
        }
    }
}