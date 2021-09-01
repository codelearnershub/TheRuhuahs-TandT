using System.Collections.Generic;
using TheRuhuahs_TandT.Models;

namespace TheRuhuahs_TandT.Repositories
{
    public interface IUserRoleRepository
    {
        public UserRole AddUserRole(UserRole userRole);

        public UserRole FindByUserRoleId(int id);

        public UserRole UpdateUserRole(UserRole userRole);

        public void DeleteUserRole(int id);

        public List<UserRole> GetUserRole();
    }
}