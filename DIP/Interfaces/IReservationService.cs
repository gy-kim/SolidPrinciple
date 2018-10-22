using System;
using System.Collections.Generic;
using DIP.Model;

namespace DIP.Interfaces
{
    public interface IReservationService
    {
        void ReserveInventory(IEnumerable<OrderItem> items);
    }
}
