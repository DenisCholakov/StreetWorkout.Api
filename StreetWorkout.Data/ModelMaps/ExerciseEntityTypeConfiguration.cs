using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StreetWorkout.Data.Models;

namespace StreetWorkout.Data.ModelMaps
{
    public class ExerciseEntityTypeConfiguration : IEntityTypeConfiguration<Exercise>
    {
        public void Configure(EntityTypeBuilder<Exercise> builder)
        {
            builder.ToTable("Exercises");
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

            builder.Property(x => x.ImageUrl)
                .HasColumnName(@"ImageUrl")
                .HasColumnType("nvarchar(1000)");


            builder.Property(x => x.Description)
                .HasColumnName(@"Description")
                .HasColumnType("nvarchar(300)")
                .IsRequired();

            builder
                .HasMany(x => x.Equipment)
                .WithMany(x => x.Exercises);

            builder
                .HasMany(x => x.ExerciseTrainings)
                .WithOne(x => x.Exercise)
                .HasForeignKey(x => x.ExerciseId);

            builder.HasData(
                new Exercise
                {
                    Id = 1,
                    Name = "Pull up",
                    Description = "Really basic exercise.",
                },
                new Exercise
                {
                    Id = 2,
                    Name = "Push up",
                    Description = "Another basic exercise"
                },
                new Exercise
                {
                    Id = 3,
                    Name = "Archer push up",
                    Description = "An interesting push up"
                });
        }
    }
}
