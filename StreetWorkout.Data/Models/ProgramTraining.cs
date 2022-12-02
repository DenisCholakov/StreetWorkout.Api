namespace StreetWorkout.Data.Models
{
    public class ProgramTraining
    {
        public int Id { get; set; }

        public int TrainingId { get; set; }

        public int ProgramId { get; set; }

        public DayOfWeek DayOfWeek { get; set; }

        #region Navigational properties
        public Training Training { get; set; }

        public Program Program { get; set; }
        #endregion
    }
}
