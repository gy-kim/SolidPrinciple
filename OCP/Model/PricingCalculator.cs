using System;
using System.Collections.Generic;
using System.Linq;

namespace OCP.Model
{
    public class PricingCalculator : IPricingCalculator
    {
        private readonly List<IPriceRule> _pricingRules;

        public PricingCalculator()
        {
            _pricingRules = new List<IPriceRule>();
            _pricingRules.Add(new EachPriceRule());
            _pricingRules.Add(new PerGramPriceRule());
            _pricingRules.Add(new SpecialPriceRule());
        }

        public decimal CalculatePrice(OrderItem item)
        {
            return _pricingRules.First(r => r.IsMatch(item)).CalculatePrice(item);
        }
    }
}
