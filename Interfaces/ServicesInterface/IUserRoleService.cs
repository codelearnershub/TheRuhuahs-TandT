using System.Collections.Generic;
using TheRuhuahs_TandT.Models;
using TheRuhuahs_TandT.Models.ViewModel;

namespace TheRuhuahs_TandT.Interfaces.ServicesInterface
{
    public interface IUserRoleService
    {
        public UserRole AddUserRole(CreateUserRoleViewModel model);
      
        public UserRole FindByUserRoleId(int id);
       
        public void DeleteUserRole(int id);

        public List<UserRoleViewModel> GetUserRole();
    }
}