using System.Collections.Generic;
using System.Linq;
using TheRuhuahs_TandT.Models;
using TheRuhuahs_TandT.Models.ViewModel;
using TheRuhuahs_TandT.Repositories;

namespace TheRuhuahs_TandT.Services
{
    public class TripService
    {
        private readonly ITripRepository _tripRepository;

        public TripService(ITripRepository tripRepository)
        {
            _tripRepository = tripRepository;
        }

        public Trip AddTrip(CreateTripViewModel model)
        {
            var trip = new Trip
            {
                TouristCenterId = model.TouristCenterId,
                StartDate = model.StartDate,
                EndDate = model.EndDate,
                NumberOfTourist = model.NumberOfTourist,
                NumberOfBooking = model.NumberOfBooking

            };
            if(model.TouristCenterId == trip.TouristCenterId)
            {
               
            }
            
            return _tripRepository.AddTrip(trip);
        }

        public Trip FindByTripId(int id)
        {
            return _tripRepository.FindByTripId(id);
        }

        public void DeleteTrip(int id)
        {
            _tripRepository.DeleteTrip(id);
        }
        public List<TripViewModel> GetTrip()
        {
            var trip = _tripRepository.GetTrip().Select(c => new TripViewModel
            {
                
                TouristCenterId = c.TouristCenterId,
                StartDate = c.StartDate,
                EndDate = c.EndDate,
                NumberOfTourist = c.NumberOfTourist,
                NumberOfBooking = c.NumberOfBooking
               
            }).ToList();

            return trip;
        }
    }
}