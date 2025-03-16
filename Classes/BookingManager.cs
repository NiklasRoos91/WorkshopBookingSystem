using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkshopBookingSystem.Classes
{
    public class BookingManager
    {
        // SINGLETON
        private static BookingManager instance;
        private List<Booking> bookings = new List<Booking>();

        private BookingManager() { }

        public static BookingManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BookingManager();
                }
                return instance;
            }
        }

        public void AddBooking(Booking booking)
        {
            bookings.Add(booking);
            AnsiConsole.WriteLine($"[green]Bokning tillagd: {booking.Name} {booking.Date}[/]");
        }

        public void RemoveBooking(Booking booking)
        {
            bookings.Remove(booking);
            AnsiConsole.WriteLine($"[red]Bokning borttagen: {booking}[/]");
        }

        public List<Booking> GetAllBookings()
        {
            return bookings;
        }

        public void SortBookings()
        {
            bookings = MergeSort(bookings);
        }

        public void FindBookingByDate(DateTime searchDate)
        {
            Booking foundBooking = BinarySearchBooking(searchDate);

            if (foundBooking != null)
            {
                AnsiConsole.WriteLine($"[green]Bokning hittad: {foundBooking.Name} {foundBooking.Date}[/]");
            }
            else
            {
                AnsiConsole.WriteLine($"[red]Ingen bokning hittades för {searchDate.ToShortDateString()}[/]");
            }
        }


        
        private static List<Booking> MergeSort(List<Booking> unsorted)
        {
            if (unsorted.Count <= 1)
                return unsorted;

            List<Booking> left = new List<Booking>();
            List<Booking> right = new List<Booking>();

            int middle = unsorted.Count / 2;
            for (int i = 0; i < middle; i++)
            {
                left.Add(unsorted[i]);
            }
            for (int i = middle; i < unsorted.Count; i++)
            {
                right.Add(unsorted[i]);
            }

            left = MergeSort(left);
            right = MergeSort(right);

            return Merge(left, right);
        }

        private static List<Booking> Merge(List<Booking> left, List<Booking> right)
        {
            List<Booking> result = new List<Booking>();
            int i = 0, j = 0;

            while (i < left.Count && j < right.Count)
            {
                if ((left[i].Date <= right[j].Date))
                {
                    result.Add(left[i]);
                    i++;
                }
                else
                {
                    result.Add(right[j]);
                    j++;
                }
            }
            while (i < left.Count) result.Add(left[i++]);
            while (j < right.Count) result.Add(right[j++]);

            return result;
        }

        public Booking BinarySearchBooking(DateTime searchDate)
        {
            SortBookings();

            int left = 0;
            int right = bookings.Count - 1;

            while (left <= right)
            {
                int middle = (left + right) / 2;
                var middleBooking = bookings[middle];

                if (middleBooking.Date == searchDate)
                {
                    return middleBooking;
                }
                else if (middleBooking.Date > searchDate)
                {
                    right = middle - 1;
                }
                else
                {
                    left = middle + 1;
                }
            }

            return null;
        }

    }
}