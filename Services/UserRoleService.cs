using System.Collections.Generic;
using System.Linq;
using TheRuhuahs_TandT.Interfaces.ServicesInterface;
using TheRuhuahs_TandT.Models;
using TheRuhuahs_TandT.Models.ViewModel;
using TheRuhuahs_TandT.Repositories;

namespace TheRuhuahs_TandT.Services
{
    public class UserRoleService : IUserRoleService
    {
        private readonly IUserRoleRepository _userRoleRepository;
        
        public UserRoleService(IUserRoleRepository userRoleRepository)
        {
           userRoleRepository = _userRoleRepository;
        }

        public UserRole AddUserRole(CreateUserRoleViewModel model)
        {
            var userRole = new UserRole
            {
                UserId = model.UserId,
                RoleId = model.RoleId,
                Roles = model.Roles,
                Users = model.Users

            };
            if(model.Roles == userRole.Roles)
            {
                
            }
            
            return _userRoleRepository.AddUserRole(userRole);
        }
        public UserRole UpdateUserRole(UserRole userRole)
        {
            return _userRoleRepository.UpdateUserRole(userRole);
        }

        public UserRole FindByUserRoleId(int id)
        {
            return _userRoleRepository.FindByUserRoleId(id);
        }

        public void DeleteUserRole(int id)
        {
            _userRoleRepository.DeleteUserRole(id);
        }
        public List<UserRoleViewModel> GetUserRole()
        {
            var userRole = _userRoleRepository.GetUserRole().Select(c => new UserRoleViewModel
            {
                UserId = c.UserId,
                RoleId = c.RoleId,
                Roles = c.Roles,
               
            }).ToList();

            return userRole;
        }
    }
}