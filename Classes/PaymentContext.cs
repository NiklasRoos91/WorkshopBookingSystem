using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkshopBookingSystem.Classes;
using WorkshopBookingSystem.Interfaces;

namespace WorkshopBookingSystem.Classes
{
    public class PaymentContext
    {
        private IPayment _payment;

        public void SetPaymentMethod(IPayment payment)
        {
            _payment = payment;
        }

        public void Pay(decimal amount)
        {
            _payment.ProcessPayment(amount);

        }
    }
}
