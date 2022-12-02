using StreetWorkout.Core.Models.Exercises;

namespace StreetWorkout.Core.Interfaces
{
    public interface IExercisesService
    {
        Task<int> AddExerciseAsync(CoreAddExerciseRequest request);

        Task<bool> DeleteExerciseAsync(int id);

        Task<CoreExercise> GetExerciseAsync(int id);

        Task<List<CoreExercise>> GetExercisesAsync(CoreGetExercisesRequest request);

        Task<bool> UpdateExerciseAsync(int id, CoreUpdateExerciseRequest request);
    }
}
