using System;
using System.Collections.Generic;
using DIP.Interfaces;
using DIP.Model;

namespace DIP.Fakes
{
    public class FakeReservationService : IReservationService
    {
        public bool WasCalled = false;
        public void ReserveInventory(IEnumerable<OrderItem> items)
        {
            this.WasCalled = true;
        }
    }
}
