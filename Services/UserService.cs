using System.Collections.Generic;
using System.Linq;
using TheRuhuahs_TandT.Interface;
using TheRuhuahs_TandT.Models;
using TheRuhuahs_TandT.Models.ViewModel;
using TheRuhuahs_TandT.Repositories;


namespace TheRuhuahs_TandT.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public User AddUser(CreateUserViewModel model)
        {
            var user = new User
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                Email = model.Email,
                Gender = model.Gender,
                Mobile = model.Mobile,
                DateOfBirth = model.DateOfBirth,
                StreetAddress = model.StreetAddress,
                State = model.State,
                Country = model.Country

            };
            if(model.Email == user.Email)
            {
               
            }
            return _userRepository.AddUser(user);
        }
        public User UpdateUser(User user)
        {
            return _userRepository.UpdateUser(user);
        }

        public User FindByUserId(int id)
        {
            return _userRepository.FindByUserId(id);
        }

        public void DeleteUser(int id)
        {
            _userRepository.DeleteUser(id);
        }
        public List<UserViewModel> GetUser()
        {
            var user = _userRepository.GetUser().Select(c => new UserViewModel
            {
                FirstName = c.FirstName,
                LastName = c.LastName,
                Email = c.Email,
               Gender = c.Gender,
               Mobile = c.Mobile,
               DateOfBirth = c.DateOfBirth,
               StreetAddress = c.StreetAddress,
               State = c.State,
               Country = c.Country
               
            }).ToList();

            return user;
        }
    }    
}