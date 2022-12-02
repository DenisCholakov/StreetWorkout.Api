using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StreetWorkout.Data.Models;

namespace StreetWorkout.Data.ModelMaps
{
    internal class ProgramTrainingTypeConfiguration : IEntityTypeConfiguration<ProgramTraining>
    {
        public void Configure(EntityTypeBuilder<ProgramTraining> builder)
        {
            builder.ToTable("ProgramTraining", "dbo");

            builder.HasKey(x => x.Id);

            builder
                .Property(x => x.Id)
                .HasColumnName(@"Id")
                .HasColumnType("int")
                .ValueGeneratedOnAdd()
                .IsRequired();

            builder
                .Property(x => x.TrainingId)
                .HasColumnName(@"TrainingId")
                .HasColumnType("int")
                .IsRequired();

            builder
                .Property(x => x.ProgramId)
                .HasColumnName("ProgramId")
                .HasColumnType("int")
                .IsRequired();

            builder
                .Property(x => x.DayOfWeek)
                .HasColumnName("DayOfWeek")
                .HasColumnType("int")
                .IsRequired();

            builder
                .HasOne(x => x.Training)
                .WithMany(x => x.ProgramTrainings)
                .HasForeignKey(x => x.TrainingId);

            builder
                .HasOne(x => x.Program)
                .WithMany(x => x.ProgramTrainings)
                .HasForeignKey(x => x.ProgramId);

            builder
                .HasData(
                new ProgramTraining
                {
                    Id = 1,
                    TrainingId = 1,
                    ProgramId =1,
                    DayOfWeek = DayOfWeek.Monday,
                },
                new ProgramTraining
                {
                    Id = 2,
                    TrainingId = 1,
                    ProgramId = 1,
                    DayOfWeek = DayOfWeek.Wednesday,
                },
                new ProgramTraining
                {
                    Id = 3,
                    TrainingId = 1,
                    ProgramId = 1,
                    DayOfWeek = DayOfWeek.Friday,
                });
        }
    }
}
