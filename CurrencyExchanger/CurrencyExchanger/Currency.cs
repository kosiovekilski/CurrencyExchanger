using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyExchanger
{
    class Currency
    {
        public string code;
        public string name;
        public double exchangeRateToBGN;

        public Currency(string _code, string _name, double _rate)
        {
            this.code = _code;
            this.name = _name;
            this.exchangeRateToBGN = _rate;
        }

        public override string ToString()
        {
            return name;
        }
    }
}
