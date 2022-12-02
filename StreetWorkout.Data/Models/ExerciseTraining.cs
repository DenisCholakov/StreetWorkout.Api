namespace StreetWorkout.Data.Models
{
    public class ExerciseTraining
    {
        public int ExerciseId { get; set; }

        public int TrainingId { get; set; }

        public int NumberOfReps { get; set; }

        public TimeSpan BreakAfterExercise { get; set; }

        #region Navigational properties
        public Exercise Exercise { get; set; }

        public Training Training { get; set; }
        #endregion
    }
}
