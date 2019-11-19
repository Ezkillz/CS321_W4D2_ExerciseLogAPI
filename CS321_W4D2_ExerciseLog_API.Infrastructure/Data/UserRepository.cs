using System;
using System.Collections.Generic;
using System.Text;
using CS321_W4D2_ExerciseLog_API.Core.Models;

namespace CS321_W4D2_ExerciseLog_API.Infrastructure.Data
{
    class UserRepository : IUserRepository
    {
        private readonly AppDbContext _dbContext;

        public UserRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
