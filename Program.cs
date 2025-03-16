using Spectre.Console;
using WorkshopBookingSystem.Classes;

namespace WorkshopBookingSystem
{
    public class Program
    {
        public static void Main()
        {
            var manager = BookingManager.Instance;

            manager.AddBooking(new Booking(new DateTime(2025, 5, 15), "John Doe"));
            manager.AddBooking(new Booking(new DateTime(2025, 3, 10), "Jane Smith"));
            manager.AddBooking(new Booking(new DateTime(2025, 4, 25), "Alice Johnson"));
            manager.AddBooking(new Booking(new DateTime(2025, 6, 5), "Bob Brown"));

            // Söka efter en bokning
            DateTime searchDate = new DateTime(2025, 4, 25);
            manager.FindBookingByDate(searchDate);
        }
    }

}
