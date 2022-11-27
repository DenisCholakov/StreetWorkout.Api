using StreetWorkout.Data.Models.Enimerations;

namespace StreetWorkout.Core.Models
{
    public class CoreTraining
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public DifficultyEnum Difficulty { get; set; }
    }
}
