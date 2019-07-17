using System;

namespace projectgb_web.Models
{
    public class GbDuration : IEffort
    {
        public int Hours {get; set;}
        public int Minutes {get; set;}
        public int Seconds {get; set;}
        public TimeSpan ToTimeSpan() => throw new NotImplementedException();
    }
}