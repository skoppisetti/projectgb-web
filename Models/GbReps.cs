using MongoDB.Bson.Serialization.Attributes;

namespace projectgb_web.Models
{
    [BsonDiscriminator("reps")]
    public class GbReps : IEffort
    {
        [BsonElement("reps")]
        public int Reps {get; set;}

        [BsonElement("gap_between")]
        public int GapBetween {get; set;}
    }
}