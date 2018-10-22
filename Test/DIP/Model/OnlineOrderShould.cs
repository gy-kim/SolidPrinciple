using System;
using DIP.Fakes;
using DIP.Model;
using Xunit;
using Xunit.Abstractions;

namespace Test.DIP.Model
{
    public class OnlineOrderShould
    {
        private readonly ITestOutputHelper _output;

        public OnlineOrderShould(ITestOutputHelper output)
        {
            this._output = output;
        }

        [Fact]
        public void SendTotalAmountToCreditCardProcessor()
        {
            var paymentProcessor = new FakePaymentProcessor();
            var reservationService = new FakeReservationService();
            var notificationService = new FakeNotificationService();
            var cart = new Cart { TotalAmount = 5.05m };
            var paymentDetails = new PaymentDetails
            {
                PaymentMethod = PaymentMethod.CreditCard
            };
            var order = new OnlineOrder(cart, paymentDetails, paymentProcessor, reservationService, notificationService);

            order.Checkout();

            Assert.True(paymentProcessor.WasCalled);
            Assert.Equal(cart.TotalAmount, paymentProcessor.AmountPassed);
        }

        [Fact]
        public void NotFailWithNoItemsNotificationNoCreditCard()
        {
            var paymentProcessor = new FakePaymentProcessor();
            var reservationService = new FakeReservationService();
            var notificationSerfice = new FakeNotificationService();
            var cart = new Cart { CustomerEmail = "someone@nowhere.com" };
            var paymentDetails = new PaymentDetails { PaymentMethod = PaymentMethod.CreditCard };
            var order = new OnlineOrder(cart, paymentDetails, paymentProcessor, reservationService, notificationSerfice);

            order.Checkout();
        }
    }
}
