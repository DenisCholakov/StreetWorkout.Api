using StreetWorkout.Data.Models;
using StreetWorkout.Core.Models;

namespace StreetWorkout.Core.Interfaces.Repositories
{
    public interface ITrainingsRepository
    {
        Task<int> AddTrainingAsync(Training entity);

        Task<bool> AddTrainingExerciseAsync(int trainingId, int exerciseId);

        Task<bool> DeleteTrainingAsync(int id);

        Task<Training> GetTrainingAsync(int id);

        Task<List<Training>> GetTrainingsAsync();

        Task<bool> UpdateTrainingAsync(int id, CoreUpdateTrainingRequest request);
    }
}
