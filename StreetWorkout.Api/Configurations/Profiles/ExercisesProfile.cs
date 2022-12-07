using AutoMapper;

using StreetWorkout.Api.Models.Exercises;
using StreetWorkout.Core.Models.Exercises;

namespace StreetWorkout.Api.Configurations.Profiles
{
    public class ExercisesProfile : Profile
    {
        public ExercisesProfile()
        {
            CreateMap<CoreExercise, ApiExercise>();

            CreateMap<ApiAddExerciseRequest, CoreAddExerciseRequest>();
        }
    }
}
