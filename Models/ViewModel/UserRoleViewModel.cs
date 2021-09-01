using System.Collections.Generic;

namespace TheRuhuahs_TandT.Models.ViewModel
{
    public class UserRoleViewModel
    {
        public int UserId { get; set;}

        public int RoleId { get; set;}

        public List<Role> Roles { get; set;}

        public List<User> Users { get; set;}
    }
    public class CreateUserRoleViewModel
    {
        public int UserId { get; set;}

        public int RoleId { get; set;}

        public List<Role> Roles { get; set;}

        public List<User> Users { get; set;}
    }
    public class UpdateUserRoleViewModel
    {
        public int UserId { get; set;}

        public int RoleId { get; set;}

        public List<Role> Roles { get; set;}

        public List<User> Users { get; set;}
    }
}