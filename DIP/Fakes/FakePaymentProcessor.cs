using System;
using DIP.Interfaces;
using DIP.Model;

namespace DIP.Fakes
{
    public class FakePaymentProcessor : IPaymentProcessor
    {
        public decimal AmountPassed = 0;
        public bool WasCalled = false;
        public void ProcessCreditCard(PaymentDetails paymentDetails, decimal amount)
        {
            this.WasCalled = true;
            this.AmountPassed = amount;
        }
    }
}
