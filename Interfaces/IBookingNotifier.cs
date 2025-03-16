using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkshopBookingSystem.Interfaces
{
    public interface IBookingNotifier
    {
        // Observer
        void SendBookingNotification(string message);
    }
}
