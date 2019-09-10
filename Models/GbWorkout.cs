using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;

namespace projectgb_web.Models
{
    [BsonIgnoreExtraElements]
    public class GbWorkout
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("name")]
        public string Name { get; set; }

        [BsonElement("document")]
        public string Description { get; set; }

        [BsonElement("tags")]
        public IEnumerable<string> Tags { get; set; }

        [BsonElement("routine")]
        public GbRoutine WorkoutRoutine{get; set;}

        // [BsonElement("routine")]
        // [BsonKnownTypes(typeof(GbReps), typeof(GbDuration))]
        // public GbStation<IEffort>[] WorkoutRoutine { get; set; }
    }
}