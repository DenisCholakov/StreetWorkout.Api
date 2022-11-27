using StreetWorkout.Data.Models;

namespace StreetWorkout.Core.Interfaces.Repositories
{
    public interface IEquipmentRepository
    {
        Task<int> AddEquipmentAsync(Equipment entity);

        Task<List<Equipment>> GetListAsync();

        Task<List<Equipment>> GetListAsync(List<int> ids);
    }
}
