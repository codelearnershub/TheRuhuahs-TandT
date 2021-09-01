namespace TheRuhuahs_TandT.Models.ViewModel
{
    public class PackageViewModel
    {
        public int TripId { get; set;}

        public string HotelStandard { get; set;}

        public TripType TripType { get; set;}

        public string HotelExpense { get; set;}

        public string FeedingExpense { get; set;}
    }
    
    public class CreatePackageViewModel
    {
        
    public int TripId { get; set;}

    public string HotelStandard { get; set;}

    public TripType TripType { get; set;}

    public string HotelExpense { get; set;}

    public string FeedingExpense { get; set;}

    }
    public class UpdatePackageViewModel
    {
        public int TripId { get; set;}

    public string HotelStandard { get; set;}

    public TripType TripType { get; set;}

    public string HotelExpense { get; set;}

    public string FeedingExpense { get; set;}
    }
    
}