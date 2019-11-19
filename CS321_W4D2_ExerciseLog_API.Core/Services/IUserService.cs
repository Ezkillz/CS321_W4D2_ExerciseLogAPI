using System.Collections.Generic;
using CS321_W4D2_ExerciseLog_API.Core.Models;

namespace CS321_W4D2_ExerciseLog_API.Core.Services
{
    interface IUserService
    {
        User Add(User newUser);
        User Get(int id);
        IEnumerable<User> GetAll();
        void Remove(User user);
        User Update(User updatedUser);
    }
}