using System;
using System.Net.Mail;
using DIP.Interfaces;
using DIP.Model;

namespace DIP.Services
{
    public class NotificationService : INotificationService
    {
        public void NotifyCustomerOrderCreated(Cart cart)
        {
            var customerEmail = cart.CustomerEmail;
            if (!string.IsNullOrEmpty(customerEmail))
            {
                using (var message = new MailMessage("orders@somewhere.com", customerEmail))
                {
                    using (var client = new SmtpClient("localhost"))
                    {
                        message.Subject = $"Your order placed on {DateTime.Now}";
                        message.Body = $"Your order detailed: \n {cart}";

                        try
                        {
                            client.Send(message);
                        }
                        catch(Exception ex)
                        {
                            throw ex;
                        }
                    }
                }
            }
        }
    }
}
