using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkshopBookingSystem.Interfaces;

namespace WorkshopBookingSystem.Classes
{
public class BookingSystem
    {
        private IBookingNotifier _notifier;

        public void Attach(IBookingNotifier observer)
        {
            _notifier = observer;
        }

        public void Detach()
        {
            _notifier = null;
        }

        public void Notify(string message)
        {
            _notifier?.SendBookingNotification(message);
        }

        public void CreateBooking(string notificationChoice)
        {
            Console.WriteLine("Bokning skapad.");

            if (notificationChoice == "email")
            {
                Attach(new EmailNotifier());
            }
            else if (notificationChoice == "sms")
            {
                Attach(new SMSNotifier());
            }

            Notify("Din bokning har registrerats!");

            Detach();
        }
    }
}