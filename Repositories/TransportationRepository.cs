using System.Collections.Generic;
using System.Linq;
using TheRuhuahs_TandT.Models;

namespace TheRuhuahs_TandT.Repositories
{
    public class TransportationRepository : ITransportationRepository
    {
        public readonly ApplicationDbContext _dbContext;
        public TransportationRepository(ApplicationDbContext dBContext)
        { _dbContext = dBContext; }
        public Transportation AddTransportation(Transportation payment)
        {
            _dbContext.Transportations.Add(payment);
            _dbContext.SaveChanges();
            return payment;
        }
        public Transportation FindByTransportationId(int id)
        {
            return _dbContext.Transportations.Find(id);
        }
        public Transportation UpdateTransportation(Transportation payment)
        {
            _dbContext.Transportations.Update(payment);
            _dbContext.SaveChanges();
            return payment;
        }
        public void DeleteTransportation(int id)
        {
            var payment = FindByTransportationId(id);

            if (payment != null)
            {
                _dbContext.Transportations.Remove(payment);
                _dbContext.SaveChanges();
            }
        }
        public List<Transportation> GetTransportation()
        {
            return _dbContext.Transportations.ToList();
        }

    }
}