using AutoMapper;

using StreetWorkout.Core.Models.Equipment;
using StreetWorkout.Data.Models;

namespace StreetWorkout.Core.Configuration.Profiles
{
    public class EquiomentProfile : Profile
    {
        public EquiomentProfile()
        {
            CreateMap<CoreAddEquipmentRequest, Equipment>();

            CreateMap<Equipment, CoreEquipment>();
        }
    }
}
