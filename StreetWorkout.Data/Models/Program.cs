using StreetWorkout.Data.Models.Enimerations;

namespace StreetWorkout.Data.Models
{
    public class Program
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public DifficultyEnum Difficulty { get; set; }

        public ICollection<Training> Trainings { get; set; } = new HashSet<Training>();
    }
}
