using System.Collections.Generic;

namespace projectgb_web.Models
{
    public class GbRoutine
    {
        public IEnumerable<GbStation<IEffort>> WorkoutStations {get; set;}
    }
}