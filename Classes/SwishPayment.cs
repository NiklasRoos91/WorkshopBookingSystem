using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkshopBookingSystem.Interfaces;

namespace WorkshopBookingSystem.Classes
{
    internal class SwishPayment : IPayment
    {
        public void ProcessPayment(decimal amount)
        {
            AnsiConsole.MarkupLine($"[green]Betalning på {amount} SEK med Swish genomförd.[/]");
        }
    }
}
