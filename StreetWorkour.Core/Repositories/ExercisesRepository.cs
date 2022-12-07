using Microsoft.EntityFrameworkCore;

using StreetWorkout.Core.Interfaces.Repositories;
using StreetWorkout.Core.Models.Exercises;
using StreetWorkout.Data;
using StreetWorkout.Data.Models;

namespace StreetWorkout.Core.Repositories
{
    public class ExercisesRepository : IExercisesRepository
    {
        private readonly ApplicationDbContext dbContext;

        public ExercisesRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<Exercise> GetExerciseAsync(int exerciseId)
        {
            var exercise = await dbContext.Set<Exercise>().FindAsync(exerciseId);

            return exercise;
        }

        public async Task<List<Exercise>> GetExercisesAsync()
        {
            var employees = await dbContext.Exercises.ToListAsync();

            return employees;
        }

        public async Task<int> AddExerciseAsync(Exercise entity)
        {
            await dbContext.Set<Exercise>().AddAsync(entity);

            await dbContext.SaveChangesAsync();

            return entity.Id;
        }

        public async Task<bool> UpdateExerciseAsync(
            int exerciseId, CoreUpdateExerciseRequest request)
        {
            var exercise = await dbContext.Set<Exercise>().FindAsync(exerciseId);

            if (exercise == null)
            {
                return false;
            }

            exercise.Name = request.Name;
            exercise.Description = request.Description;

            dbContext.SaveChanges();

            return true;
        }

        public async Task<bool> DeleteExerciseAsync(int id)
        {
            var exerciseToDelete = await dbContext.Set<Exercise>()
                .Include(x => x.Equipment)
                .Include(x => x.ExerciseTrainings)
                .FirstOrDefaultAsync(x => x.Id == id);

            if (exerciseToDelete == null || exerciseToDelete.ExerciseTrainings.Any())
            {
                return false;
            }

            dbContext.Set<Exercise>().Remove(exerciseToDelete);

            await dbContext.SaveChangesAsync();

            return true;
        }
    }
}
