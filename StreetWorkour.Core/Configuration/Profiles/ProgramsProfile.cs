using AutoMapper;

using StreetWorkout.Core.Models.Programs;
using StreetWorkout.Data.Models;

namespace StreetWorkout.Core.Configuration.Profiles
{
    public class ProgramsProfile : Profile
    {
        public ProgramsProfile()
        {
            CreateMap<CoreAddProgramRequest, Program>()
                .ForMember(dest => dest.ProgramTrainings, opt => opt.MapFrom(src => src.Trainings));

            CreateMap<Program, CoreProgram>();
        }
    }
}
