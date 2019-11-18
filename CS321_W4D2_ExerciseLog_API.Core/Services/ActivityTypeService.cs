using System;
using System.Collections.Generic;
using System.Text;
using CS321_W4D2_ExerciseLog_API.Core.Models;

namespace CS321_W4D2_ExerciseLog_API.Core.Services
{
    class ActivityTypeService : IActivityTypeRepository
    {
        private IUserRepository _userRepo;

        public ActivityTypeService(IActivityTypeRepository activityTypeRepo)
        {
            _userRepo = userRepo;
        }
        public ActivityType Add(ActivityType newActivityType)
        {
            return _activityTypeRepo.Add(newActivityType);
        }

        public ActivityType Get(int id)
        {
            return _activityTypeRepo.Get(id);
        }
        public ActivityType Update(ActivityType updatedActivityType)
        {
            return _activityTypeRepo.Update(updatedActivityType);
        }
        public void Remove(ActivityType activityType)
        {
            _activityTypeRepo.Remove(activityType);
            _activityTypeRepo.SaveChanges();
        }
        public IEnumerable<ActivityType> GetAll()
        {
            return _activityTypeRepo.GetAll();
        }

    }
}
