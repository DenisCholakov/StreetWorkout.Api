using Microsoft.EntityFrameworkCore;
using StreetWorkout.Data.Models;

namespace StreetWorkout.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base()
        {
        }

        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Equipment> Equipment { get; set; }

        public DbSet<Exercise> Exercises { get; set; }

        public DbSet<Training> Trainings { get; set; }

        public DbSet<Program> Programs { get; set; }

        public DbSet<ExerciseTraining> ExerciseTrainings { get; set; }

        public DbSet<ProgramTraining> ProgramTrainings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
        }
    }
}
