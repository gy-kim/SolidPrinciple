using System;
using DIP.Interfaces;
using DIP.Model;

namespace DIP.Fakes
{
    public class FakeNotificationService : INotificationService
    {
        public bool WasCalled = false;

        public void NotifyCustomerOrderCreated(Cart cart)
        {
            this.WasCalled = true;
        }
    }
}
