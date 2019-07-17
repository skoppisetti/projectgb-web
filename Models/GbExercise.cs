namespace projectgb_web.Models
{
    public class GbExercise
    {
        public string Name {get; set;}
        public string[] Instructions {get; set;}
        public string[] Equipment {get; set;}
        public string[] Variations {get; set;}
        public string Sponsor {get; set;}
        public string Video {get; set;}
        public string Images {get; set;}
        public string[] Tags {get; set;}
    }
}