using System.Collections.Generic;
using TheRuhuahs_TandT.Models;
using TheRuhuahs_TandT.Models.ViewModel;

namespace TheRuhuahs_TandT.Interface
{
    public interface IRoleService
    {
        public Role AddRole(CreateRoleViewModel model);
      
        public Role FindByRoleId(int id);
       
        public void DeleteRole(int id);

        public List<RoleViewModel> GetRole();
    }
}