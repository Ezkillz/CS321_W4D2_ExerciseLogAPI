using System;
using System.Collections.Generic;
using System.Text;

namespace CS321_W4D2_ExerciseLog_API.Core.Services
{
    interface IUserRepository
    {
        // Create
        User Add(User todo);
        // Read
        User Get(int id);
        // Update
        User Update(User todo);
        // Delete
        void Remove(User todo);
        // List
        IEnumerable<User> GetAll();
    }
}
