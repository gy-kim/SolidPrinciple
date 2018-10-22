using System;
using DIP.Interfaces;

namespace DIP.Model
{
    public class OnlineOrder : Order
    {
        private readonly INotificationService _notificationService;
        private readonly PaymentDetails _paymentDetails;
        private readonly IPaymentProcessor _paymentProcessor;
        private readonly IReservationService _reservationService;

        public OnlineOrder(Cart cart,
                           PaymentDetails paymentDetails,
                           IPaymentProcessor paymentProcessor,
                           IReservationService reservationService,
                           INotificationService notificationService)
            : base(cart)
        {
            this._paymentDetails = paymentDetails;
            this._paymentProcessor = paymentProcessor;
            this._reservationService = reservationService;
            this._notificationService = notificationService;
        }

        public override void Checkout()
        {
            this._paymentProcessor.ProcessCreditCard(_paymentDetails, _cart.TotalAmount);

            this._reservationService.ReserveInventory(_cart.Items);

            this._notificationService.NotifyCustomerOrderCreated(_cart);

            base.Checkout();
        }
    }
}
