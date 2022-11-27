namespace StreetWorkout.Core.Models.Exercises
{
    public class CoreGetExercisesRequest
    {
        public string SearchTerm { get; set; }

        public string OrderBy { get; set; }

        public bool OrderByDescending { get; set; }

        public int Skip { get; set; }

        public int Take { get; set; }
    }
}
