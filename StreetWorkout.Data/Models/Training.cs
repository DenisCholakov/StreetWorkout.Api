using StreetWorkout.Data.Models.Enimerations;

namespace StreetWorkout.Data.Models
{
    public class Training
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public DifficultyEnum Difficulty { get; set; }

        public ICollection<Exercise> Exercises { get; set; } = new HashSet<Exercise>();

        public ICollection<Program> Programs { get; set; } = new HashSet<Program>();
    }
}
