namespace TheRuhuahs_TandT.Models
{
    public class Package : BaseEntity
    {
        public int TripId { get; set;}

        public string HotelStandard { get; set;}

        public TripType TripType { get; set;}

        public string HotelExpense { get; set;}

        public string FeedingExpense { get; set;}
    }
}