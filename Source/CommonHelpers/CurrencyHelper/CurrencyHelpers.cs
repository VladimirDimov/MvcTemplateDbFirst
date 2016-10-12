namespace CommonHelpers.CurrencyHelper
{
    using System;

    /// <summary>
    /// Helpers for currency processing
    /// </summary>
    public class CurrencyHelpers
    {
        /// <summary>
        /// Returns currency symbol according to provided string. If no corresponding symbol is found returns the original input string.
        /// Example: input: "usd", output: "$"
        /// </summary>
        /// <param name="currency"></param>
        /// <returns></returns>
        public static string GetCurrencySymbol(string currency)
        {
            switch (currency.ToUpper())
            {
                case "USD":
                    return "$";

                case "EUR":
                    return "€";

                default:
                    return currency;
            }
        }
    }
}
