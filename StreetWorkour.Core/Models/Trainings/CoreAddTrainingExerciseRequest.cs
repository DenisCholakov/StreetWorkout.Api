namespace StreetWorkout.Core.Models.Trainings
{
    public class CoreAddTrainingExerciseRequest
    {
        public int TrainingId { get; set; }

        public int ExerciseId { get; set; }

        public int NumberOfReps { get; set; }

        public TimeSpan BreakAfterExercise { get; set; }
    }
}
