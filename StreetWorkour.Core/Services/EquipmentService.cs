using AutoMapper;

using StreetWorkout.Core.Interfaces;
using StreetWorkout.Core.Interfaces.Repositories;
using StreetWorkout.Core.Models.Equipment;
using StreetWorkout.Data.Models;

namespace StreetWorkout.Core.Services
{
    public class EquipmentService : IEquipmentService
    {
        private readonly IMapper mapper;
        private readonly IEquipmentRepository equipmentRepository;

        public EquipmentService(IMapper mapper, IEquipmentRepository equipmentRepository)
        {
            this.mapper = mapper;
            this.equipmentRepository = equipmentRepository;
        }

        public async Task<List<CoreEquipment>> GetEquipmentAsync()
        {
            var equipment = await equipmentRepository.GetListAsync();
            var result = mapper.Map<List<CoreEquipment>>(equipment);

            return result;
        }

        public async Task<int> AddEquipmentAsync(CoreAddEquipmentRequest request)
        {
            var equipment = mapper.Map<Equipment>(request);

            return await equipmentRepository.AddEquipmentAsync(equipment);
        }
    }
}
