using System.Collections.Generic;
using CS321_W4D2_ExerciseLog_API.Core.Models;

namespace CS321_W4D2_ExerciseLog_API.Core.Services
{
    interface IActivityService
    {
        Activity Add(Activity newActivity);
        Activity Get(int id);
        ICollection<Activity> GetAll();
        void Remove(Activity activity);
        Activity Update(Activity updatedActivity);
    }
}