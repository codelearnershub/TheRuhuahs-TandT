using System.Collections.Generic;
using System.Linq;
using TheRuhuahs_TandT.Models;

namespace TheRuhuahs_TandT.Repositories
{
    public class UserRoleRepository
    {
        public readonly ApplicationDbContext _dbContext;
        public UserRoleRepository(ApplicationDbContext dBContext)
        { _dbContext = dBContext; }
        public UserRole AddUserRole(UserRole userRole)
        {
            _dbContext.UserRoles.Add(userRole);
            _dbContext.SaveChanges();
            return userRole;
        }
        public UserRole FindUserRoleByEmail(UserRole userRole)
        {
            return _dbContext.UserRoles.Find(userRole);
        }
        public UserRole FindByUserRoleId(int id)
        {
            return _dbContext.UserRoles.Find(id);
        }
        public UserRole UpdateUserRole(UserRole userRole)
        {
            _dbContext.UserRoles.Update(userRole);
            _dbContext.SaveChanges();
            return userRole;
        }
        public void DeleteUserRole(int id)
        {
            var userRole = FindByUserRoleId(id);

            if (userRole != null)
            {
                _dbContext.UserRoles.Remove(userRole);
                _dbContext.SaveChanges();
            }
        }
        public List<UserRole> GetUser()
        {
            return _dbContext.UserRoles.ToList();
        }
    }
}