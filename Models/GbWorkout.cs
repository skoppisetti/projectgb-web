using System.Collections.Generic;

namespace projectgb_web.Models
{
    public class GbWorkout
    {
        public string Name {get; set;}
        public string Description {get; set;}
        public IEnumerable<string> Tags {get; set;}
        public GbRoutine WorkoutRoutine{get; set;}
    }
}