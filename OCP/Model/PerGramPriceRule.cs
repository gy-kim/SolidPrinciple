﻿using System;
namespace OCP.Model
{
    public class PerGramPriceRule : IPriceRule
    {
        public decimal CalculatePrice(OrderItem item)
        {
            return item.Quantity * 4m / 1000;
        }

        public bool IsMatch(OrderItem item)
        {
            return item.Sku.StartsWith("WEIGHT", StringComparison.CurrentCultureIgnoreCase);
        }
    }
}
