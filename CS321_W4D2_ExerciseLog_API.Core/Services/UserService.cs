using CS321_W4D2_ExerciseLog_API.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CS321_W4D2_ExerciseLog_API.Core.Services
{
    class UserService : IUserService
    {
        private IUserRepository _userRepo;

        public UserService(IUserRepository userRepo)
        {
            _userRepo = userRepo;
        }
        public User Add(User newUser)
        {
            return _userRepo.Add(newUser);
        }

        public User Get(int id)
        {
            return _userRepo.Get(id);
        }
        public User Update(User updatedUser)
        {
            return _userRepo.Update(updatedUser);
        }
        public void Remove(User user)
        {
            _userRepo.Remove(user);
            _userRepo.SaveChanges();
        }
        public IEnumerable<User> GetAll()
        {
            return _userRepo.GetAll();
        }

    }
}
