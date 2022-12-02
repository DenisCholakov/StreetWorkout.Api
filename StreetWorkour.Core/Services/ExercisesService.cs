using AutoMapper;

using StreetWorkout.Core.Interfaces;
using StreetWorkout.Core.Interfaces.Repositories;
using StreetWorkout.Core.Models.Exercises;
using StreetWorkout.Data.Models;

namespace StreetWorkout.Core.Services
{
    public class ExercisesService : IExercisesService
    {
        private readonly IMapper mapper;
        private readonly IExercisesRepository exercisesRespository;
        private readonly IEquipmentRepository equipmentRepository;

        public ExercisesService(
            IMapper mapper, 
            IExercisesRepository exercisesRespository,
            IEquipmentRepository equipmentRepository)
        {
            this.mapper = mapper;
            this.exercisesRespository = exercisesRespository;
            this.equipmentRepository = equipmentRepository;
        }

        public async Task<CoreExercise> GetExerciseAsync(int id)
        {
            var exercise = await exercisesRespository.GetExerciseAsync(id);

            var result = mapper.Map<CoreExercise>(exercise);

            return result;
        }

        public async Task<List<CoreExercise>> GetExercisesAsync(CoreGetExercisesRequest request)
        {
            var exercises = await exercisesRespository.GetExercisesAsync(request);

            var resilt = mapper.Map<List<CoreExercise>>(exercises);

            return resilt;
        }

        public async Task<int> AddExerciseAsync(CoreAddExerciseRequest request)
        {
            var exercise = mapper.Map<Exercise>(request);

            var equipmentToAdd = await equipmentRepository.GetListAsync(request.EquipmentToAdd);

            exercise.Equipment = equipmentToAdd;

            return await exercisesRespository.AddExerciseAsync(exercise);
        }

        public async Task<bool> UpdateExerciseAsync(int id, CoreUpdateExerciseRequest request)
        {
            var result = await exercisesRespository.UpdateExerciseAsync(id, request);

            return result;
        }

        public async Task<bool> DeleteExerciseAsync(int id)
        {
            var result = await exercisesRespository.DeleteExerciseAsync(id);

            return result;
        }
    }
}
