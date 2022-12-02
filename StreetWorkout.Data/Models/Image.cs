using StreetWorkout.Data.Models.Enimerations;

namespace StreetWorkout.Data.Models
{
    public class Image
    {
        public int Id { get; set; }

        public int ObjectId { get; set; }

        public ImageTypeEnum Type { get; set; }

        public string ImageTitle { get; set; }

        public byte[] ImageData { get; set; }
    }
}
