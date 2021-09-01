using System.Collections.Generic;
using System.Linq;
using TheRuhuahs_TandT.Models;
using TheRuhuahs_TandT.Models.ViewModel;
using TheRuhuahs_TandT.Repositories;

namespace TheRuhuahs_TandT.Services
{
    public class TouristCenterService
    {
        private readonly ITouristCenterRepository _touristCenterRepository;

        public TouristCenterService(ITouristCenterRepository touristCenterRepository)
        {
            _touristCenterRepository = touristCenterRepository;
        }

        public TouristCenter AddTouristCenter(CreateTouristCenterViewModel model)
        {
            var touristCenter = new TouristCenter
            {
                Name = model.Name,
                Location = model.Location,
                Address = model.Address

            };
            if(model.Name == touristCenter.Name)
            {
               
            }
            return _touristCenterRepository.AddTouristCenter(touristCenter);
        }
        public TouristCenter UpdateTouristCenter(TouristCenter touristCenter)
        {
            return _touristCenterRepository.UpdateTouristCenter(touristCenter);
        }

        public TouristCenter FindByTouristCenterId(int id)
        {
            return _touristCenterRepository.FindByTouristCenterId(id);
        }

        public void DeleteTouristCenter(int id)
        {
            _touristCenterRepository.DeleteTouristCenter(id);
        }
        public List<TouristCenterViewModel> GetTouristCenter()
        {
            var touristCenter = _touristCenterRepository.GetTouristCenter().Select(c => new TouristCenterViewModel
            {
                Name = c.Name,
                Location = c.Location,
                Address = c.Address
               
            }).ToList();

            return touristCenter;
        
        }
    }
}