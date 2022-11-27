namespace StreetWorkout.Core.Models.Exercises
{
    public class CoreAddExerciseRequest
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public List<int> EquipmentToAdd { get; set; }
    }
}
