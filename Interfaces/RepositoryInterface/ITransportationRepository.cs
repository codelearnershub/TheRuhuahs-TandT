using System.Collections.Generic;
using TheRuhuahs_TandT.Models;

namespace TheRuhuahs_TandT.Repositories
{
    public interface ITransportationRepository
    {
        public Transportation AddTransportation(Transportation transportation);

        public Transportation FindByTransportationId(int id);

        public Transportation UpdateTransportation(Transportation transportation);

        public void DeleteTransportation(int id);

        public List<Transportation> GetTransportation();
    }
}