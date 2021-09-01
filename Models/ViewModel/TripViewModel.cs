using System;

namespace TheRuhuahs_TandT.Models.ViewModel
{
    public class TripViewModel
    {
        public int TouristCenterId { get; set;}

          public DateTime StartDate { get; set;}

          public DateTime EndDate { get; set;}

          public int NumberOfTourist { get; set;}

          public int NumberOfBooking { get; set;}
    }
        public class CreateTripViewModel

        {
          public int TouristCenterId { get; set;}

          public DateTime StartDate { get; set;}

          public DateTime EndDate { get; set;}

          public int NumberOfTourist { get; set;}

          public int NumberOfBooking { get; set;}  
        }
        public class UpdateTripViewModelViewModel
        {
          public int TouristCenterId { get; set;}

          public DateTime StartDate { get; set;}

          public DateTime EndDate { get; set;}

          public int NumberOfTourist { get; set;}

          public int NumberOfBooking { get; set;}
        }
    
}