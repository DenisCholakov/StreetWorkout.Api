using AutoMapper;
using StreetWorkout.Core.Interfaces;
using StreetWorkout.Core.Interfaces.Repositories;
using StreetWorkout.Core.Models.Programs;
using StreetWorkout.Data.Models;

namespace StreetWorkout.Core.Services
{
    public class ProgramsService : IProgramsService
    {
        private readonly IMapper mapper;
        private readonly IProgramsRepository programsRepository;

        public ProgramsService(IMapper mapper, IProgramsRepository programsRepository)
        {
            this.mapper = mapper;
            this.programsRepository = programsRepository;
        }

        public async Task<int> AddProgramAsync(CoreAddProgramRequest request)
        {
            var program = mapper.Map<Program>(request);

            var result = await programsRepository.AddProgramAsync(program);

            return result;
        }

        public async Task<bool> DeleteProgramAsync(int id)
        {
            var result = await programsRepository.DeleteProgramAsync(id);

            return result;
        }

        public async Task<CoreProgram> GetProgramAsync(int id)
        {
            var program = await programsRepository.GetProgramAsync(id);

            var result = mapper.Map<CoreProgram>(program);

            return result;
        }

        public async Task<List<CoreProgram>> GetProgramsAsync()
        {
            var programs = await programsRepository.GetProgramsAsync();

            var result = mapper.Map<List<CoreProgram>>(programs);

            return result;
        }

        public async Task<bool> UpdateProgramAsync(int id, CoreUpdateProgramRequest request)
        {
            var result = await programsRepository.UpdateProgramAsync(id, request);

            return result;
        }
    }
}
