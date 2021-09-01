using System.Collections.Generic;
using TheRuhuahs_TandT.Models;

namespace TheRuhuahs_TandT.Interface
{
    public interface IRoleRepository
    {
        public Role AddRole(Role role);

        public Role FindByRoleId(int id);

        public Role UpdateRole(Role role);

        public void DeleteRole(int id);

        public List<Role> GetRole();
    }
}