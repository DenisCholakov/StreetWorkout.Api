using StreetWorkout.Core.Models.Exercises;
using StreetWorkout.Data.Models;

namespace StreetWorkout.Core.Interfaces.Repositories
{
    public interface IExercisesRepository
    {
        Task<int> AddExerciseAsync(Exercise entity);

        Task<bool> DeleteExercise(int id);

        Task<Exercise> GetExerciseAsync(int exerciseId);

        Task<List<Exercise>> GetExercisesAsync(CoreGetExercisesRequest request);

        Task<bool> UpdateExerciseAsync(int exerciseId, CoreUpdateExerciseRequest request);
    }
}
