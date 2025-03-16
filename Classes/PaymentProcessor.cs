using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkshopBookingSystem.Classes
{
    public class PaymentProcessor
    {
        private PaymentContext _paymentContext;

        public PaymentProcessor()
        {
            _paymentContext = new PaymentContext();
        }

        public void StartPaymentProcess (decimal amount)
        {
           
            var choice = AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                .Title("Välj betalningsalternativ")
                .AddChoices("Kreditkort", "Swish")
                );

            switch (choice)
            {
                case "Kreditkort":
                    _paymentContext.SetPaymentMethod(new CreditCardPayment());
                    _paymentContext.Pay(amount);
                    break;
                case "Swish":
                    _paymentContext.SetPaymentMethod(new SwishPayment());
                    _paymentContext.Pay(amount);
                    break;
                default:
                    AnsiConsole.MarkupLine("[red]Ogiltigt betalningsalternativ.[/]");
                    break;
            }
        }
    }
}
