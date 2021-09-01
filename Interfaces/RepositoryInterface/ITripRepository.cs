using System.Collections.Generic;
using TheRuhuahs_TandT.Models;

namespace TheRuhuahs_TandT.Repositories
{
    public interface ITripRepository
    {
        public Trip AddTrip(Trip trip);

        public Trip FindByTripId(int id);

        public Trip Trip(Trip trip);

        public void DeleteTrip(int id);

        public List<Trip> GetTrip();
    }
}