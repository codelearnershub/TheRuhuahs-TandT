using System;

namespace TheRuhuahs_TandT.Models.ViewModel
{
    public class PaymentViewModel
    {
        public int UserId { get; set;}

        public decimal Amount { get; set;}

        public DateTime CreatedAt { get; set;}

        public int BookingId { get; set;}
    }
        public class CreatePaymentViewModel
        {
        public int UserId { get; set;}

        public decimal Amount { get; set;}

        public DateTime CreatedAt { get; set;}

        public int BookingId { get; set;}
        }
        public class UpdatePaymentViewModel
        {
        public int UserId { get; set;}

        public decimal Amount { get; set;}

        public DateTime CreatedAt { get; set;}

        public int BookingId { get; set;}
        }
    
}