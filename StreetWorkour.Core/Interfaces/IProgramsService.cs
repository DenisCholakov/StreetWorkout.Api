using StreetWorkout.Core.Models.Programs;
using StreetWorkout.Data.Models;

namespace StreetWorkout.Core.Interfaces
{
    public interface IProgramsService
    {
        Task<int> AddProgramAsync(CoreAddProgramRequest request);

        Task<bool> DeleteProgramAsync(int id);

        Task<CoreProgram> GetProgramAsync(int id);

        Task<List<CoreProgram>> GetProgramsAsync();

        Task<bool> UpdateProgramAsync(int id, CoreUpdateProgramRequest request);
    }
}
