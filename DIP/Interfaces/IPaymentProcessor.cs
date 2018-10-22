using System;
using DIP.Model;

namespace DIP.Interfaces
{
    public interface IPaymentProcessor
    {
        void ProcessCreditCard(PaymentDetails paymentDetails, decimal amount);
    }
}
