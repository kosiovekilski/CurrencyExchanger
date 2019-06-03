using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyExchanger
{
    class Money
    {
        public double amount;
        public Currency currency;

        public Money() { }

        public Money(double _amount, Currency _currency)
        {
            amount = _amount;
            currency = _currency;
        }

        public double changeCurrency(Currency c)
        {
            amount *= (currency.exchangeRateToBGN / c.exchangeRateToBGN);
            currency = c;
            return (amount - (amount = Math.Round(amount, 2))); /* in the new currency*/
        }

        public override string ToString()
        {
            return currency.code + amount.ToString();
        }
    }
}
