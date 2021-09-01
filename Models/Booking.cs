using System;

namespace TheRuhuahs_TandT.Models
{
    public class Booking : BaseEntity
    {
        public int UserId { get; set;}

        public int NumberOfTourist { get; set;}

        public string Reference { get; set;}

        public int IsPaid { get; set;}

        public string Package { get; set;}

        public string TakeOfLocation { get; set;}

        public int AmountPaid { get; set;}
    }
}