using StreetWorkout.Data.Models.Enimerations;

namespace StreetWorkout.Core.Models.Programs
{
    public class CoreAddProgramRequest
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public DifficultyEnum Difficulty { get; set; }

        public List<CoreProgramTraining> Trainings { get; set; }
    }
}
