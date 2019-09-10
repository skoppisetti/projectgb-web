using System;
using MongoDB.Bson.Serialization.Attributes;

namespace projectgb_web.Models
{
    [BsonDiscriminator("duration")]
    public class GbDuration : IEffort
    {
        public int Hours {get; set;}
        public int Minutes {get; set;}
        public int Seconds {get; set;}
        public TimeSpan ToTimeSpan() => throw new NotImplementedException();
    }
}