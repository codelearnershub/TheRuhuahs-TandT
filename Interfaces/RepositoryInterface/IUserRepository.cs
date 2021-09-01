using System.Collections.Generic;
using TheRuhuahs_TandT.Models;

namespace TheRuhuahs_TandT.Repositories
{
    public interface IUserRepository

    {
        public User AddUser(User user);

        public User FindByUserId(int id);

        public User FindUserByEmail(User user);

        public User UpdateUser(User user);

        public void DeleteUser(int id);

        public List<User> GetUser();

        
       
    }
}