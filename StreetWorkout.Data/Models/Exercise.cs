namespace StreetWorkout.Data.Models
{
    public class Exercise
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string ImageUrl { get; set; }

        public string Description { get; set; }

        public ICollection<Equipment> Equipment { get; set; } = new HashSet<Equipment>();

        public ICollection<ExerciseTraining> ExerciseTrainings { get; set; } = new HashSet<ExerciseTraining>();
    }
}
