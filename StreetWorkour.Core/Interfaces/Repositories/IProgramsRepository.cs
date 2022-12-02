using StreetWorkout.Core.Models.Programs;
using StreetWorkout.Data.Models;

namespace StreetWorkout.Core.Interfaces.Repositories
{
    public interface IProgramsRepository
    {
        Task<int> AddProgramAsync(Program entity);

        Task<bool> DeleteProgramAsync(int id);

        Task<Program> GetProgramAsync(int id);

        Task<List<Program>> GetProgramsAsync();

        Task<bool> UpdateProgramAsync(int id, CoreUpdateProgramRequest request);
    }
}
