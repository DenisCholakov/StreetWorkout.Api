using Microsoft.EntityFrameworkCore;
using StreetWorkout.Core.Interfaces.Repositories;
using StreetWorkout.Core.Models.Programs;
using StreetWorkout.Data;
using StreetWorkout.Data.Models;

namespace StreetWorkout.Core.Repositories
{
    public class ProgramsRepository : IProgramsRepository
    {
        private readonly ApplicationDbContext dbContext;
        private readonly DbSet<Program> programsSet;

        public ProgramsRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
            this.programsSet = this.dbContext.Set<Program>();
        }

        public async Task<Program> GetProgramAsync(int id) => await programsSet.FindAsync(id);

        public async Task<List<Program>> GetProgramsAsync() => await programsSet.ToListAsync();

        public async Task<bool> UpdateProgramAsync(int id, CoreUpdateProgramRequest request)
        {
            var program = await programsSet.FindAsync(id);

            if (program == null || string.IsNullOrEmpty(request.Name) || string.IsNullOrEmpty(request.Description))
            {
                return false;
            }

            program.Name = request.Name;
            program.Description = request.Description;

            await dbContext.SaveChangesAsync();

            return true;
        }

        public async Task<int> AddProgramAsync(Program entity)
        {
            await programsSet.AddAsync(entity);
            await dbContext.SaveChangesAsync();

            return entity.Id;
        }

        public async Task<bool> DeleteProgramAsync(int id)
        {
            var program = await programsSet.Include(x => x.ProgramTrainings).FirstOrDefaultAsync(x => x.Id == id);

            if (program == null)
            {
                return false;
            }

            programsSet.Remove(program);
            await dbContext.SaveChangesAsync();

            return true;
        }
    }
}
