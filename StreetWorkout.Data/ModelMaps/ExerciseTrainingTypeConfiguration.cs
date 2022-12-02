using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StreetWorkout.Data.Models;

namespace StreetWorkout.Data.ModelMaps
{
    public class ExerciseTrainingTypeConfiguration : IEntityTypeConfiguration<ExerciseTraining>
    {
        public void Configure(EntityTypeBuilder<ExerciseTraining> builder)
        {
            builder.ToTable("ExerciseTraining");

            builder.HasKey(x => new { x.ExerciseId, x.TrainingId });

            builder.Property(x => x.ExerciseId)
                .HasColumnName(@"ExerciseId")
                .HasColumnType("int")
                .IsRequired();

            builder.Property(x => x.TrainingId)
                .HasColumnName(@"TrainingId")
                .HasColumnType("int")
                .IsRequired();

            builder.Property(x => x.NumberOfReps)
                .HasColumnName(@"NumberOfReps")
                .HasColumnType("int")
                .IsRequired();

            builder.Property(x => x.BreakAfterExercise)
                .HasColumnName(@"BreakAfterExercise")
                .HasColumnType("time")
                .IsRequired();

            builder
                .HasOne(x => x.Exercise)
                .WithMany(x => x.ExerciseTrainings)
                .HasForeignKey(x => x.ExerciseId);

            builder
                .HasOne(x => x.Training)
                .WithMany(x => x.ExerciseTrainings)
                .HasForeignKey(x => x.TrainingId);

            builder.HasData(
                new ExerciseTraining
                {
                    ExerciseId = 1,
                    TrainingId = 1,
                    NumberOfReps = 10,
                    BreakAfterExercise = new TimeSpan(0, 1, 0)
                },
                new ExerciseTraining
                {
                    ExerciseId = 2,
                    TrainingId = 1,
                    NumberOfReps = 25,
                    BreakAfterExercise = new TimeSpan(0, 1, 0)
                });
        }
    }
}
