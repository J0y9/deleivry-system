using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deleivry_system.Models
{
    public class Payments : BaesModel
    {
        public double PaymentAmount { get; set; }
        public string PaymentMethod { get; set; }
        public string PaymentStatus { get; set; }
        public int TripId { get; set; }
        public Trips Trip { get; set; }

        public double Discount(DateTime date)
        {
            if (Trip.StartDate == date)
            {
                PaymentAmount = PaymentAmount * 0.75;
            }

            return PaymentAmount;
        }
    }
}
