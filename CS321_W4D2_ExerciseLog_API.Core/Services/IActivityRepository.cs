﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CS321_W4D2_ExerciseLog_API.Core.Services
{
    interface IActivityRepository
    {
        // Create
        Activity Add(Activity todo);
        // Read
        Activity Get(int id);
        // Update
        Activity Update(Activity todo);
        // Delete
        void Remove(Activity todo);
        // List
        IEnumerable<Activity> GetAll();
    }
}
