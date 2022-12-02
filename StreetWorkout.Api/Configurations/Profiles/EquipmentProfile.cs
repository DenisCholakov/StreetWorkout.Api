using AutoMapper;

using StreetWorkout.Api.Models.Equipment;
using StreetWorkout.Core.Models.Equipment;

namespace StreetWorkout.Api.Configurations.Profiles
{
    public class EquipmentProfile : Profile
    {
        public EquipmentProfile()
        {
            CreateMap<ApiAddEquipmentRequest, CoreAddEquipmentRequest>();

            CreateMap<CoreEquipment, ApiEquipment>();
        }
    }
}
