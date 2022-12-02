using Microsoft.EntityFrameworkCore;
using StreetWorkout.Data;
using StreetWorkout.Data.Models;
using StreetWorkout.Core.Interfaces.Repositories;
using StreetWorkout.Core.Models;

namespace StreetWorkout.Core.Repositories
{
    public class TrainingsRepository : ITrainingsRepository
    {
        private readonly ApplicationDbContext dbContext;

        public TrainingsRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<Training> GetTrainingAsync(int id)
        {
            var training = await dbContext.Set<Training>().FindAsync(id);

            return training;
        }

        public async Task<List<Training>> GetTrainingsAsync()
        {
            var trainings = await dbContext.Set<Training>().ToListAsync();

            return trainings;
        }

        public async Task<int> AddTrainingAsync(Training entity)
        {
            await dbContext.Set<Training>().AddAsync(entity);
            await dbContext.SaveChangesAsync();

            return entity.Id;
        }

        public async Task<bool> AddTrainingExerciseAsync(ExerciseTraining entity)
        {
            if (entity == null)
            {
                return false;
            }

            await dbContext.Set<ExerciseTraining>().AddAsync(entity);
            await dbContext.SaveChangesAsync();

            return true;
        }

        public async Task<bool> UpdateTrainingAsync(int id, CoreUpdateTrainingRequest request)
        {
            var training  = await dbContext.Set<Training>().FindAsync(id);

            if (training == null)
            {
                return false;
            }

            training.Name = request.Name;
            training.Description = request.Description;

            await dbContext.SaveChangesAsync();

            return true;
        }

        public async Task<bool> DeleteTrainingAsync(int id)
        {
            var training = await dbContext.Set<Training>().FindAsync(id);

            if (training == null)
            {
                return false;
            }

            dbContext.Set<Training>().Remove(training);
            await dbContext.SaveChangesAsync();

            return true;
        }
    }
}
