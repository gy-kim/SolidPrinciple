using System;
namespace OCP.Model
{
    public interface IPricingCalculator
    {
        decimal CalculatePrice(OrderItem item);
    }
}
