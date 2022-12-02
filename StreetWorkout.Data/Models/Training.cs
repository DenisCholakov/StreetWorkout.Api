using StreetWorkout.Data.Models.Enimerations;

namespace StreetWorkout.Data.Models
{
    public class Training
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public DifficultyEnum Difficulty { get; set; }

        public ICollection<ExerciseTraining> ExerciseTrainings { get; set; } = new HashSet<ExerciseTraining>();

        public ICollection<ProgramTraining> ProgramTrainings { get; set; } = new HashSet<ProgramTraining>();
    }
}
