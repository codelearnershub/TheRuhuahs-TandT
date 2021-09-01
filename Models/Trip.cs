using System;

namespace TheRuhuahs_TandT.Models
{
    public class Trip : BaseEntity
    {
        public int TouristCenterId { get; set;}

        public DateTime StartDate { get; set;}

        public DateTime EndDate { get; set;}

        public int NumberOfTourist { get; set;}

        public int NumberOfBooking { get; set;}
    }
}