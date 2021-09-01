using System.Collections.Generic;
using System.Linq;
using TheRuhuahs_TandT.Models;
using TheRuhuahs_TandT.Models.ViewModel;
using TheRuhuahs_TandT.Repositories;

namespace TheRuhuahs_TandT.Services
{
    public class BookingService
    {
        private readonly IBookingRepository _bookingRepository;

        public BookingService(IBookingRepository bookingRepository)
        {
            _bookingRepository = bookingRepository;
        }

        public Booking AddBooking(CreateBookingViewModel model)
        {
            var booking = new Booking
            {
                UserId = model.UserId,
                NumberOfTourist = model.NumberOfTourist,
                Reference = model.Reference,
                IsPaid = model.IsPaid,
                Package = model.Package,
                TakeOfLocation = model.TakeOfLocation,
                AmountPaid = model.AmountPaid

            };
            if(model.UserId == booking.UserId)
            {
               
            }
            return _bookingRepository.AddBooking(booking);
        }
        public Booking UpdateBooking(Booking booking)
        {
            return _bookingRepository.UpdateBooking(booking);
        }

        public Booking FindByBookingId(int id)
        {
            return _bookingRepository.FindByBookingId(id);
        }

        public void DeleteBooking(int id)
        {
            _bookingRepository.DeleteBooking(id);
        }
        public List<BookingViewModel> GetUser()
        {
            var booking = _bookingRepository.GetBooking().Select(c => new BookingViewModel
            {
                UserId = c.UserId,
                NumberOfTourist = c.NumberOfTourist,
                Reference = c.Reference,
                IsPaid = c.IsPaid,
                Package = c.Package,
                TakeOfLocation = c.TakeOfLocation,
                AmountPaid = c.AmountPaid
               
            }).ToList();

            return booking;
        
        }
    }
}