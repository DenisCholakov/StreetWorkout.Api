using StreetWorkout.Data.Models.Enimerations;

namespace StreetWorkout.Api.Models.Programs
{
    public class ApiAddProgramRequest
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public DifficultyEnum Difficulty { get; set; }

        public List<ApiProgramTraining> Trainings { get; set; }
    }
}
