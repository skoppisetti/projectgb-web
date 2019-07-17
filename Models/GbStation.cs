namespace projectgb_web.Models
{
    public class GbStation<T>
    {
        public GbExercise Exercise {get; set;}
        public GbEffort<T> Effort {get; set;}
        // public GbDuration ExerciseDuration {get; set;}
        public GbDuration RestDuration {get; set;}
    }
}