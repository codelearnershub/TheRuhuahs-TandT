using System.Collections.Generic;
using TheRuhuahs_TandT.Models;
using TheRuhuahs_TandT.Models.ViewModel;

namespace TheRuhuahs_TandT.Interface
{
    public interface IUserService
    {
        public User AddUser(CreateUserViewModel model);
      
        public User FindByUserId(int id);
       
        public void DeleteUser(int id);

        public List<UserViewModel> GetUser();

        
    }
}