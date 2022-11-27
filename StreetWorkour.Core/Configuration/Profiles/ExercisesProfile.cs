using AutoMapper;

using StreetWorkout.Data.Models;
using StreetWorkout.Core.Models.Exercises;

namespace StreetWorkout.Core.Configuration.Profiles
{
    public class ExercisesProfile : Profile
    {
        public ExercisesProfile()
        {
            CreateMap<Exercise, CoreExercise>();
        }
    }
}
