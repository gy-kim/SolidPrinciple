using System;
namespace DIP.Model
{
    public enum PaymentMethod
    {
        Cash,
        CreditCard
    }

    public class PaymentDetail
    {
        public PaymentMethod PaymentMethod { get; set; }

        public string CreditCardNumber { get; set; }

        public string ExpiresMonth { get; set; }

        public string ExpiresYear { get; set; }

        public string CardHolderName { get; set; }
    }
}
