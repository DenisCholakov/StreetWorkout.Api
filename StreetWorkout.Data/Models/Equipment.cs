namespace StreetWorkout.Data.Models
{
    public class Equipment
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<Exercise> Exercises { get; set; } = new HashSet<Exercise>();
    }
}
