using System.Collections.Generic;
using TheRuhuahs_TandT.Models;

namespace TheRuhuahs_TandT.Repositories
{
    public interface ITakeOffLocationRepository
    {
        public TakeOffLocation AddTakeOffLocation(TakeOffLocation takeOffLocation);

        public TakeOffLocation FindByTakeOffLocationId(int id);

        public TakeOffLocation UpdateTakeOffLocation(TakeOffLocation takeOffLocation);

        public void DeleteTakeOffLocation(int id);

        public List<TakeOffLocation> GetTakeOffLocation();
    }
}