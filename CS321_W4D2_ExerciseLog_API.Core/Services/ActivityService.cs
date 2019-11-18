using System;
using System.Collections.Generic;
using System.Text;
using CS321_W4D2_ExerciseLog_API.Core.Models;

namespace CS321_W4D2_ExerciseLog_API.Core.Services
{
    class ActivityService : IActivityRepository
    {
        private IActivityRepository _activityRepo;

        public ActivityService(IUserRepository activityRepo)
        {
            _activityRepo = activityRepo;
        }
        public Activity Add(Activity newactivity)
        {
            return _activityRepo.Add(newActivity);
        }

        public Activity Get(int id)
        {
            return _activityRepo.Get(id);
        }
        public Activity Update(Activity updatedActivity)
        {
            return _activityRepo.Update(updatedActivity);
        }
        public void Remove(Activity user)
        {
            _activityRepo.Remove(activity);
            _activityRepo.SaveChanges();
        }
        public IEnumerable<Activity> GetAll()
        {
            return _activityRepo.GetAll();
        }

    }
}
