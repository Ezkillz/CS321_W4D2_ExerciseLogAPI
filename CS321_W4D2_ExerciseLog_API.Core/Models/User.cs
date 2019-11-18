using System;
using System.Collections.Generic;
using System.Text;

namespace CS321_W4D2_ExerciseLog_API.Core.Models
{
    class User
    {
        public int Id { get; set; }
        public ICollection<Activity> Activities { get; set; }
    }
}
