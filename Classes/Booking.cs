using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkshopBookingSystem.Classes
{
    public class Booking
    {
        public DateTime Date { get; set; }
        public string Name { get; set; }

        public Booking(DateTime date, string name)
        {
            Date = date;
            Name = name;
        }
    }
}
