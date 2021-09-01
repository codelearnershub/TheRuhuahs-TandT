using System.Collections.Generic;
using System.Linq;
using TheRuhuahs_TandT.Models;
using TheRuhuahs_TandT.Models.ViewModel;
using TheRuhuahs_TandT.Repositories;

namespace TheRuhuahs_TandT.Services
{
    public class TakeOffLocationService
    {
       private readonly ITakeOffLocationRepository _takeOffLocationRepository;

        public TakeOffLocationService(ITakeOffLocationRepository takeOffLocationRepository)
        {
            _takeOffLocationRepository = takeOffLocationRepository;
        }

        public TakeOffLocation AddTakeOffLocation(CreateTakeOffLocationViewModel model)
        {
            var takeOffLocation = new TakeOffLocation
            {
                Name = model.Name,
                Address = model.Address,
        
            };
            if(model.Name == takeOffLocation.Name)
            {
               
            }
            return _takeOffLocationRepository.AddTakeOffLocation(takeOffLocation);
        }
        public TakeOffLocation UpdateTakeOffLocation(TakeOffLocation takeOffLocation)
        {
            return _takeOffLocationRepository.UpdateTakeOffLocation(takeOffLocation);
        }

        public TakeOffLocation FindByTakeOffLocationId(int id)
        {
            return _takeOffLocationRepository.FindByTakeOffLocationId(id);
        }

        public void DeleteTakeOffLocation(int id)
        {
            _takeOffLocationRepository.DeleteTakeOffLocation(id);
        }
        public List<TakeOffLocationViewModel> GetTakeOffLocation()
        {
            var takeOffLocation = _takeOffLocationRepository.GetTakeOffLocation().Select(c => new TakeOffLocationViewModel
            {
                Name = c.Name,
                Address = c.Address,
               
            }).ToList();

            return takeOffLocation;
        } 
    }
}