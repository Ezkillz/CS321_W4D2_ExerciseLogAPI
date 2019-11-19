using System;
using System.Collections.Generic;
using System.Text;
using CS321_W4D2_ExerciseLog_API.Core.Models;

namespace CS321_W4D2_ExerciseLog_API.Core.Services
{
    class ActivityService : IActivityService
, IActivityService
    {
        private IActivityRepository _activityRepo;

        public ActivityService(IActivityRepository activityRepo)
        {
            _activityRepo = activityRepo;
        }
        public Activity Add(Activity newActivity)
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
        public void Remove(Activity activity)
        {
            _activityRepo.Remove(activity);
            _activityRepo.SaveChanges();
        }
        public ICollection<Activity> GetAll()
        {
            return _activityRepo.GetAll();
        }

    }
}
