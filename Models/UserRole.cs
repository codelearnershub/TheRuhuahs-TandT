using System.Collections.Generic;

namespace TheRuhuahs_TandT.Models
{
    public class UserRole : BaseEntity
    {
        public int UserId { get; set;}

        public int RoleId { get; set;}

        public List<Role> Roles { get; set;}

        public List<User> Users { get; set;}
    }
}