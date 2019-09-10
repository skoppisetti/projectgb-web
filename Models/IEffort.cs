using MongoDB.Bson.Serialization.Attributes;

namespace projectgb_web.Models
{
    [BsonDiscriminator(RootClass = true)]
    [BsonKnownTypes(typeof(GbReps), typeof(GbDuration))]
    public class IEffort
    {

    }
}