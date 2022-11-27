using StreetWorkout.Core.Models.Equipment;

namespace StreetWorkout.Core.Interfaces
{
    public interface IEquipmentService
    {
        Task<int> AddEquipmentAsync(CoreAddEquipmentRequest request);
    }
}
