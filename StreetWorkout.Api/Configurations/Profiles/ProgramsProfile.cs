using AutoMapper;

using StreetWorkout.Api.Models.Programs;
using StreetWorkout.Core.Models;
using StreetWorkout.Core.Models.Programs;

namespace StreetWorkout.Api.Configurations.Profiles
{
    public class ProgramsProfile : Profile
    {
        public ProgramsProfile()
        {
            CreateMap<ApiAddProgramRequest, CoreAddProgramRequest>();
            CreateMap<ApiProgramTraining, CoreProgramTraining>();
        }
    }
}
