using DIP.Model;

namespace DIP.Interfaces
{
    public interface INotificationService
    {
        void NotifyCustomerOrderCreated(Cart cart);
    }
}
