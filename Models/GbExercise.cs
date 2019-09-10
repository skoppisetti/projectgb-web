using MongoDB.Bson.Serialization.Attributes;

namespace projectgb_web.Models
{
    public class GbExercise
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string Id { get; set; }
        
        [BsonElement("name")]
        public string Name {get; set;}
        
        [BsonElement("description")]
        public string Description {get; set;}
        
        [BsonElement("instructions")]
        public string[] Instructions {get; set;}
        
        [BsonElement("equipment")]
        public string[] Equipment {get; set;}
        
        [BsonElement("variations")]
        public string[] Variations {get; set;}
        
        [BsonElement("sponsor")]
        public string Sponsor {get; set;}
        
        [BsonElement("video")]
        public string Video {get; set;}
        //public GbVisual Video {get; set;}
        
        [BsonElement("images")]
        public string[] Images {get; set;}
        //public GbVisual[] Images {get; set;}
        
        [BsonElement("tags")]
        public string[] Tags {get; set;}
    }
}