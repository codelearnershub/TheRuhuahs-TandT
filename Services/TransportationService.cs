using System.Collections.Generic;
using System.Linq;
using TheRuhuahs_TandT.Models;
using TheRuhuahs_TandT.Models.ViewModel;
using TheRuhuahs_TandT.Repositories;

namespace TheRuhuahs_TandT.Services
{
    public class TransportationService
    {
        private readonly ITransportationRepository _transportationRepository;

        public TransportationService(ITransportationRepository transportationRepository)
        {
            _transportationRepository = transportationRepository;
        }

        public Transportation AddTransportation(CreateTransportationViewModel model)
        {
            var transportation = new Transportation
            {
                Amount = model.Amount,
                TakeOffType = model.TakeOffType

            };
            if(model.Amount == transportation.Amount)
            {
               
            }
            return _transportationRepository.AddTransportation(transportation);
        }
        public Transportation UpdateTransportation(Transportation transportation)
        {
            return _transportationRepository.UpdateTransportation(transportation);
        }

        public Transportation FindByTransportationId(int id)
        {
            return _transportationRepository.FindByTransportationId(id);
        }

        public void DeleteTransportation(int id)
        {
            _transportationRepository.DeleteTransportation(id);
        }
        public List<TransportationViewModel> GetTransportation()
        {
            var transportation = _transportationRepository.GetTransportation().Select(c => new TransportationViewModel
            {
                Amount = c.Amount,
                TakeOffType = c.TakeOffType
               
            }).ToList();

            return transportation;
        }
    }
}