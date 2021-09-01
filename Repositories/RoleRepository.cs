using System.Collections.Generic;
using System.Linq;
using TheRuhuahs_TandT.Interface;
using TheRuhuahs_TandT.Models;

namespace TheRuhuahs_TandT.Repositories
{
   public class RoleRepository : IRoleRepository
    {
        public readonly ApplicationDbContext _dbContext;
        public RoleRepository(ApplicationDbContext dBContext)
        { _dbContext = dBContext; }
        public Role AddRole(Role role)
        {
            _dbContext.Roles.Add(role);
            _dbContext.SaveChanges();
            return role;
        }
        public Role FindByRoleId(int id)
        {
            return _dbContext.Roles.Find(id);
        }
        public Role UpdateRole(Role role)
        {
            _dbContext.Roles.Update(role);
            _dbContext.SaveChanges();
            return role;
        }
        public void DeleteRole(int id)
        {
            var role = FindByRoleId(id);

            if (role != null)
            {
                _dbContext.Roles.Remove(role);
                _dbContext.SaveChanges();
            }
        }
        public List<Role> GetRole()
        {
            return _dbContext.Roles.ToList();
        }
    }
}