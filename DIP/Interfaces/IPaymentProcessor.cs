using System;
using DIP.Model;

namespace DIP.Interfaces
{
    public interface IPaymentProcessor
    {
        void ProcessCreditCard(PaymentDetail paymentDetails, decimal amount);
    }
}
