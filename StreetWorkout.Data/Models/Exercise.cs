namespace StreetWorkout.Data.Models
{
    public class Exercise
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public ICollection<Training> Trainings { get; set; } = new HashSet<Training>();

        public ICollection<Equipment> Equipment { get; set; } = new HashSet<Equipment>();
    }
}
