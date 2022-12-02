namespace StreetWorkout.Api.Models.Programs
{
    public class ApiProgramTraining
    {
        public int ProgramId { get; set; } = 0;

        public int TrainingId { get; set; } = 0;

        public DayOfWeek DayOfWeek { get; set; }
    }
}
