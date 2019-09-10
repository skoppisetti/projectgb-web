using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace projectgb_web.Models
{
    public class GbStation<T>
    {
        // public GbExercise Exercise {get; set;}

        [BsonElement("exercise")]
        public ObjectId ExerciseId { get; set; }

        public GbExercise Exercise {get; set;}

        [BsonElement("effort")]
        public GbReps Effort {get; set;}

        // public GbDuration ExerciseDuration {get; set;}
        public GbDuration RestDuration {get; set;}
    }
}