using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkshopBookingSystem.Interfaces;

namespace WorkshopBookingSystem.Classes
{
    public class EmailNotifier : IBookingNotifier
    {
        public void SendBookingNotification(string message)
        {
            Console.WriteLine($"E-post skickat: {message}");
        }
    }
}
