using System.Collections.Generic;
using System.Linq;
using TheRuhuahs_TandT.Interface;
using TheRuhuahs_TandT.Models;
using TheRuhuahs_TandT.Models.ViewModel;

namespace TheRuhuahs_TandT.Services
{
    public class RoleService : IRoleService
    {
        private readonly IRoleRepository _roleRepository;

        public RoleService(IRoleRepository roleRepository)
        {
            _roleRepository = roleRepository;
        }

        public Role AddRole(CreateRoleViewModel model)
        {
            var role = new Role
            {
                RoleName = model.RoleName

            };
            
            return _roleRepository.AddRole(role);
        }
        public Role UpdateRole(Role role)
        {
            return _roleRepository.UpdateRole(role);
        }

        public Role FindByRoleId(int id)
        {
            return _roleRepository.FindByRoleId(id);
        }

        public void DeleteRole(int id)
        {
            _roleRepository.DeleteRole(id);
        }
        public List<RoleViewModel> GetRole()
        {
            var role = _roleRepository.GetRole().Select(c => new RoleViewModel
            {
                RoleName = c.RoleName,
                
               
            }).ToList();

            return role;
        }

   
    }
}