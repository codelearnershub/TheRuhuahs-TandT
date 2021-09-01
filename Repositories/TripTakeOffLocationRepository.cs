using System.Collections.Generic;
using System.Linq;
using TheRuhuahs_TandT.Interfaces;
using TheRuhuahs_TandT.Models;

namespace TheRuhuahs_TandT.Repositories
{
    public class TripTakeOffLocationRepository : ITripTakeOffLocationRepository
    {
        public readonly ApplicationDbContext _dbContext;
        public TripTakeOffLocationRepository(ApplicationDbContext dBContext)
        { _dbContext = dBContext; }
        public TripTakeOffLocation AddTripTakeOffLocation(TripTakeOffLocation tripTakeOffLocation)
        {
            _dbContext.TripTakeOffLocations.Add(tripTakeOffLocation);
            _dbContext.SaveChanges();
            return tripTakeOffLocation;
        }
        public TripTakeOffLocation FindByTripTakeOffLocationId(int id)
        {
            return _dbContext.TripTakeOffLocations.Find(id);
        }
        public TripTakeOffLocation UpdateTripTakeOffLocation(TripTakeOffLocation tripTakeOffLocation)
        {
            _dbContext.TripTakeOffLocations.Update(tripTakeOffLocation);
            _dbContext.SaveChanges();
            return tripTakeOffLocation;
        }
        public void DeleteTripTakeOffLocation(int id)
        {
            var tripTakeOffLocation = FindByTripTakeOffLocationId(id);

            if (tripTakeOffLocation != null)
            {
                _dbContext.TripTakeOffLocations.Remove(tripTakeOffLocation);
                _dbContext.SaveChanges();
            }
        }
        public List<TripTakeOffLocation> GetTripTakeOffLocation()
        {
            return _dbContext.TripTakeOffLocations.ToList();
        }
    }
    
}