using System.Collections.Generic;
using System.Linq;
using TheRuhuahs_TandT.Models;

namespace TheRuhuahs_TandT.Repositories
{
    public class TakeOffLocationRepository : ITakeOffLocationRepository
    {
        public readonly ApplicationDbContext _dbContext;
        public TakeOffLocationRepository(ApplicationDbContext dBContext)
        { _dbContext = dBContext; }
        public TakeOffLocation AddTakeOffLocation(TakeOffLocation takeOffLocation)
        {
            _dbContext.TakeOffLocations.Add(takeOffLocation);
            _dbContext.SaveChanges();
            return takeOffLocation;
        }
        public TakeOffLocation FindByTakeOffLocationId(int id)
        {
            return _dbContext.TakeOffLocations.Find(id);
        }
        public TakeOffLocation UpdateTakeOffLocation(TakeOffLocation takeOffLocation)
        {
            _dbContext.TakeOffLocations.Update(takeOffLocation);
            _dbContext.SaveChanges();
            return takeOffLocation;
        }
        public void DeleteTakeOffLocation(int id)
        {
            var takeOffLocation = FindByTakeOffLocationId(id);

            if (takeOffLocation != null)
            {
                _dbContext.TakeOffLocations.Remove(takeOffLocation);
                _dbContext.SaveChanges();
            }
        }
        public List<TakeOffLocation> GetTakeOffLocation()
        {
            return _dbContext.TakeOffLocations.ToList();
        }
    }
}