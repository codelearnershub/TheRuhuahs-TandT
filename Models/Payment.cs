using System;

namespace TheRuhuahs_TandT.Models
{
    public class Payment : BaseEntity
    {
        public int UserId { get; set;}

        public decimal Amount { get; set;}

        public DateTime CreatedAt { get; set;}

        public int BookingId { get; set;}
    }
}