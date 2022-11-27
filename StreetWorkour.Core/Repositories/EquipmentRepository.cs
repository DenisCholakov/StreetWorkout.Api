using Microsoft.EntityFrameworkCore;
using StreetWorkout.Core.Interfaces.Repositories;
using StreetWorkout.Data;
using StreetWorkout.Data.Models;

namespace StreetWorkout.Core.Repositories
{
    public class EquipmentRepository : IEquipmentRepository
    {
        private readonly DbSet<Equipment> equipmentSet;
        private readonly ApplicationDbContext dbContext;

        public EquipmentRepository(ApplicationDbContext dbContext)
        {
            this.equipmentSet = dbContext.Equipment;
            this.dbContext = dbContext;
        }

        public async Task<List<Equipment>> GetListAsync() => await equipmentSet.ToListAsync();

        public async Task<List<Equipment>> GetListAsync(List<int> ids) =>
            await equipmentSet.Where(x => ids.Contains(x.Id)).ToListAsync();

        public async Task<int> AddEquipmentAsync(Equipment entity)
        {
            await equipmentSet.AddAsync(entity);
            await dbContext.SaveChangesAsync();

            return entity.Id;
        }
    }
}
