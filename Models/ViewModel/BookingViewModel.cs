namespace TheRuhuahs_TandT.Models.ViewModel
{
    public class BookingViewModel
    {
        public int UserId { get; set;}

        public int NumberOfTourist { get; set;}

        public string Reference { get; set;}

        public int IsPaid { get; set;}

        public string Package { get; set;}

        public string TakeOfLocation { get; set;}

        public int AmountPaid { get; set;}
    }
    public class CreateBookingViewModel

    {
        public int UserId { get; set;}

        public int NumberOfTourist { get; set;}

        public string Reference { get; set;}

        public int IsPaid { get; set;}

        public string Package { get; set;}

        public string TakeOfLocation { get; set;}

        public int AmountPaid { get; set;}
    }
    public class UpdateBookingViewModel
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