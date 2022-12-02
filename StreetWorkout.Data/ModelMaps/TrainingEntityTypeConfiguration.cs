using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StreetWorkout.Data.Models;

namespace StreetWorkout.Data.ModelMaps
{
    public class TrainingEntityTypeConfiguration : IEntityTypeConfiguration<Training>
    {
        public void Configure(EntityTypeBuilder<Training> builder)
        {
            builder.ToTable("Trainings");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .HasColumnName("Id")
                .HasColumnType("int")
                .ValueGeneratedOnAdd()
                .IsRequired();

            builder.Property(x => x.Name)
                .HasColumnName(@"Name")
                .HasColumnType("nvarchar(40)")
                .IsRequired();

            builder.Property(x => x.Description)
                .HasColumnName("Description")
                .HasColumnType("nvarchar(400)")
                .IsRequired();

            builder.Property(x => x.Difficulty)
                .HasColumnName(@"Difficulty")
                .HasColumnType("smallint")
                .IsRequired();

            builder
                .HasMany(x => x.ExerciseTrainings)
                .WithOne(x => x.Training)
                .HasForeignKey(x => x.TrainingId);

            builder
                .HasMany(x => x.ProgramTrainings)
                .WithOne(x => x.Training)
                .HasForeignKey(x => x.TrainingId);

            builder.HasData(
                new Training
                {
                    Id = 1,
                    Name = "Pull push",
                    Description = "Evereyone should start with this training",
                    Difficulty = Models.Enimerations.DifficultyEnum.Begginer
                });
        }
    }
}
