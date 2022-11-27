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
                .IsRequired();

            builder.Property(x => x.Name)
                .HasColumnName(@"Name")
                .HasColumnType("nvarchar(40)")
                .IsRequired();


            builder.Property(x => x.Description)
                .HasColumnName(@"Description")
                .HasColumnType("nvarchar(300)")
                .IsRequired();

            builder
                .HasMany(x => x.Equipment)
                .WithMany(x => x.Exercises);

            builder
                .HasMany(x => x.Trainings)
                .WithMany(x => x.Exercises);
        }
    }
}
