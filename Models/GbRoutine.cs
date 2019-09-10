using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;

namespace projectgb_web.Models
{
    public class GbRoutine
    {
        [BsonElement("stations")]
        public IEnumerable<GbStation<IEffort>> WorkoutStations {get; set;}
    }
}