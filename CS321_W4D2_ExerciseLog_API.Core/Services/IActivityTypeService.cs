using System.Collections.Generic;
using CS321_W4D2_ExerciseLog_API.Core.Models;

namespace CS321_W4D2_ExerciseLog_API.Core.Services
{
    interface IActivityTypeService
    {
        ActivityType Add(ActivityType newActivityType);
        ActivityType Get(int id);
        IEnumerable<ActivityType> GetAll();
        void Remove(ActivityType activityType);
        ActivityType Update(ActivityType updatedActivityType);
    }
}