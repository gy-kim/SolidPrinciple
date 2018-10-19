using System;
using System.Collections.Generic;

namespace OCP.Model
{
    public class Cart
    {
        private readonly List<OrderItem> _items;
        private readonly IPricingCalculator _pricingCalculator;

        public Cart() : this(new PricingCalculator()){}

        public Cart(IPricingCalculator pricingCalculator)
        {
            _pricingCalculator = pricingCalculator;
            _items = new List<OrderItem>();
        }

        public IEnumerable<OrderItem> Items{ get { return _items; }}

        public void Add(OrderItem orderItem)
        {
            _items.Add(orderItem);
        }

        public decimal TotalAmount()
        {
            decimal total = 0m;
            foreach(var item in Items)
            {
                total += _pricingCalculator.CalculatePrice(item);
            }
            return total;
        }
    }
}
