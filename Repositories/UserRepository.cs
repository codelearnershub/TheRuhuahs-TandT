using System.Collections.Generic;
using System.Linq;
using TheRuhuahs_TandT.Models;

namespace TheRuhuahs_TandT.Repositories
{
    public class UserRepository : IUserRepository
    {
        public readonly ApplicationDbContext _dbContext;
        public UserRepository(ApplicationDbContext dBContext)
        { _dbContext = dBContext; }
        public User AddUser(User user)
        {
            _dbContext.Users.Add(user);
            _dbContext.SaveChanges();
            return user;
        }
        public User FindUserByEmail(User user)
        {
            return _dbContext.Users.Find(user);
        }
        public User FindByUserId(int id)
        {
            return _dbContext.Users.Find(id);
        }
        public User UpdateUser(User user)
        {
            _dbContext.Users.Update(user);
            _dbContext.SaveChanges();
            return user;
        }
        public void DeleteUser(int id)
        {
            var user = FindByUserId(id);

            if (user != null)
            {
                _dbContext.Users.Remove(user);
                _dbContext.SaveChanges();
            }
        }
        public List<User> GetUser()
        {
            return _dbContext.Users.ToList();
        }
    }
}